using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Image_NYInspection_TechCuli.Connect
{
    public class MySQLConnect
    {

        public void loadData()
        {

        }
        public static DataTable connectMysql(string query, string ip, string nameDatabase, string user, string pass, string port = null )
        {
            MySqlConnection connection = new MySqlConnection("server=" + ip + "; Initial Catalog = "+ nameDatabase + "; User = "+ user + "; Password = "+ pass + ";");
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
        public static int CountData(string query, string ip, string nameDatabase, string user, string pass, string port = null)
        {
            using (var conn = new MySqlConnection("server=" + ip + "; Initial Catalog = " + nameDatabase + "; User = " + user + "; Password = " + pass + ";"))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count;
                }
            }
        }
        private MySqlCommand connectCommand(string query, string ip, string nameDatabase, string user, string pass, string port = null)
        {
            MySqlConnection connection = new MySqlConnection("server=" + ip + "; Initial Catalog = " + nameDatabase + "; User = " + user + "; Password = " + pass + ";");
            try
            {
                connection.Open();
                //string query = queryy;
                MySqlCommand command = new MySqlCommand(query, connection);
                return command;
            }
            catch
            {
                connection.Close();
                return null;
            }
        }
        public MySqlCommand showcommand(string qry, string ip, string nameDatabase, string user, string pass, string port = null)
        {
            MySqlCommand ldd = connectCommand(qry, ip, nameDatabase, user, pass);
            return ldd;
        }
    }
}
