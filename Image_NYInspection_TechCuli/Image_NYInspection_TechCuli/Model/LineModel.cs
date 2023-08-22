using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_NYInspection_TechCuli.Data
{
    public class LineModel
    {
        private string nameLine;
        public string NameLine { get => nameLine; set => nameLine = value; }
        public string Ip { get => ip; set => ip = value; }

        private string ip;
        public LineModel(string nameLine, string Ip)
        {
            this.NameLine = nameLine;
            this.Ip = Ip;
        }
    }
  

}
