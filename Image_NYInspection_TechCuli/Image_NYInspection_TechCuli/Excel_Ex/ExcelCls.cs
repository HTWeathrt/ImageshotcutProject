using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spiral.Core;
using Spire.Xls;
using System.Drawing;


namespace Image_NYInspection_TechCuli.Excel_Ex
{
    internal class ExcelCls
    {
        public Bitmap CroppedImage { get; set; }
        public void ExcelLoading(int Width , int Height)
        {
            Spire.Xls.Workbook workbook = new Spire.Xls.Workbook();
            workbook.LoadFromFile("Data.xlsx");
            Spire.Xls.Worksheet sheet = workbook.Worksheets[0];


            string fileName = "C:\\Users\\LENOVO\\Desktop\\XA\\Co.jpg";
            System.Drawing.Image image = Image.FromFile(fileName);
            // Starting column and row positions for inserting images

            // Cắt ảnh tại vị trí (x,y) với kích thước (width,height)  block_block06_001.jpg
            int x = Convert.ToInt32(100);
            int y = Convert.ToInt32(300);
            int width = Convert.ToInt32(386);
            int height = Convert.ToInt32(385);

            Rectangle rect = new Rectangle(x, y, width, height);
            Bitmap croppedImage = new Bitmap(rect.Width, rect.Height);

            using (Graphics g = Graphics.FromImage(croppedImage))
            {
                g.DrawImage(image, new Rectangle(0, 0, croppedImage.Width, croppedImage.Height),
                   rect, GraphicsUnit.Pixel);
            }
            //ExcelPicture Imageexel = sheet.Pictures.Add(hàngBắtĐầu, cộtBắtĐầu, hìnhẢnhCắt);
            ExcelPicture Imageexel = sheet.Pictures.Add(3, 4, croppedImage);
            Imageexel.Width = 210; // Đặt chiều rộng hình ảnh trong Excel
            Imageexel.Height = 96; // Đặt chiều cao hình ảnh trong Excel
            int ExcelSizeW = 30;
            int ExcelSizeH = 75;

            sheet.Range["D3"].ColumnWidth = ExcelSizeW;
            sheet.Range["D3"].RowHeight = ExcelSizeH; // Đặt chiều cao hàng


            Imageexel.LeftColumnOffset = 2;
            Imageexel.TopRowOffset = 2;

            Imageexel.ResizeBehave = ResizeBehaveType.MoveAndResize; //not working
            //workbook.SaveToFile("AlignPicture.xlsx", ExcelVersion.Version2016)

            // Save the Excel file after inserting all images
            workbook.SaveToFile("AlignPicture.xlsx", ExcelVersion.Version2016);

        }

    }
}
