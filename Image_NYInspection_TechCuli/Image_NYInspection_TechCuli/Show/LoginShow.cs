using Image_NYInspection_TechCuli.Connect;
using Image_NYInspection_TechCuli.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_NYInspection_TechCuli.Show
{
    public class LoginShow
    {
        private UserLoginModel userlguser = new UserLoginModel(1, "phi", "123", "123", "123", "123",0, "cpaoi");
        public void showdataUser(DataGridView dtg, string query, string ip)
        {
            LoginConnect prdtShow = new LoginConnect();
            prdtShow.showDataUser(dtg, query, ip);
        }
        public int CountUser(string query, string ip)
        {
            LoginConnect loginConnect = new LoginConnect();
            return loginConnect.CountUserLogin(query, ip);
        }
        public UserLoginModel showUserLogin(string ip,string query)
        {
            LoginConnect loginConnect = new LoginConnect();
            userlguser = loginConnect.userInfo(ip,query);
            return userlguser;
        }
    }
}
