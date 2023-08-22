using Image_NYInspection_TechCuli.Data;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Image_NYInspection_TechCuli.Connect
{
    public class DataProductConnect
    {
        private ProductData dataproduct = new ProductData();
        public void showDataProduct(DataGridView dtg, string query, string ip)
        {
            dataproduct = new ProductData();
            dtg.DataSource = dataproduct.ShowDataProduct(query, ip, "cp_aoi", "ami", "protnc");
        }
        public int CountProduct(string query, string ip)
        {
            dataproduct = new ProductData();
            return dataproduct.CountDataProduct(query,ip, "cp_aoi", "ami", "protnc");
        }
        public static List<ProductModel> connectMysql(string IP_Connection, string query)
        {
            ProductModel prd;
            //List<string> list = new List<string>();
            List<ProductModel> product1 = new List<ProductModel>();
            MySqlConnection connection = new MySqlConnection("server= " + IP_Connection + "; Initial Catalog = cp_aoi; User = ami; Password = protnc");
            MySQLConnect adt = new MySQLConnect();
            connection.Open();
            MySqlCommand command1 = adt.showcommand(query, IP_Connection, "cp_aoi", "ami", "protnc");
            using (MySqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    string bcrid = reader.GetString("bcrid");
                    DateTime Date = reader.GetDateTime("start_datetime");
                    string datee = Date.ToString("yyyy" + @"\\" + "MM" + @"\\" + "dd");
                    string localID = reader.GetString("localID");
                    string judge = reader.GetString("judge");
                    int idproduct = reader.GetInt32("idproduct");
                    string Zone = localID.Substring(localID.Length - 3, 3);
                    string nameIMG = bcrid + "_OrgBlk";
                    string linkMCL = @"\d\image\VP1\" + datee;
                    string linkSR = @"\d\image\VP2\" + datee;
                    if (Zone == "A_1" || Zone == "A_2")
                    {
                        linkMCL = @"\\192.168.200.131\d\image\VP1\" + datee;
                        linkSR = @"\\192.168.200.132\d\image\VP2\" + datee;
                    }
                    else
                    {
                        linkMCL = @"\\192.168.200.231\d\image\VP1\" + datee;
                        linkSR = @"\\192.168.200.232\d\image\VP2\" + datee;
                    }
                    prd = new ProductModel(idproduct, localID, judge, bcrid, Zone, linkMCL, linkSR, datee, nameIMG);
                    product1.Add(prd);
                    //list.Add(bcrid);
                    //MessageBox.Show(linkMCL +"ll"+ linkSR);
                }
            }
            connection.Close();
            return product1;
        }
    }
}
