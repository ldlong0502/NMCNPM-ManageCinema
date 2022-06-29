using System.Windows.Forms;

namespace QuanLyRapPhim.Controls
{
    partial class CardInfoShowTimes
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.flowLayoutShowtine = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(113, 10);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(250, 22);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblMovieName
            // 
            this.lblMovieName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMovieName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMovieName.Location = new System.Drawing.Point(65, 42);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(321, 40);
            this.lblMovieName.TabIndex = 1;
            this.lblMovieName.Text = "label1";
            this.lblMovieName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutShowtine
            // 
            this.flowLayoutShowtine.AutoScroll = true;
            this.flowLayoutShowtine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flowLayoutShowtine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutShowtine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flowLayoutShowtine.Location = new System.Drawing.Point(23, 94);
            this.flowLayoutShowtine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutShowtine.Name = "flowLayoutShowtine";
            this.flowLayoutShowtine.Size = new System.Drawing.Size(436, 129);
            this.flowLayoutShowtine.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnClose.Location = new System.Drawing.Point(439, -3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 34);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CardInfoShowTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(486, 232);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.flowLayoutShowtine);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.dtpDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CardInfoShowTimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CardInfoShowTimes";
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker dtpDate;
        private Label lblMovieName;
        private FlowLayoutPanel flowLayoutShowtine;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}