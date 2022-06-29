using System.Windows.Forms;

namespace QuanLyRapPhim.Admin
{
    partial class MovieUC
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.dtpDayEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDayStart = new System.Windows.Forms.DateTimePicker();
            this.clbGenre = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.txtNation = new System.Windows.Forms.TextBox();
            this.lblNation = new System.Windows.Forms.Label();
            this.lblDayEnd = new System.Windows.Forms.Label();
            this.lblDayStart = new System.Windows.Forms.Label();
            this.txtMovieLength = new System.Windows.Forms.TextBox();
            this.lblMovieLength = new System.Windows.Forms.Label();
            this.txtDescripe = new System.Windows.Forms.TextBox();
            this.lblDescripe = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.btnChooseImage = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSee = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgVMovie = new System.Windows.Forms.DataGridView();
            this.picFilm = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.dtpDayEnd);
            this.panel1.Controls.Add(this.dtpDayStart);
            this.panel1.Controls.Add(this.clbGenre);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtActor);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtDirector);
            this.panel1.Controls.Add(this.lblDirector);
            this.panel1.Controls.Add(this.txtNation);
            this.panel1.Controls.Add(this.lblNation);
            this.panel1.Controls.Add(this.lblDayEnd);
            this.panel1.Controls.Add(this.lblDayStart);
            this.panel1.Controls.Add(this.txtMovieLength);
            this.panel1.Controls.Add(this.lblMovieLength);
            this.panel1.Controls.Add(this.txtDescripe);
            this.panel1.Controls.Add(this.lblDescripe);
            this.panel1.Controls.Add(this.txtMovieName);
            this.panel1.Controls.Add(this.lblMovieName);
            this.panel1.Controls.Add(this.txtMovieID);
            this.panel1.Controls.Add(this.lblMovieID);
            this.panel1.Controls.Add(this.btnChooseImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1535, 274);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.picFilm);
            this.panel4.Location = new System.Drawing.Point(332, 16);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 209);
            this.panel4.TabIndex = 26;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(1167, 240);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(158, 22);
            this.txtYear.TabIndex = 25;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYear.Location = new System.Drawing.Point(1029, 245);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(127, 21);
            this.lblYear.TabIndex = 24;
            this.lblYear.Text = "Năm sản xuất";
            // 
            // dtpDayEnd
            // 
            this.dtpDayEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpDayEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDayEnd.Location = new System.Drawing.Point(1167, 93);
            this.dtpDayEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDayEnd.Name = "dtpDayEnd";
            this.dtpDayEnd.Size = new System.Drawing.Size(158, 22);
            this.dtpDayEnd.TabIndex = 23;
            // 
            // dtpDayStart
            // 
            this.dtpDayStart.CustomFormat = "dd/MM/yyyy";
            this.dtpDayStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDayStart.Location = new System.Drawing.Point(1169, 61);
            this.dtpDayStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDayStart.Name = "dtpDayStart";
            this.dtpDayStart.Size = new System.Drawing.Size(156, 22);
            this.dtpDayStart.TabIndex = 22;
            // 
            // clbGenre
            // 
            this.clbGenre.CheckOnClick = true;
            this.clbGenre.FormattingEnabled = true;
            this.clbGenre.Location = new System.Drawing.Point(633, 162);
            this.clbGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbGenre.MultiColumn = true;
            this.clbGenre.Name = "clbGenre";
            this.clbGenre.Size = new System.Drawing.Size(353, 106);
            this.clbGenre.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(633, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Thể loại";
            // 
            // txtActor
            // 
            this.txtActor.Location = new System.Drawing.Point(1167, 207);
            this.txtActor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(158, 22);
            this.txtActor.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(1029, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Diễn viên";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(1167, 170);
            this.txtDirector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(158, 22);
            this.txtDirector.TabIndex = 17;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDirector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDirector.Location = new System.Drawing.Point(1029, 175);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(86, 21);
            this.lblDirector.TabIndex = 16;
            this.lblDirector.Text = "Dạo diễn";
            // 
            // txtNation
            // 
            this.txtNation.Location = new System.Drawing.Point(1167, 132);
            this.txtNation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNation.Name = "txtNation";
            this.txtNation.Size = new System.Drawing.Size(158, 22);
            this.txtNation.TabIndex = 15;
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNation.Location = new System.Drawing.Point(1029, 136);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(85, 21);
            this.lblNation.TabIndex = 14;
            this.lblNation.Text = "Quốc gia";
            // 
            // lblDayEnd
            // 
            this.lblDayEnd.AutoSize = true;
            this.lblDayEnd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDayEnd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDayEnd.Location = new System.Drawing.Point(1029, 98);
            this.lblDayEnd.Name = "lblDayEnd";
            this.lblDayEnd.Size = new System.Drawing.Size(81, 21);
            this.lblDayEnd.TabIndex = 12;
            this.lblDayEnd.Text = "Ngày KT";
            // 
            // lblDayStart
            // 
            this.lblDayStart.AutoSize = true;
            this.lblDayStart.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDayStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDayStart.Location = new System.Drawing.Point(1029, 63);
            this.lblDayStart.Name = "lblDayStart";
            this.lblDayStart.Size = new System.Drawing.Size(82, 21);
            this.lblDayStart.TabIndex = 10;
            this.lblDayStart.Text = "Ngày KC";
            // 
            // txtMovieLength
            // 
            this.txtMovieLength.Location = new System.Drawing.Point(1167, 20);
            this.txtMovieLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieLength.Name = "txtMovieLength";
            this.txtMovieLength.Size = new System.Drawing.Size(158, 22);
            this.txtMovieLength.TabIndex = 9;
            // 
            // lblMovieLength
            // 
            this.lblMovieLength.AutoSize = true;
            this.lblMovieLength.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMovieLength.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMovieLength.Location = new System.Drawing.Point(1029, 25);
            this.lblMovieLength.Name = "lblMovieLength";
            this.lblMovieLength.Size = new System.Drawing.Size(102, 21);
            this.lblMovieLength.TabIndex = 8;
            this.lblMovieLength.Text = "Thời lượng";
            // 
            // txtDescripe
            // 
            this.txtDescripe.Location = new System.Drawing.Point(742, 97);
            this.txtDescripe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripe.Name = "txtDescripe";
            this.txtDescripe.Size = new System.Drawing.Size(158, 22);
            this.txtDescripe.TabIndex = 7;
            // 
            // lblDescripe
            // 
            this.lblDescripe.AutoSize = true;
            this.lblDescripe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDescripe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescripe.Location = new System.Drawing.Point(633, 100);
            this.lblDescripe.Name = "lblDescripe";
            this.lblDescripe.Size = new System.Drawing.Size(58, 21);
            this.lblDescripe.TabIndex = 6;
            this.lblDescripe.Text = "Mô tả";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(742, 62);
            this.txtMovieName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(158, 22);
            this.txtMovieName.TabIndex = 5;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMovieName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMovieName.Location = new System.Drawing.Point(633, 65);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(89, 21);
            this.lblMovieName.TabIndex = 4;
            this.lblMovieName.Text = "Tên Phim";
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(742, 26);
            this.txtMovieID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(158, 22);
            this.txtMovieID.TabIndex = 3;
            this.txtMovieID.TextChanged += new System.EventHandler(this.txtMovieID_TextChanged);
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMovieID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMovieID.Location = new System.Drawing.Point(633, 30);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(83, 21);
            this.lblMovieID.TabIndex = 2;
            this.lblMovieID.Text = "Mã Phim";
            this.lblMovieID.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChooseImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChooseImage.FillColor = System.Drawing.Color.AliceBlue;
            this.btnChooseImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChooseImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChooseImage.Location = new System.Drawing.Point(398, 229);
            this.btnChooseImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnChooseImage.Size = new System.Drawing.Size(85, 35);
            this.btnChooseImage.TabIndex = 1;
            this.btnChooseImage.Text = "Chọn";
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.btnSee);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 274);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1535, 50);
            this.panel2.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(424, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 43);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(288, 5);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 43);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsert.Location = new System.Drawing.Point(152, 5);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(130, 43);
            this.btnInsert.TabIndex = 19;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSee
            // 
            this.btnSee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSee.Location = new System.Drawing.Point(13, 5);
            this.btnSee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(133, 43);
            this.btnSee.TabIndex = 18;
            this.btnSee.Text = "Xem";
            this.btnSee.UseVisualStyleBackColor = true;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgVMovie);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 324);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1535, 223);
            this.panel3.TabIndex = 2;
            // 
            // dgVMovie
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgVMovie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVMovie.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgVMovie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVMovie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgVMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVMovie.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgVMovie.Location = new System.Drawing.Point(0, 0);
            this.dgVMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgVMovie.Name = "dgVMovie";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVMovie.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgVMovie.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgVMovie.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgVMovie.RowTemplate.Height = 29;
            this.dgVMovie.Size = new System.Drawing.Size(1535, 223);
            this.dgVMovie.TabIndex = 24;
            // 
            // picFilm
            // 
            this.picFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFilm.Location = new System.Drawing.Point(0, 0);
            this.picFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFilm.Name = "picFilm";
            this.picFilm.Size = new System.Drawing.Size(208, 205);
            this.picFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFilm.TabIndex = 0;
            this.picFilm.TabStop = false;
            // 
            // MovieUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MovieUC";
            this.Size = new System.Drawing.Size(1535, 547);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFilm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnChooseImage;
        private Panel panel2;
        private Panel panel3;
        private Label lblMovieID;
        private Label label10;
        private TextBox txtActor;
        private Label label9;
        private TextBox txtDirector;
        private Label lblDirector;
        private TextBox txtNation;
        private Label lblNation;
        private Label lblDayEnd;
        private Label lblDayStart;
        private TextBox txtMovieLength;
        private Label lblMovieLength;
        private TextBox txtDescripe;
        private Label lblDescripe;
        private TextBox txtMovieName;
        private Label lblMovieName;
        private TextBox txtMovieID;
        private CheckedListBox clbGenre;
        private DateTimePicker dtpDayEnd;
        private DateTimePicker dtpDayStart;
        private TextBox txtYear;
        private Label lblYear;
        private Panel panel4;
        private PictureBox picFilm;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnSee;
        private DataGridView dgVMovie;
    }
}
