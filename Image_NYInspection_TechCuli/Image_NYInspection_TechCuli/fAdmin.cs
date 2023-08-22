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
    public partial class fAdmin : Form
    {
        private UserLoginModel lguserMain1;
        private LoginShow loginshow = new LoginShow();
        public fAdmin()
        {
            InitializeComponent();

        }
        // Ta cho hàm tạo của Form2 kế thừa this()
        // và để nó nhận tham số là 1 kiểu string sau
        public fAdmin(UserLoginModel lguserMain2) : this()
        {
            lguserMain1 = lguserMain2;
            StartMain();
        }
        private void fAdmin_Load(object sender, EventArgs e)
        {
            ShowDataUser();
        }
        void ShowDataUser()
        {
            string query = "Select id,firstname,lastname,username,pass,Time,Phanquyen,Machine from members";
            showData(query);
        }
        void StartMain()
        {
            lblUser.Text = lguserMain1.Username;
            lblName.Text = lguserMain1.FirstName + lguserMain1.LastName;
            lblquyenhan.Text = lguserMain1.Phanquyen.ToString();
            lblTime1.Text = lguserMain1.Time.ToString();
            nmPQ.Maximum = lguserMain1.Phanquyen;
            lblMachine.Text = lguserMain1.Machine1;
        }
        void showData(string query)
        {
            loginshow.showdataUser(DtgShowData,query,"10.119.164.33");

        }

        private void DtgShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = DtgShowData.Rows[e.RowIndex];
            txtUser.Text = Convert.ToString(row.Cells["username"].Value);
            txtPass.Text = Convert.ToString(row.Cells["pass"].Value);
            txtLastName.Text = Convert.ToString(row.Cells["lastname"].Value);
            txtFirstName.Text = Convert.ToString(row.Cells["firstname"].Value);
            nmPQ.Text = Convert.ToString(row.Cells["Phanquyen"].Value);
            lblID.Text = Convert.ToString(row.Cells["ID"].Value);
            cbbMachine.Text = Convert.ToString(row.Cells["Machine"].Value);
            btnedit.Enabled = (int.Parse(lblquyenhan.Text) > Convert.ToInt32(row.Cells["Phanquyen"].Value)) ? true : false;
            btndel.Enabled = (int.Parse(lblquyenhan.Text) > Convert.ToInt32(row.Cells["Phanquyen"].Value)) ? true : false;
        }
        private void ADDUser()
        {
            string qry = "Select count(ID) as so_luong from members where username = '"+txtUser.Text+"'";
            if (loginshow.CountUser(qry, "10.119.164.33") <= 0 && int.Parse(lblquyenhan.Text) > nmPQ.Value)
            {
                string query = "INSERT INTO members (firstname, lastname, username, pass, Phanquyen, machine) VALUES('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtUser.Text + "', '" + txtPass.Text + "'," + nmPQ.Value + ",'"+cbbMachine.Text+"'); ";
                showData(query);
            }
            else
            {
                MessageBox.Show("usernam already exists Or lYour account is not sufficiently authorized");
            }
        }
        private void ModifyUser()
        {
            string qry = "Select count(ID) as so_luong from members where username = '" + txtUser.Text + "'";
            if (loginshow.CountUser(qry, "10.119.164.33") > 0 && int.Parse(lblquyenhan.Text) > nmPQ.Value)
            {
                string query = "delete from members where id = " + int.Parse(lblID.Text) + "";
                showData(query);
            }
            else
            {
                MessageBox.Show("Check Username Or lYour account is not sufficiently authorized");
            }
        }
        private void DelUser()
        {
            string qry = "Select count(ID) as so_luong from members where username = '" + txtUser.Text + "'";
            if (loginshow.CountUser(qry, "10.119.164.33") > 0 && int.Parse(lblquyenhan.Text) > nmPQ.Value)
            {
                string query = "delete from members where id = " + int.Parse(lblID.Text) + "";
                showData(query);
            }
            else
            {
                MessageBox.Show("Check Username Or lYour account is not sufficiently authorized");
            }
        }
        private void SearchUser()
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ADDUser();
            ShowDataUser();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            ModifyUser();
            ShowDataUser();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            DelUser();
            ShowDataUser();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchUser();
            ShowDataUser();
        }

        private void btnSnipt_Click(object sender, EventArgs e)
        {
            fMain f = new fMain(lguserMain1);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
