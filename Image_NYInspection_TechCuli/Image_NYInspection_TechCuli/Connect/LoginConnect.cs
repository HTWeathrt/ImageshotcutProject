using Image_NYInspection_TechCuli.Data;
using Image_NYInspection_TechCuli.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_NYInspection_TechCuli.Connect
{
    public class LoginConnect
    {
        private LoginData login = new LoginData();
        public int CountUserLogin(string query, string ip)
        {
            login = new LoginData();
            return login.CountUser(query, ip, "login", "ami", "protnc");
        }
        public void showDataUser(DataGridView dtg, string query, string ip)
        {
            login = new LoginData();
            dtg.DataSource = login.ShowDataUser(query, ip, "login", "ami", "protnc");
        }

        public UserLoginModel userInfo(string ip, string query)
        {
            UserLoginModel loginuser = new UserLoginModel(1,"phi","123","123","123","123",1,"cpaoi");
            //List<string> list = new List<string>();
            MySqlConnection connection = new MySqlConnection("server= " + ip + "; Initial Catalog = login; User = ami; Password = protnc");
            MySQLConnect adt = new MySQLConnect();
            connection.Open();
            MySqlCommand command1 = adt.showcommand(query, ip, "login", "ami", "protnc");
            using (MySqlDataReader reader = command1.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    DateTime time = reader.GetDateTime("time");
                    string dateTimer = time.ToString("yyyy-MM-dd HH:mm:ss");
                    string password = reader.GetString("pass");
                    string username = reader.GetString("username");
                    string firstName = reader.GetString("firstName");
                    string lastName = reader.GetString("lastName");
                    int phanquyen = reader.GetInt32("phanquyen");
                    string machine = reader.GetString("Machine");
                    loginuser = new UserLoginModel(id, username, password, firstName, lastName, dateTimer, phanquyen, machine);
                    //list.Add(bcrid);
                    //MessageBox.Show(linkMCL +"ll"+ linkSR);
                }
            }
            connection.Close();
            return loginuser;
        }
    }
}
