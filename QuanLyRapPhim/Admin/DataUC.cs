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
    public partial class DataUC : UserControl
    {
        public DataUC()
        {
            InitializeComponent();
            ClickNavigateButton(btnTypeScreen);
            TypeScreenUC userControl = new TypeScreenUC();
            userControl.Dock = DockStyle.Fill;
            pnlData.Controls.Clear();
            pnlData.Controls.Add(userControl);
        }

        void ClickNavigateButton(Guna.UI2.WinForms.Guna2GradientButton btn)
        {
            pnlNavigate.Top = btn.Top;
            pnlNavigate.Height = btn.Height;
            btn.BackColor = Color.FromArgb(46, 51, 73);
        }


        private void btnMovie_Click(object sender, EventArgs e)
        {
            ClickNavigateButton(btnMovie);
            MovieUC userControl = new MovieUC();
            userControl.Dock = DockStyle.Fill;
            pnlData.Controls.Clear();
            pnlData.Controls.Add(userControl);
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            ClickNavigateButton(btnType);
            GenreUC userControl = new GenreUC();
            userControl.Dock = DockStyle.Fill;
            pnlData.Controls.Clear();
            pnlData.Controls.Add(userControl);
        }

        private void btnTypeScreen_Click(object sender, EventArgs e)
        {
            ClickNavigateButton(btnTypeScreen);
            TypeScreenUC userControl = new TypeScreenUC();
            userControl.Dock = DockStyle.Fill;
            pnlData.Controls.Clear();
            pnlData.Controls.Add(userControl);
        }

        private void btnFormatMovie_Click(object sender, EventArgs e)
        {
            ClickNavigateButton(btnFormatMovie);
            FormatMovieUC userControl = new FormatMovieUC();
            userControl.Dock = DockStyle.Fill;
            pnlData.Controls.Clear();
            pnlData.Controls.Add(userControl);
        }

        private void btnRoom_Cinema_Click(object sender, EventArgs e)
        {
            ClickNavigateButton(btnRoom_Cinema);
            RoomCinemaUC userControl = new RoomCinemaUC();
            userControl.Dock = DockStyle.Fill;
            pnlData.Controls.Clear();
            pnlData.Controls.Add(userControl);
        }

        private void btnShowTimes_Click(object sender, EventArgs e)
        {
            ClickNavigateButton(btnShowTimes);
            ShowTimesUC userControl = new ShowTimesUC();
            userControl.Dock = DockStyle.Fill;
            pnlData.Controls.Clear();
            pnlData.Controls.Add(userControl);
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            ClickNavigateButton(btnTicket);
            TicketUC userControl = new TicketUC();
            userControl.Dock = DockStyle.Fill;
            pnlData.Controls.Clear();
            pnlData.Controls.Add(userControl);
        }

        private void btnTypeScreen_Leave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2GradientButton btn = sender as Guna.UI2.WinForms.Guna2GradientButton;
            btn.BackColor = Color.FromArgb(40, 42, 52);
        }

        private void btnRoom_Cinema_Leave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2GradientButton btn = sender as Guna.UI2.WinForms.Guna2GradientButton;
            btn.BackColor = Color.FromArgb(40, 42, 52);
        }

        private void btnType_Leave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2GradientButton btn = sender as Guna.UI2.WinForms.Guna2GradientButton;
            btn.BackColor = Color.FromArgb(40, 42, 52);
        }

        private void btnMovie_Leave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2GradientButton btn = sender as Guna.UI2.WinForms.Guna2GradientButton;
            btn.BackColor = Color.FromArgb(40, 42, 52);
        }

        private void btnFormatMovie_Leave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2GradientButton btn = sender as Guna.UI2.WinForms.Guna2GradientButton;
            btn.BackColor = Color.FromArgb(40, 42, 52);
        }

        private void btnShowTimes_Leave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2GradientButton btn = sender as Guna.UI2.WinForms.Guna2GradientButton;
            btn.BackColor = Color.FromArgb(40, 42, 52);
        }

        private void btnTicket_Leave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2GradientButton btn = sender as Guna.UI2.WinForms.Guna2GradientButton;
            btn.BackColor = Color.FromArgb(40, 42, 52);
        }
    }
}
