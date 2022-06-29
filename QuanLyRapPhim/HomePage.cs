using QuanLyRapPhim.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    public partial class HomePage : Form
    {
        MovieForStaffUC movieForStaffUC = new MovieForStaffUC();
        ShowTimesForStaffUC showTimesForStaff = new ShowTimesForStaffUC();  
        public HomePage()
        {
            movieForStaffUC.Dock = DockStyle.Fill;
            showTimesForStaff.Dock = DockStyle.Fill;
            InitializeComponent();
            ClickNavigateButton(btnMovie);
            pnlScreen.Controls.Clear();
            pnlScreen.Controls.Add(movieForStaffUC);
        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            ClickNavigateButton(btnMovie);
            pnlScreen.Controls.Clear();
            pnlScreen.Controls.Add(movieForStaffUC);

        }
        void ClickNavigateButton(Guna.UI2.WinForms.Guna2GradientButton btn)
        {
            pnlNavigate.Top = btn.Top;
            pnlNavigate.Height = btn.Height;
            btn.BackColor = Color.FromArgb(46, 51, 73);
        }




        private void btnMovie_Leave(object sender, EventArgs e)
        {
            btnMovie.BackColor = Color.FromArgb(40, 42, 52);
        }



        private void btnShowTimes_Click(object sender, EventArgs e)
        {
            ClickNavigateButton(btnShowTimes);
            pnlScreen.Controls.Clear();
            pnlScreen.Controls.Add(showTimesForStaff);
        }

        private void btnShowTimes_Leave(object sender, EventArgs e)
        {
            btnShowTimes.BackColor = Color.FromArgb(40, 42, 52);
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Store.loginForm.Show();
        }


    }
}