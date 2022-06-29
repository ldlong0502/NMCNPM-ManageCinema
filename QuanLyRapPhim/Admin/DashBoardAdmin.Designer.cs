using System.Windows.Forms;

namespace QuanLyRapPhim.Admin
{
    partial class DashBoardAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccount = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnStaff = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnData = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAnalytics = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlTask = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.BtnData);
            this.panel1.Controls.Add(this.btnAnalytics);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 125);
            this.panel1.TabIndex = 0;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.White;
            this.btnAccount.BorderRadius = 5;
            this.btnAccount.BorderThickness = 2;
            this.btnAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccount.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnAccount.FillColor2 = System.Drawing.Color.Transparent;
            this.btnAccount.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAccount.Image = global::QuanLyRapPhim.Properties.Resources.account;
            this.btnAccount.Location = new System.Drawing.Point(780, 33);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.PressedColor = System.Drawing.Color.Silver;
            this.btnAccount.Size = new System.Drawing.Size(165, 56);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Text = "Tài Khoản";
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.White;
            this.btnStaff.BorderRadius = 5;
            this.btnStaff.BorderThickness = 2;
            this.btnStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaff.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaff.FillColor = System.Drawing.Color.Transparent;
            this.btnStaff.FillColor2 = System.Drawing.Color.Transparent;
            this.btnStaff.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnStaff.ForeColor = System.Drawing.Color.Black;
            this.btnStaff.Image = global::QuanLyRapPhim.Properties.Resources.staff;
            this.btnStaff.Location = new System.Drawing.Point(593, 33);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.PressedColor = System.Drawing.Color.Silver;
            this.btnStaff.Size = new System.Drawing.Size(165, 56);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "Nhân Viên";
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.White;
            this.btnCustomer.BorderRadius = 5;
            this.btnCustomer.BorderThickness = 2;
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomer.FillColor2 = System.Drawing.Color.Transparent;
            this.btnCustomer.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnCustomer.Image = global::QuanLyRapPhim.Properties.Resources.customer;
            this.btnCustomer.Location = new System.Drawing.Point(406, 33);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.PressedColor = System.Drawing.Color.Silver;
            this.btnCustomer.Size = new System.Drawing.Size(165, 56);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Khách Hàng";
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // BtnData
            // 
            this.BtnData.BackColor = System.Drawing.Color.White;
            this.BtnData.BorderRadius = 5;
            this.BtnData.BorderThickness = 2;
            this.BtnData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnData.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnData.FillColor = System.Drawing.Color.Transparent;
            this.BtnData.FillColor2 = System.Drawing.Color.Transparent;
            this.BtnData.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.BtnData.ForeColor = System.Drawing.Color.Black;
            this.BtnData.Image = global::QuanLyRapPhim.Properties.Resources.data;
            this.BtnData.Location = new System.Drawing.Point(222, 33);
            this.BtnData.Name = "BtnData";
            this.BtnData.PressedColor = System.Drawing.Color.Silver;
            this.BtnData.Size = new System.Drawing.Size(165, 56);
            this.BtnData.TabIndex = 1;
            this.BtnData.Text = "Dữ Liệu";
            this.BtnData.Click += new System.EventHandler(this.BtnData_Click);
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.BackColor = System.Drawing.Color.White;
            this.btnAnalytics.BorderRadius = 5;
            this.btnAnalytics.BorderThickness = 2;
            this.btnAnalytics.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnalytics.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnalytics.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnalytics.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnalytics.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnalytics.FillColor = System.Drawing.Color.Transparent;
            this.btnAnalytics.FillColor2 = System.Drawing.Color.Transparent;
            this.btnAnalytics.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAnalytics.ForeColor = System.Drawing.Color.Black;
            this.btnAnalytics.Image = global::QuanLyRapPhim.Properties.Resources.analytics;
            this.btnAnalytics.Location = new System.Drawing.Point(40, 33);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.PressedColor = System.Drawing.Color.Silver;
            this.btnAnalytics.Size = new System.Drawing.Size(165, 56);
            this.btnAnalytics.TabIndex = 0;
            this.btnAnalytics.Text = "Thống Kê";
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
            // 
            // pnlTask
            // 
            this.pnlTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTask.Location = new System.Drawing.Point(0, 125);
            this.pnlTask.Name = "pnlTask";
            this.pnlTask.Size = new System.Drawing.Size(1251, 684);
            this.pnlTask.TabIndex = 1;
            // 
            // DashBoardAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1251, 809);
            this.Controls.Add(this.pnlTask);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DashBoardAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoardAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashBoardAdmin_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAccount;
        private Guna.UI2.WinForms.Guna2GradientButton btnStaff;
        private Guna.UI2.WinForms.Guna2GradientButton btnCustomer;
        private Guna.UI2.WinForms.Guna2GradientButton BtnData;
        private Guna.UI2.WinForms.Guna2GradientButton btnAnalytics;
        private Panel pnlTask;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}