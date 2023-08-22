using Image_NYInspection_TechCuli.Connect;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_NYInspection_TechCuli.Data
{
    public class ProductData
    {
        public DataTable ShowDataProduct(string query, string ip, string nameData, string user, string pass, string port = null)
        {
            return MySQLConnect.connectMysql(query, ip, nameData, user, pass);
        }
        public int CountDataProduct(string query, string ip, string nameData, string user, string pass, string port = null)
        {
            return MySQLConnect.CountData(query, ip, nameData, user, pass);
            // "cp_aoi", "ami", "protnc"
        }
    }
}
