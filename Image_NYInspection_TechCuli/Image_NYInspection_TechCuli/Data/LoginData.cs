using Image_NYInspection_TechCuli.Connect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_NYInspection_TechCuli.Data
{
    public class LoginData
    {
        public int CountUser(string query, string ip, string nameData, string user, string pass, string port = null)
        {
            return MySQLConnect.CountData(query, ip, nameData, user, pass);
            // "cp_aoi", "ami", "protnc"
        }
        public DataTable ShowDataUser(string query, string ip, string nameData, string user, string pass, string port = null)
        {
            return MySQLConnect.connectMysql(query, ip, nameData, user, pass);
        }
    }
}
