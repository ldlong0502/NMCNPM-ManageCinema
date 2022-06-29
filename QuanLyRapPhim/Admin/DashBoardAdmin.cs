using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.Admin
{
    public partial class DashBoardAdmin : Form
    {

        public DashBoardAdmin()
        {
            RevenueUC revenueUC = new RevenueUC();
            revenueUC.Dock = DockStyle.Fill;
            InitializeComponent();
            pnlTask.Controls.Clear();
            pnlTask.Controls.Add(revenueUC);
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            DataUC userControl = new DataUC();
            userControl.Dock = DockStyle.Fill;
            pnlTask.Controls.Clear();
            pnlTask.Controls.Add(userControl);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        { 
            CustomerUC userControl = new CustomerUC();
            userControl.Dock = DockStyle.Fill;
            pnlTask.Controls.Clear();
            pnlTask.Controls.Add(userControl);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            StaffUC userControl = new StaffUC();
            userControl.Dock = DockStyle.Fill;
            pnlTask.Controls.Clear();
            pnlTask.Controls.Add(userControl);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AccountUser userControl = new AccountUser();
            userControl.Dock = DockStyle.Fill;
            pnlTask.Controls.Clear();
            pnlTask.Controls.Add(userControl);
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            RevenueUC userControl = new RevenueUC();
            userControl.Dock = DockStyle.Fill;
            pnlTask.Controls.Clear();
            pnlTask.Controls.Add(userControl);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Store.admin = new DashBoardAdmin();
            Form_Store.loginForm.Show();
        }

        private void DashBoardAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Store.loginForm.Show();
        }
    }
}
