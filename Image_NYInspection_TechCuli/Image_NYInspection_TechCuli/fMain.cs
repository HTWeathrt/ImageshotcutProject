
using Image_NYInspection_TechCuli.Connect;
using Image_NYInspection_TechCuli.Data;
using Image_NYInspection_TechCuli.Show;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;
using Image_NYInspection_TechCuli.Model;
using Image_NYInspection_TechCuli.Excel_Ex;

namespace Image_NYInspection_TechCuli
{
    public partial class fMain : Form
    {
        private LineShow showContent = new LineShow();
        private ParameterShow showParameter = new ParameterShow();
        private LineModel line;
        private PageData page = new PageData();
        private int CountInt;
        private int PageIntSum;
        private int PageIntNow;
        private List<ProductModel> productList;
        private string filePath;
        private UserLoginModel lguserMain1;
        private LoginShow loginshow = new LoginShow();
        public fMain()
        {
            InitializeComponent();
            selectDataLine();
            SelectParameterLimit();
            start();
        }
        public fMain(UserLoginModel lguserMain2) : this()
        {
            lguserMain1 = lguserMain2;
            StartMain();
        }
        void StartMain()
        {
            lblUser.Text = lguserMain1.Username;
            lblName.Text = lguserMain1.FirstName + lguserMain1.LastName;
            lblquyenhan.Text = lguserMain1.Phanquyen.ToString();
            lblTime1.Text = lguserMain1.Time.ToString();
            lblMachine.Text = lguserMain1.Machine1;
            if (lblquyenhan.Text == "0")
            {
                pnlTool3.Visible = false;
                nmShowLimit.Value = 10;
            }
            else
            {
                pnlTool3.Visible = true;
            }
        }
        void start()
        {
            cbbSelectMode.Text = "Config";
            cbbLine.Text = "CPAOI_301";
            CheckPageIsTrue();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(processBar);
            newThread.Start();
            page.Reset();
            PageIntNow = 1;
            Searchdata();
            newThread.Abort();
        }
        private string loadTheoId()
        {
            string dataa = "1";
            List<string> list = new List<string>();
            string[] rows = txtIDSearch.Text.Split(' ');

            StringBuilder sb = new StringBuilder();

            foreach (string row in rows)
            {
                string trimmedRow = row.Trim();
                list.Add(row);

                if (!string.IsNullOrEmpty(trimmedRow))
                {
                    sb.Append(trimmedRow);
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (dataa == "1")
                {
                    dataa = "'" + list[i].ToString() + "'";
                }
                else
                {
                    dataa = dataa + "," + "'" + list[i].ToString() + "'";
                }

            }
            //string qry = "select eqp_name,priority_defect_name,start_datetime,bcrid from product where panelid In (" + dataa + ") limit " + page.lmlow + ", " + Convert.ToInt32(nmShowLimit.Value) + "";
            return dataa;
        }
        void Searchdata()
        {
            string queryConfig = "select idproduct, localID,bcrid, judge, eqp_name, start_datetime from product where bcrid like '%" + txtConfig.Text + "' limit " + page.lmlow + ", " + Convert.ToInt32(nmShowLimit.Value) + "";
            //select eqp_name, priority_defect_name, start_datetime, bcrid from product where panelid In(" + dataa + ") limit " + page.lmlow + ", " + Convert.ToInt32(nmShowLimit.Value) + "
            string queryID = "select idproduct, localID,bcrid, judge, eqp_name, start_datetime from product where bcrid In(" + loadTheoId() + ") limit " + page.lmlow + ", " + Convert.ToInt32(nmShowLimit.Value) + "";
            string queryTime = "select idproduct, localID,bcrid, judge, eqp_name, start_datetime from product where start_datetime >= '" + str_datetime.Text + "' and  start_datetime <='" + stop_datetime.Text + "' limit " + page.lmlow + ", " + Convert.ToInt32(nmShowLimit.Value) + "";
            string queryConfigCount = "select Count(idproduct) from product where bcrid like '%" + txtConfig.Text + "'";
            string queryIDCount = "select Count(idproduct) from product where bcrid In(" + loadTheoId() + ")";
            string queryTimeCount = "select Count(idproduct) from product where start_datetime >= '" + str_datetime.Text + "' and  start_datetime <='" + stop_datetime.Text + "'";
            switch (cbbSelectMode.SelectedIndex)
            {
                case 0:
                    Search(queryConfig);
                    countDataProduct(queryConfigCount);
                    productList = DataProductConnect.connectMysql(line.Ip, queryConfig);
                    break;
                case 1:
                    Search(queryID);
                    countDataProduct(queryIDCount);
                    productList = DataProductConnect.connectMysql(line.Ip, queryID);
                    break;
                case 2:
                    Search(queryTime);
                    countDataProduct(queryTimeCount);
                    productList = DataProductConnect.connectMysql(line.Ip, queryTime);
                    break;
            }
            CountInt = int.Parse(lblCount.Text);
            double count = (double)CountInt;
            PageIntSum = (int)Math.Ceiling(count / (float)nmShowLimit.Value);
            lblSumPage.Text = PageIntSum.ToString();
            lblPageNow.Text = PageIntNow.ToString();
            CheckPageIsTrue();
            showID();
        }
        void showID()
        {
            txtShowID.Clear();
            foreach (var item in productList)
            {
                txtShowID.AppendText(item.Bcrid + Environment.NewLine);
            }
        }
        void Search(string query)
        {
            ProductShow prdtshow = new ProductShow();
            prdtshow.showdataProduct(DtgShowData, query, line.Ip);
        }
        void countDataProduct(string query)
        {
            ProductShow prdtshow = new ProductShow();
            prdtshow.showCountDataProduct(lblCount, query, line.Ip);
        }
        /*private int CalculatorPage(string query)
        {
            ProductShow prdtshow = new ProductShow();
            return prdtshow.CountProduct(query, line.Ip);
        }*/
        private void btnLinkSave_Click(object sender, EventArgs e)
        {

        }
        void selectDataLine()
        {
            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Json";
            string pathFile = path + "\\line.json";
            #region nháp
            //string pt1 = "F:\\SERVER\\Image_NYInspection_TechCuli\\Image_NYInspection_TechCuli\\bin\\Debug\\Json\\line.json";
            /*     DirectoryInfo di1 = new DirectoryInfo(path1);
                  if (!Directory.Exists(path1))
                  {
                      di1.Create();
                     File.CreateText(pathFile1);
                 }
                 if (File.Exists(path1))
                 {
                     File.WriteAllText(pathFile1, jsonString1);
                 }*/
            #endregion
            if (File.Exists(path))
            {
                #region json value
                string jsonString = @"{
						""Machine"":
						{
							""CPAOI"":
							{
								""Line_IP"": 
								[
									{
										""Name"": ""CPAOI_301"",
										""IP"": ""10.119.135.254""
									},
									{
										 ""Name"": ""CPAOI_302"",
										 ""IP"": ""10.119.161.15""
									},
									{
										 ""Name"": ""CPAOI_303"",
										 ""IP"": ""10.119.161.73""
									},
									{
										 ""Name"": ""CPAOI_304"",
										 ""IP"": ""10.119.135.245""
									},
									{
										 ""Name"": ""CPAOI_305"",
										 ""IP"": ""10.119.161.17""
									},
									{
										 ""Name"": ""CPAOI_306"",
										 ""IP"": ""10.119.135.119""
									},
									{
										 ""Name"": ""CPAOI_401"",
										 ""IP"": ""0.0.0.0""
									},
									{
										 ""Name"": ""CPAOI_402"",
										 ""IP"": ""0.0.0.0""
									},
									{
										 ""Name"": ""CPAOI_403"",
										 ""IP"": ""0.0.0.0""
									},
									{
										 ""Name"": ""CPAOI_404"",
										 ""IP"": ""10.121.8.60""
									},
									{
										 ""Name"": ""CPAOI_405"",
										 ""IP"": ""10.121.44.240""
									},
									{
										 ""Name"": ""CPAOI_406"",
										 ""IP"": ""10.121.8.77""
									},
									{
										 ""Name"": ""CPAOI_501"",
										 ""IP"": ""10.121.52.26""
									},
									{
										 ""Name"": ""CPAOI_502"",
										 ""IP"": ""10.121.56.29""
									},
									{
										 ""Name"": ""CPAOI_503"",
										 ""IP"": ""10.121.56.34""
									},
									{
										 ""Name"": ""CPAOI_504"",
										 ""IP"": ""10.121.56.31""
									},
									{
										 ""Name"": ""CPAOI_505"",
										 ""IP"": ""10.121.55.93""
									},
									{
										 ""Name"": ""CPAOI_506"",
										 ""IP"": ""10.121.56.158""
									}
								]
							}
						}
					}
					";
                #endregion
                File.WriteAllText(pathFile, jsonString);
            }

            showContent.GetJsonValue(pathFile);
            foreach (var items in showContent.GetLine.Machine.CPAOI.Line_IP)
            {
                cbbLine.Items.Add(items.Name);
            }
        }

        void SelectParameterLimit()
        {
            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Json";
            string pathFile = path + "\\Parameter.json";
            //string pt1 = "F:\\SERVER\\Image_NYInspection_TechCuli\\Image_NYInspection_TechCuli\\bin\\Debug\\Json\\line.json";
            if (File.Exists(path))
            {
                string jsonString = @"
	{
	""Parameter"": 
	    {
		    ""Page"":
		    {
			    ""limit_height"": 2000
		    },
            ""Link"":
		    {
			    ""linkSaveSR_DIC"": ""D:\\Image_SR_DIC"",
		    	""linkSaveMCL_DIC"": ""D:\\Image_MCL_DIC""
		    }
	    }
    }
";
                File.WriteAllText(pathFile, jsonString);
            }
            showParameter.GetJsonValue(pathFile);
            nmShowLimit.Value = showParameter.GetParameter.Parameter.Page.limit_height;

        }
        public static string BeautifyJson(string json)
        {
            JsonDocument document = JsonDocument.Parse(json);
            var stream = new MemoryStream();
            var writer = new Utf8JsonWriter(stream, new JsonWriterOptions() { Indented = true });
            document.WriteTo(writer);
            writer.Flush();
            return Encoding.UTF8.GetString(stream.ToArray());
        }
        private void cbbLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            line = new LineModel(cbbLine.Text, showContent.GetLine.Machine.CPAOI.Line_IP[cbbLine.SelectedIndex].IP);
        }

        private void cbbSelectMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbSelectMode.SelectedIndex)
            {
                case 0:
                    pModeConfig.Enabled = true; pModeConfig.BackColor = Color.IndianRed;
                    pModeID.Enabled = false; pModeID.BackColor = Color.Transparent;
                    pModeTime.Enabled = false; pModeTime.BackColor = Color.Transparent;
                    break;
                case 1:
                    pModeID.Enabled = true; pModeID.BackColor = Color.IndianRed;
                    pModeConfig.Enabled = false; pModeConfig.BackColor = Color.Transparent;
                    pModeTime.Enabled = false; pModeTime.BackColor = Color.Transparent;
                    break;
                case 2:
                    pModeTime.Enabled = true; pModeTime.BackColor = Color.IndianRed;
                    pModeID.Enabled = false; pModeID.BackColor = Color.Transparent;
                    pModeConfig.Enabled = false; pModeConfig.BackColor = Color.Transparent;
                    break;
            }
        }

        private void fMain_Load(object sender, EventArgs e)
        {
        }


        void processBar()
        {
            WaitForm wt = new WaitForm();
            wt.StartPosition = FormStartPosition.CenterParent;
            System.Windows.Forms.ProgressBar cb = new System.Windows.Forms.ProgressBar();
            cb.Width = 240;
            cb.Height = 23;
            cb.Style = ProgressBarStyle.Marquee;
            cb.Location = new System.Drawing.Point(12, 12);
            wt.Controls.Add(cb);
            wt.FormClosing += Wt_FormClosing; ;
            wt.ShowDialog();
            
        }

        private void Wt_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Quá Thời  Gian chờ");
        }

        private void btnSaveLimit_Click(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "\\Json";
            string pathFile = path + "\\Parameter.json";
            showParameter.GetParameter.Parameter.Page.limit_height = Convert.ToInt32(nmShowLimit.Value);
            string jsonString = System.Text.Json.JsonSerializer.Serialize(showParameter.GetParameter);
            File.WriteAllText(pathFile, jsonString);
        }

        private void btnFindLink_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblPageNow.Text) < int.Parse(lblSumPage.Text))
            {
                page.Increment(Convert.ToInt32(nmShowLimit.Value));
                PageIntNow = page.Page;
                Searchdata();
            }
        }

        void CheckPageIsTrue()
        {
            btnNext.Enabled = (PageIntNow < PageIntSum && PageIntNow >= 1) ? true : false;
            btnBack.Enabled = (PageIntNow <= PageIntSum && PageIntNow > 1) ? true : false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblPageNow.Text) <= int.Parse(lblSumPage.Text))
            {
                page.subtraction(Convert.ToInt32(nmShowLimit.Value));
                PageIntNow = page.Page;
                Searchdata();
            }
        }

        private void btnSnipt_Click(object sender, EventArgs e)
        {
            Thread newThread = new Thread(processBar);
            newThread.Start();
            SniptIMG();
            newThread.Abort();
        }

        void SniptIMG()
        {
            Thread newThread = new Thread(SniptIMGMCL);
            newThread.Start();
            SniptIMGSR();
            Thread.Sleep(20);
        }
        private ExcelCls excelimport;
        void SniptIMGSR()
        {
            //showParameter.GetParameter.Parameter.Link.linkSaveSR_DIC;
            string pathhh1 = showParameter.GetParameter.Parameter.Link.linkSaveSR_DIC;
            if (!Directory.Exists(pathhh1))
            {
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(pathhh1);
            }
            excelimport = new ExcelCls();
            foreach (var item in productList)
            {
                
                bool chekk = false;
                string parentFolderPath = item.LinkSR; // đường dẫn đến thư mục cha
                string[] subfolderPaths = Directory.GetDirectories(parentFolderPath); // lấy danh sách tất cả các thư mục con trong thư mục cha
                foreach (string file in subfolderPaths)
                {
                    if (file.Contains(item.NameIMG))
                    {
                        //string fileName = Path.GetFileName(file); // lấy tên tệp tin
                        filePath = file; // tạo đường dẫn đến tệp tin thực tế+;
                        chekk = true;
                        // textBox1.Text = filePath + "\\block_block0" + comboBox1.Text + "_001." + comboBox2.Text;
                        break;
                        // MessageBox.Show(filePath + "\\block_block0" + comboBox1.Text + "_001." + comboBox2.Text);
                    }
                    else
                    {
                        chekk = false;
                    }
                }
                if (chekk == true)
                {
                    System.Drawing.Image image = Image.FromFile(filePath + "\\" + item.Bcrid + "_B01.bmp");
                    // Tạo tên và đường dẫn cho tập tin ảnh cắt được
                    string path = pathhh1;
                    string fileName = item.NameIMG + "LeftSR.jpg";
                    string fullFilePath = Path.Combine(path, fileName);
                    string fileNameright = item.NameIMG + "rightSR.jpg";
                    string fullFilePathright = Path.Combine(path, fileNameright);
                    // Cắt ảnh tại vị trí (x,y) với kích thước (width,height)  block_block06_001.jpg
                    int x = Convert.ToInt32(1068);
                    int y = Convert.ToInt32(5398);
                    int width = Convert.ToInt32(386);
                    int height = Convert.ToInt32(385);
                    int yright = Convert.ToInt32(2024);

                    Rectangle rect = new Rectangle(x, y, width, height);
                    Bitmap croppedImage = new Bitmap(rect.Width, rect.Height);

                    using (Graphics g = Graphics.FromImage(croppedImage))
                    {
                        g.DrawImage(image, new Rectangle(0, 0, croppedImage.Width, croppedImage.Height),
                           rect, GraphicsUnit.Pixel);
                    }

                    // Lưu ảnh cắt được vào tập tin mới với đường dẫn và tên được chọn bởi người dùng
                    croppedImage.Save(fullFilePath, ImageFormat.Jpeg);

                    Rectangle rect1 = new Rectangle(x, yright, width, height);
                    Bitmap croppedImage1 = new Bitmap(rect1.Width, rect1.Height);

                    using (Graphics g1 = Graphics.FromImage(croppedImage1))
                    {
                        g1.DrawImage(image, new Rectangle(0, 0, croppedImage1.Width, croppedImage1.Height),
                           rect1, GraphicsUnit.Pixel);
                    }
                    
                    excelimport.CroppedImage = croppedImage;
                    excelimport.ExcelLoading(width,height);
                    // Lưu ảnh cắt được vào tập tin mới với đường dẫn và tên được chọn bởi người dùng
                    croppedImage1.Save(fullFilePathright, ImageFormat.Jpeg);
                    image.Dispose();
                    croppedImage.Dispose();
                    croppedImage1.Dispose();
                    Thread.Sleep(70);
                }
                Thread.Sleep(70);
            }
        }
        void SniptIMGMCL()
        {
            string pathhh = showParameter.GetParameter.Parameter.Link.linkSaveMCL_DIC;
            if (!Directory.Exists(pathhh))
            {
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(pathhh);
            }

            foreach (var item in productList)
            {
                bool chekk = false;
                string parentFolderPath = item.LinkMCL; // đường dẫn đến thư mục cha
                string[] subfolderPaths = Directory.GetDirectories(parentFolderPath); // lấy danh sách tất cả các thư mục con trong thư mục cha
                foreach (string file in subfolderPaths)
                {
                    if (file.Contains(item.NameIMG))
                    {
                        //string fileName = Path.GetFileName(file); // lấy tên tệp tin
                        filePath = file; // tạo đường dẫn đến tệp tin thực tế+;
                        chekk = true;
                        // textBox1.Text = filePath + "\\block_block0" + comboBox1.Text + "_001." + comboBox2.Text;
                        break;
                        // MessageBox.Show(filePath + "\\block_block0" + comboBox1.Text + "_001." + comboBox2.Text);
                    }
                    else
                    {
                        chekk = false;

                    }
                }
                if (chekk == true)
                {
                    System.Drawing.Image image = System.Drawing.Image.FromFile(filePath + "\\" + item.Bcrid + "_B03.bmp");
                    // Tạo tên và đường dẫn cho tập tin ảnh cắt được
                    string path = pathhh;
                    string fileName = item.NameIMG + "leftMCL.jpg";
                    string fullFilePath = Path.Combine(path, fileName);
                    string fileNameright = item.NameIMG + "rightMCL.jpg";
                    string fullFilePathright = Path.Combine(path, fileNameright);

                    // Cắt ảnh tại vị trí (x,y) với kích thước (width,height)  block_block06_001.jpg
                    int x = Convert.ToInt32(1350);
                    int y = Convert.ToInt32(5414);
                    int yright = Convert.ToInt32(2024);
                    int width = Convert.ToInt32(400);
                    int height = Convert.ToInt32(362);

                    Rectangle rect = new Rectangle(x, y, width, height);
                    Bitmap croppedImage = new Bitmap(rect.Width, rect.Height);

                    using (Graphics g = Graphics.FromImage(croppedImage))
                    {
                        g.DrawImage(image, new Rectangle(0, 0, croppedImage.Width, croppedImage.Height),
                           rect, GraphicsUnit.Pixel);
                    }
                    // Lưu ảnh cắt được vào tập tin mới với đường dẫn và tên được chọn bởi người dùng
                    croppedImage.Save(fullFilePath, ImageFormat.Jpeg);
                    Rectangle rect1 = new Rectangle(x, yright, width, height);
                    Bitmap croppedImage1 = new Bitmap(rect1.Width, rect1.Height);

                    using (Graphics g1 = Graphics.FromImage(croppedImage1))
                    {
                        g1.DrawImage(image, new Rectangle(0, 0, croppedImage1.Width, croppedImage1.Height),
                           rect1, GraphicsUnit.Pixel);
                    }
                    // Lưu ảnh cắt được vào tập tin mới với đường dẫn và tên được chọn bởi người dùng
                    croppedImage1.Save(fullFilePathright, ImageFormat.Jpeg);
                    croppedImage.Dispose();
                    croppedImage1.Dispose();
                    image.Dispose();
                    Thread.Sleep(100);
                }
                Thread.Sleep(100);
            }
        }

        private void txtIDSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                if (Clipboard.ContainsText())
                {
                    string clipboardText = Clipboard.GetText();
                    // MessageBox.Show(clipboardText);
                    string[] rows = clipboardText.Split('\n');
                    StringBuilder sb = new StringBuilder();

                    foreach (string row in rows)
                    {
                        string trimmedRow = row.Trim();

                        if (!string.IsNullOrEmpty(trimmedRow))
                        {
                            sb.Append(trimmedRow + " ");
                        }
                    }
                    string data = sb.ToString();
                    Clipboard.SetText(data);
                    txtIDSearch.Text = data;
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        public void display(string thongbao)
        {
            MessageBox.Show(thongbao);
        }
        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {

        }
        private void bgWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {

        }

    }
}
