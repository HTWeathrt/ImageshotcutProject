using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Image_NYInspection_TechCuli.Data
{
    public class PageData
    {
        private int LMHeight;

        public int lmheight
        {
            get { return LMHeight; }
        }

        private int sumdata;

        public int Sumdata { get => sumdata; set => sumdata = value; }

        private int LMLow;

        public int lmlow
        {
            get { return LMLow; }
        }
        public void Increment(int countOnePage)
        {
            LMLow += countOnePage;
            page += 1;
        }

        public void Reset()
        {
            LMLow = 0;
            page = 1;
        }

        public void subtraction(int countOnePage)
        {
            LMLow -= countOnePage;
            page -= 1;
        }


        private int page;

        public int Page
        {
            get { return page; }
        }
    }
}
