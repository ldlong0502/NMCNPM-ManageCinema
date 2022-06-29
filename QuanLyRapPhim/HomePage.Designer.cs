using System.Windows.Forms;

namespace QuanLyRapPhim
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlNavigate = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnShowTimes = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnMovie = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlScreen = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.guna2Panel1.Controls.Add(this.pnlNavigate);
            this.guna2Panel1.Controls.Add(this.btnShowTimes);
            this.guna2Panel1.Controls.Add(this.btnMovie);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(357, 564);
            this.guna2Panel1.TabIndex = 0;
            // 
            // pnlNavigate
            // 
            this.pnlNavigate.BackColor = System.Drawing.Color.Navy;
            this.pnlNavigate.BorderRadius = 2;
            this.pnlNavigate.CustomBorderThickness = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.pnlNavigate.FillColor = System.Drawing.Color.White;
            this.pnlNavigate.FillColor2 = System.Drawing.Color.White;
            this.pnlNavigate.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pnlNavigate.Location = new System.Drawing.Point(0, 164);
            this.pnlNavigate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNavigate.Name = "pnlNavigate";
            this.pnlNavigate.Size = new System.Drawing.Size(10, 40);
            this.pnlNavigate.TabIndex = 5;
            // 
            // btnShowTimes
            // 
            this.btnShowTimes.BorderColor = System.Drawing.Color.Transparent;
            this.btnShowTimes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowTimes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowTimes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowTimes.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowTimes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowTimes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowTimes.FillColor = System.Drawing.Color.Empty;
            this.btnShowTimes.FillColor2 = System.Drawing.Color.Empty;
            this.btnShowTimes.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnShowTimes.ForeColor = System.Drawing.Color.White;
            this.btnShowTimes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnShowTimes.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnShowTimes.Image = global::QuanLyRapPhim.Properties.Resources.showtime;
            this.btnShowTimes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnShowTimes.ImageSize = new System.Drawing.Size(30, 30);
            this.btnShowTimes.Location = new System.Drawing.Point(0, 203);
            this.btnShowTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowTimes.Name = "btnShowTimes";
            this.btnShowTimes.Size = new System.Drawing.Size(357, 62);
            this.btnShowTimes.TabIndex = 3;
            this.btnShowTimes.Text = "Lịch Chiếu";
            this.btnShowTimes.Click += new System.EventHandler(this.btnShowTimes_Click);
            this.btnShowTimes.Leave += new System.EventHandler(this.btnShowTimes_Leave);
            // 
            // btnMovie
            // 
            this.btnMovie.BackColor = System.Drawing.Color.Transparent;
            this.btnMovie.BorderColor = System.Drawing.Color.Transparent;
            this.btnMovie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMovie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMovie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMovie.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMovie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovie.FillColor = System.Drawing.Color.Empty;
            this.btnMovie.FillColor2 = System.Drawing.Color.Empty;
            this.btnMovie.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnMovie.ForeColor = System.Drawing.Color.White;
            this.btnMovie.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnMovie.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnMovie.Image = global::QuanLyRapPhim.Properties.Resources.movie;
            this.btnMovie.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMovie.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMovie.Location = new System.Drawing.Point(0, 131);
            this.btnMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Size = new System.Drawing.Size(357, 72);
            this.btnMovie.TabIndex = 1;
            this.btnMovie.Text = "Phim";
            this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click);
            this.btnMovie.Leave += new System.EventHandler(this.btnMovie_Leave);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.pictureBox2);
            this.guna2Panel2.Controls.Add(this.pictureBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(357, 131);
            this.guna2Panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::QuanLyRapPhim.Properties.Resources.DREam_CInema__3__removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(93, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::QuanLyRapPhim.Properties.Resources.DREam_CInema__2__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlScreen
            // 
            this.pnlScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScreen.Location = new System.Drawing.Point(357, 0);
            this.pnlScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(878, 564);
            this.pnlScreen.TabIndex = 1;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1235, 564);
            this.Controls.Add(this.pnlScreen);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePage_FormClosed);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2GradientButton btnMovie;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlNavigate;
        private Guna.UI2.WinForms.Guna2GradientButton btnShowTimes;
        private Panel pnlScreen;
    }
}