using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_NYInspection_TechCuli.Data
{
    public class ProductModel
    {
        private int idProduct;
        private string config;
        private string localid;
        private string protifyDefectName;
        private string linkMCL;
        private string linkSR;
        private string judge;
        private string zone;
        private string bcrid;
        private string date;
        private string nameIMG;
        public int IdProduct { get => idProduct; set => idProduct = value; }
        public string LocalID { get => localid; set => localid = value; }
        public string Judge { get => judge; set => judge = value; }
        public string Zone { get => zone; set => zone = value; }
        public string Bcrid { get => bcrid; set => bcrid = value; }
        public string Config { get => config; set => config = value; }
        public string ProtifyDefectName { get => protifyDefectName; set => protifyDefectName = value; }
        public string LinkSR { get => linkSR; set => linkSR = value; }
        public string LinkMCL { get => linkMCL; set => linkMCL = value; }
        public string Date { get => date; set => date = value; }
        public string NameIMG { get => nameIMG; set => nameIMG = value; }
        //private DateTime startTimer;
        public ProductModel(int id, string localid, string judge, string bcrid, string zone, string linkMCL, string linkSR, string date, string nameIMG)
        {
            this.IdProduct = id;
            this.LocalID = localid;
            this.Judge = judge;
            this.Bcrid = bcrid;
            this.Zone = zone;
            this.LinkMCL = linkMCL;
            this.LinkSR = linkSR;
            this.Date = date;
            this.NameIMG = nameIMG;
        }
    }
}
