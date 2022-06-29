using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapPhim.DAO;

namespace QuanLyRapPhim
{
    public partial class ChangePassForm : Form
    {
        public ChangePassForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UpdatePassword(string username,string oldpass,string newpass)
        {
            if (AccountDAO.UpdatePasswordForAccount(username,oldpass,newpass))
            {
                MessageBox.Show("Đổi mật khẩu thành công, mật khẩu mới là: "+newpass);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username=txtUsername.Text;
            string oldpass=txtOldPass.Text;
            string newpass=txtNewPass.Text;
            if(txtNewPass.Text ==""||txtOldPass.Text ==""||txtUsername.Text=="")
            { MessageBox.Show("Chưa nhập đủ thông tin"); }
            else { UpdatePassword(username, oldpass, newpass); }
        }
    }
}
