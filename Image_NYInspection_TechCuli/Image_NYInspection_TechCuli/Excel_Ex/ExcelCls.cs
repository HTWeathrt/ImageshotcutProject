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
        public void ExcelLoading()
        {
            Spire.Xls.Workbook workbook = new Spire.Xls.Workbook();
            workbook.LoadFromFile("@Data.xlsx");

            Spire.Xls.Worksheet sheet = workbook.Worksheets[0];

            //sheet.Range['D3'].Text = 'Align Picture Within A Cell:';
            sheet.Range[" "].Style.VerticalAlignment = VerticalAlignType.Top;

            //string picPath = @"C:\Users\LENOVO\Desktop\FNL_Flag.svg.jpg";
            ExcelPicture picture = sheet.Pictures.Add(3, 3, CroppedImage);

            picture.Width = 300;
            picture.Height = 160;

            sheet.Range["D3"].ColumnWidth = 50;
            sheet.Range["D3"].RowHeight = 150;
            
            picture.LeftColumnOffset = 100;
            picture.TopRowOffset = 25;

            picture.ResizeBehave = ResizeBehaveType.MoveAndResize; //not working
            workbook.SaveToFile("AlignPicture.xlsx", ExcelVersion.Version2016);
            
        }

    }
}
