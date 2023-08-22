using Image_NYInspection_TechCuli.Model;
using Image_NYInspection_TechCuli.Show;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_NYInspection_TechCuli
{
    public partial class fLogin : Form
    {
        private LoginShow loginShow = new LoginShow();
        private UserLoginModel lguserMain;
        public fLogin()
        {
            InitializeComponent();
        }
        private int phanquyen;

        public int Phanquyen { get => phanquyen; set => phanquyen = value; }

        private string CheckPass()
        {
            string str = txtPass.Text;
            string[] charsToRemove = new string[] { "=", ",", ".", ";", "'", "+", "(", ")" };
            foreach (var c in charsToRemove)
            {
                str = str.Replace(c, string.Empty);
            }
            return str;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void fLogin_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            login();
        }

        void login()
        {
           
            string query0 = "select id from members where Username = '" + txtUser.Text + "' and pass='" + CheckPass() + "' and Phanquyen <= 1";
            string query1 = "select id from members where Username = '" + txtUser.Text + "' and pass='" + CheckPass() + "' and Phanquyen > 1";
            int CheckUserPQ0 = loginShow.CountUser(query0, "10.119.164.33");
            int CheckUserPQ1 = loginShow.CountUser(query1, "10.119.164.33");
            if (CheckUserPQ0 > 0)
            {
                string query = "Select * from members where Username = '" + txtUser.Text + "' ";
                lguserMain = loginShow.showUserLogin("10.119.164.33", query);
                fMain f = new fMain(lguserMain);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                if (CheckUserPQ1 > 0)
                {
                    string query = "Select * from members where Username = '" + txtUser.Text + "' ";
                    lguserMain = loginShow.showUserLogin( "10.119.164.33", query);
                    fAdmin f = new fAdmin(lguserMain);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Please check UserName And Pass");
                }
            }
            txtPass.Text = "";
        }
        void LoginUser(string query, string ip)
        {
            lguserMain = loginShow.showUserLogin(query,ip);
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
        }

        private void txtPass_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void fLogin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                //form.show()
                login();
            }
        }
    }
}
