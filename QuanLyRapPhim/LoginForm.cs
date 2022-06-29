
using QuanLyRapPhim.DAO;
using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {

            InitializeComponent();
            Form_Store.loginForm = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;
            int result = Login(userName, passWord);
            if (result == 1)
            {
                Account loginAccount = AccountDAO.GetAccountByUserName(userName);
                this.Hide();
                if (loginAccount.Type == 1)
                {
                    Form_Store.admin.ShowDialog();
                }
                else
                {
                    Form_Store.homePage.ShowDialog();
                }
            }
            else if (result == 0)
            {
                MessageBox.Show("SAI TÊN TÀI KHOẢN HOẶC MẬT KHẨU!!!!", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("KẾT NỐI THẤT BẠI", "THÔNG BÁO");
            }
            button1.Enabled = true;
        }

        private int Login(string userName, string passWord)
        {
            return AccountDAO.Login(userName, passWord);
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';

            }
            else
            {
                txtPassword.PasswordChar = '•';

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConnectForm frm = new ConnectForm();
            frm.ShowDialog();
        }


    }
}

