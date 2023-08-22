using Image_NYInspection_TechCuli.Connect;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_NYInspection_TechCuli.Show
{
    public class ProductShow
    {
        public void showdataProduct(DataGridView dtg, string query, string ip)
        {
            DataProductConnect prdtShow = new DataProductConnect();
            prdtShow.showDataProduct(dtg,query, ip);
        }

        public void showCountDataProduct(Label lbl, string query, string ip)
        {
            DataProductConnect dataProductConnect = new DataProductConnect();
            lbl.Text = dataProductConnect.CountProduct(query, ip).ToString();
        }

        public int CountProduct(string query, string ip)
        {
            DataProductConnect dataProductConnect = new DataProductConnect();
            return dataProductConnect.CountProduct(query, ip);
        }

    }
}
