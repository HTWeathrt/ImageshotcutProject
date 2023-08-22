using Image_NYInspection_TechCuli.Connect;
using Image_NYInspection_TechCuli.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_NYInspection_TechCuli.Show
{
    public class LineShow
    {
        public LineRootData GetLine;
        public void GetJsonValue(string link)
        {
            GetLine = LineConnect.LineValue(link);
        }
    }
}
