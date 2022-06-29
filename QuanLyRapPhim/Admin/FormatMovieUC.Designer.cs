using System.Windows.Forms;

namespace QuanLyRapPhim.Admin
{
    partial class FormatMovieUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxScreenID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScreenName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxMovieID = new System.Windows.Forms.ComboBox();
            this.lblGenreName = new System.Windows.Forms.Label();
            this.lblDescripe = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSee = new System.Windows.Forms.Button();
            this.txtFormatID = new System.Windows.Forms.TextBox();
            this.lblGenreID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvFormatMovie = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFormatMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnSee);
            this.panel1.Controls.Add(this.txtFormatID);
            this.panel1.Controls.Add(this.lblGenreID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1535, 291);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxScreenID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtScreenName);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(928, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 125);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Màn hình";
            // 
            // cbxScreenID
            // 
            this.cbxScreenID.FormattingEnabled = true;
            this.cbxScreenID.Location = new System.Drawing.Point(138, 34);
            this.cbxScreenID.Name = "cbxScreenID";
            this.cbxScreenID.Size = new System.Drawing.Size(299, 29);
            this.cbxScreenID.TabIndex = 20;
            this.cbxScreenID.SelectedValueChanged += new System.EventHandler(this.cbxScreenID_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã mà hình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên màn hình";
            // 
            // txtScreenName
            // 
            this.txtScreenName.Location = new System.Drawing.Point(138, 71);
            this.txtScreenName.Name = "txtScreenName";
            this.txtScreenName.ReadOnly = true;
            this.txtScreenName.Size = new System.Drawing.Size(300, 28);
            this.txtScreenName.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxMovieID);
            this.groupBox1.Controls.Add(this.lblGenreName);
            this.groupBox1.Controls.Add(this.lblDescripe);
            this.groupBox1.Controls.Add(this.txtMovieName);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(388, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 125);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phim";
            // 
            // cbxMovieID
            // 
            this.cbxMovieID.FormattingEnabled = true;
            this.cbxMovieID.Location = new System.Drawing.Point(115, 32);
            this.cbxMovieID.Name = "cbxMovieID";
            this.cbxMovieID.Size = new System.Drawing.Size(299, 29);
            this.cbxMovieID.TabIndex = 19;
            this.cbxMovieID.SelectedValueChanged += new System.EventHandler(this.cbxMovieID_SelectedValueChanged);
            // 
            // lblGenreName
            // 
            this.lblGenreName.AutoSize = true;
            this.lblGenreName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenreName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenreName.Location = new System.Drawing.Point(6, 36);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(83, 21);
            this.lblGenreName.TabIndex = 10;
            this.lblGenreName.Text = "Mã phim";
            // 
            // lblDescripe
            // 
            this.lblDescripe.AutoSize = true;
            this.lblDescripe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescripe.Location = new System.Drawing.Point(6, 80);
            this.lblDescripe.Name = "lblDescripe";
            this.lblDescripe.Size = new System.Drawing.Size(89, 21);
            this.lblDescripe.TabIndex = 12;
            this.lblDescripe.Text = "Tên phim";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(115, 72);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.ReadOnly = true;
            this.txtMovieName.Size = new System.Drawing.Size(302, 28);
            this.txtMovieName.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(392, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 54);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(267, 231);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 54);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(142, 231);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(119, 54);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSee
            // 
            this.btnSee.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSee.Location = new System.Drawing.Point(17, 231);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(119, 54);
            this.btnSee.TabIndex = 14;
            this.btnSee.Text = "Xem";
            this.btnSee.UseVisualStyleBackColor = true;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // txtFormatID
            // 
            this.txtFormatID.Location = new System.Drawing.Point(785, 21);
            this.txtFormatID.Name = "txtFormatID";
            this.txtFormatID.Size = new System.Drawing.Size(302, 27);
            this.txtFormatID.TabIndex = 9;
            this.txtFormatID.TextChanged += new System.EventHandler(this.txtFormatID_TextChanged);
            // 
            // lblGenreID
            // 
            this.lblGenreID.AutoSize = true;
            this.lblGenreID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenreID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenreID.Location = new System.Drawing.Point(652, 25);
            this.lblGenreID.Name = "lblGenreID";
            this.lblGenreID.Size = new System.Drawing.Size(126, 21);
            this.lblGenreID.TabIndex = 8;
            this.lblGenreID.Text = "Mã định dạng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvFormatMovie);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1535, 393);
            this.panel2.TabIndex = 3;
            // 
            // dtgvFormatMovie
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvFormatMovie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvFormatMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFormatMovie.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvFormatMovie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFormatMovie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvFormatMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFormatMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvFormatMovie.GridColor = System.Drawing.SystemColors.Highlight;
            this.dtgvFormatMovie.Location = new System.Drawing.Point(0, 0);
            this.dtgvFormatMovie.Name = "dtgvFormatMovie";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvFormatMovie.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvFormatMovie.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgvFormatMovie.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvFormatMovie.RowTemplate.Height = 29;
            this.dtgvFormatMovie.Size = new System.Drawing.Size(1535, 393);
            this.dtgvFormatMovie.TabIndex = 24;
            // 
            // FormatMovieUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormatMovieUC";
            this.Size = new System.Drawing.Size(1535, 684);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFormatMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private ComboBox cbxScreenID;
        private Label label1;
        private Label label2;
        private TextBox txtScreenName;
        private GroupBox groupBox1;
        private ComboBox cbxMovieID;
        private Label lblGenreName;
        private Label lblDescripe;
        private TextBox txtMovieName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnSee;
        private TextBox txtFormatID;
        private Label lblGenreID;
        private Panel panel2;
        private DataGridView dtgvFormatMovie;
    }
}
