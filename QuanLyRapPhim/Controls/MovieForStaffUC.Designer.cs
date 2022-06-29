using System.Windows.Forms;

namespace QuanLyRapPhim.Controls
{
    partial class MovieForStaffUC
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
            this.clbGenre = new System.Windows.Forms.CheckedListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearchByMovieName = new System.Windows.Forms.TextBox();
            this.flowLayoutMovie = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ptrSearch = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.clbGenre);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 154);
            this.panel1.TabIndex = 2;
            // 
            // clbGenre
            // 
            this.clbGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.clbGenre.CheckOnClick = true;
            this.clbGenre.ColumnWidth = 300;
            this.clbGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbGenre.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.clbGenre.ForeColor = System.Drawing.SystemColors.Window;
            this.clbGenre.FormattingEnabled = true;
            this.clbGenre.Location = new System.Drawing.Point(121, 20);
            this.clbGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbGenre.MultiColumn = true;
            this.clbGenre.Name = "clbGenre";
            this.clbGenre.Size = new System.Drawing.Size(894, 134);
            this.clbGenre.TabIndex = 51;
            this.clbGenre.SelectedIndexChanged += new System.EventHandler(this.clbGenre_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1015, 20);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(124, 134);
            this.panel4.TabIndex = 56;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(44, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(80, 134);
            this.panel5.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(466, 12);
            this.btnReset.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 38);
            this.btnReset.TabIndex = 52;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 20);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 134);
            this.panel3.TabIndex = 55;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1139, 20);
            this.panel2.TabIndex = 54;
            // 
            // txtSearchByMovieName
            // 
            this.txtSearchByMovieName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByMovieName.Location = new System.Drawing.Point(27, 19);
            this.txtSearchByMovieName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchByMovieName.Name = "txtSearchByMovieName";
            this.txtSearchByMovieName.Size = new System.Drawing.Size(356, 26);
            this.txtSearchByMovieName.TabIndex = 48;
            // 
            // flowLayoutMovie
            // 
            this.flowLayoutMovie.AutoScroll = true;
            this.flowLayoutMovie.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutMovie.Location = new System.Drawing.Point(0, 154);
            this.flowLayoutMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutMovie.Name = "flowLayoutMovie";
            this.flowLayoutMovie.Size = new System.Drawing.Size(1139, 416);
            this.flowLayoutMovie.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.panel6.Controls.Add(this.btnReset);
            this.panel6.Controls.Add(this.ptrSearch);
            this.panel6.Controls.Add(this.txtSearchByMovieName);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 154);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1139, 54);
            this.panel6.TabIndex = 5;
            // 
            // ptrSearch
            // 
            this.ptrSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptrSearch.Image = global::QuanLyRapPhim.Properties.Resources.search;
            this.ptrSearch.Location = new System.Drawing.Point(403, 18);
            this.ptrSearch.Name = "ptrSearch";
            this.ptrSearch.Size = new System.Drawing.Size(40, 27);
            this.ptrSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrSearch.TabIndex = 49;
            this.ptrSearch.TabStop = false;
            this.ptrSearch.Click += new System.EventHandler(this.ptrSearch_Click);
            // 
            // MovieForStaffUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.flowLayoutMovie);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MovieForStaffUC";
            this.Size = new System.Drawing.Size(1139, 570);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutMovie;
        private TextBox txtSearchByMovieName;
        private CheckedListBox clbGenre;
        private Button btnReset;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private PictureBox ptrSearch;
    }
}
