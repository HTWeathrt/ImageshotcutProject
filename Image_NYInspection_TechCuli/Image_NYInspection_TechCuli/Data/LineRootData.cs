using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_NYInspection_TechCuli.Data
{


    public class LineRootData
    {
        public Machine Machine { get; set; }
    }

    public class Machine
    {
        public CPAOI CPAOI { get; set; }
    }

    public class CPAOI
    {
        public Line_IP[] Line_IP { get; set; }
    }

    public class Line_IP
    {
        public string Name { get; set; }
        public string IP { get; set; }
    }


}
