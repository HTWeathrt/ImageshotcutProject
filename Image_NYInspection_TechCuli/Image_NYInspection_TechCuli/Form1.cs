using Image_NYInspection_TechCuli.Show;
using Microsoft.AspNetCore.Http;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;


namespace Image_NYInspection_TechCuli
{
    public partial class fImageSnipt : Form
    {
        private string name;
        public fImageSnipt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void str_datetime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void stop_datetime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }
        void selectDataLine()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*string path = "C:\\Users\\Administrator\\Pictures\\New folder\\1.PNG";
            byte[] imgdata = System.IO.File.ReadAllBytes(path);*/
            string query = "INSERT INTO tet2 (name) VALUES ('"+ImgtoBase()+"');";
            MySqlConnection connection = new MySqlConnection("server = 127.0.0.1; Initial Catalog = cpaoi_parameter; User = root; Password = 1; Port = 3036;");
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "Select name from tet2 where id = 6";
            MySqlConnection connection = new MySqlConnection("server = 127.0.0.1; Initial Catalog = cpaoi_parameter; User = root; Password = 1; Port = 3036;");
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    name = reader.GetString("name");
                    //MessageBox.Show(linkMCL +"ll"+ linkSR);
                }
            }
            ptr1.Image = BasetoImg(name);
            BasetoImg(name).Save(@"F:\f\pic.jpg", System.Drawing.Imaging.ImageFormat.Png);
            connection.Close();
        }
        public byte[] imageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Gif);
            return ms.ToArray();
        }
        #region convert img to base64
      /*  public string ImageToBase64(string path)
        {
            // string path = "D:\SampleImage.jpg";
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }*/
        #endregion
        private string ImgtoBase()
        {
            string path = "C:\\Users\\Administrator\\Pictures\\New folder\\Capture.PNG";
            byte[] imgdata = System.IO.File.ReadAllBytes(path);
            string base64String = Convert.ToBase64String(imgdata);
            return base64String;
        }
        private Image BasetoImg(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
    }
}
