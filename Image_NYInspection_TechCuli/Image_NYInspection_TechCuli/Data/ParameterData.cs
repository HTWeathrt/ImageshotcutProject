using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_NYInspection_TechCuli.Data
{
    public class ParameterData
    {
        public Parameter Parameter { get; set; }
    }
    public class Parameter
    {
        public Page Page { get; set; }
        public Link Link { get; set; }
    }

    public class Page
    {
        public int limit_height { get; set; }
    }
    public class Link
    {
        public string linkSaveSR_DIC { get; set; }
        public string linkSaveMCL_DIC { get; set; }
    }

}
//-----------

