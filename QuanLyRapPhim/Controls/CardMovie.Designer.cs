using System.Windows.Forms;

namespace QuanLyRapPhim.Controls
{
    partial class CardMovie
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMovie_name = new Guna.UI2.WinForms.Guna2Button();
            this.ptrMovie = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMovie_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 242);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 61);
            this.panel1.TabIndex = 3;
            // 
            // btnMovie_name
            // 
            this.btnMovie_name.BorderColor = System.Drawing.Color.White;
            this.btnMovie_name.BorderThickness = 2;
            this.btnMovie_name.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMovie_name.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMovie_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMovie_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMovie_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMovie_name.FillColor = System.Drawing.Color.Transparent;
            this.btnMovie_name.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovie_name.ForeColor = System.Drawing.Color.White;
            this.btnMovie_name.Location = new System.Drawing.Point(0, 0);
            this.btnMovie_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMovie_name.Name = "btnMovie_name";
            this.btnMovie_name.Size = new System.Drawing.Size(295, 61);
            this.btnMovie_name.TabIndex = 0;
            this.btnMovie_name.Click += new System.EventHandler(this.btnMovie_name_Click);
            // 
            // ptrMovie
            // 
            this.ptrMovie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptrMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptrMovie.Location = new System.Drawing.Point(0, 0);
            this.ptrMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptrMovie.Name = "ptrMovie";
            this.ptrMovie.Size = new System.Drawing.Size(295, 242);
            this.ptrMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrMovie.TabIndex = 0;
            this.ptrMovie.TabStop = false;
            // 
            // CardMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptrMovie);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CardMovie";
            this.Size = new System.Drawing.Size(295, 303);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox ptrMovie;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnMovie_name;
    }
}
