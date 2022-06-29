using System.Windows.Forms;

namespace QuanLyRapPhim.Admin
{
    partial class ShowTimesUC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShowTimesID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchByMovieName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDayStart = new System.Windows.Forms.Label();
            this.lblDayEnd = new System.Windows.Forms.Label();
            this.cbxRoomID = new System.Windows.Forms.ComboBox();
            this.dtpHour = new System.Windows.Forms.DateTimePicker();
            this.cbxFormatID = new System.Windows.Forms.ComboBox();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.lblMovieLength = new System.Windows.Forms.Label();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblNation = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.txtTypeScreen = new System.Windows.Forms.TextBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvShowTimes = new System.Windows.Forms.DataGridView();
            this.toolTipRoomCinema = new System.Windows.Forms.ToolTip(this.components);
            this.ptrSearch = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnSee);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtShowTimesID);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1535, 302);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(312, 250);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 39);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(214, 250);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 39);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsert.Location = new System.Drawing.Point(116, 250);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(92, 39);
            this.btnInsert.TabIndex = 51;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSee
            // 
            this.btnSee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSee.Location = new System.Drawing.Point(18, 250);
            this.btnSee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(92, 39);
            this.btnSee.TabIndex = 50;
            this.btnSee.Text = "Xem";
            this.btnSee.UseVisualStyleBackColor = true;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(651, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Mã lịch chiếu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtShowTimesID
            // 
            this.txtShowTimesID.Location = new System.Drawing.Point(776, 4);
            this.txtShowTimesID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShowTimesID.Name = "txtShowTimesID";
            this.txtShowTimesID.Size = new System.Drawing.Size(210, 22);
            this.txtShowTimesID.TabIndex = 41;
            this.txtShowTimesID.TextChanged += new System.EventHandler(this.txtShowTimesID_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ptrSearch);
            this.groupBox2.Controls.Add(this.txtSearchByMovieName);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(911, 38);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(367, 201);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // txtSearchByMovieName
            // 
            this.txtSearchByMovieName.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.txtSearchByMovieName.Location = new System.Drawing.Point(59, 28);
            this.txtSearchByMovieName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchByMovieName.Name = "txtSearchByMovieName";
            this.txtSearchByMovieName.Size = new System.Drawing.Size(221, 28);
            this.txtSearchByMovieName.TabIndex = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDayStart);
            this.groupBox1.Controls.Add(this.lblDayEnd);
            this.groupBox1.Controls.Add(this.cbxRoomID);
            this.groupBox1.Controls.Add(this.dtpHour);
            this.groupBox1.Controls.Add(this.cbxFormatID);
            this.groupBox1.Controls.Add(this.dtpDay);
            this.groupBox1.Controls.Add(this.lblMovieLength);
            this.groupBox1.Controls.Add(this.txtTicketPrice);
            this.groupBox1.Controls.Add(this.lblYear);
            this.groupBox1.Controls.Add(this.lblNation);
            this.groupBox1.Controls.Add(this.lblDirector);
            this.groupBox1.Controls.Add(this.txtTypeScreen);
            this.groupBox1.Controls.Add(this.txtMovieName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(272, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(608, 201);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // lblDayStart
            // 
            this.lblDayStart.AutoSize = true;
            this.lblDayStart.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDayStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDayStart.Location = new System.Drawing.Point(345, 27);
            this.lblDayStart.Name = "lblDayStart";
            this.lblDayStart.Size = new System.Drawing.Size(54, 21);
            this.lblDayStart.TabIndex = 28;
            this.lblDayStart.Text = "Ngày";
            // 
            // lblDayEnd
            // 
            this.lblDayEnd.AutoSize = true;
            this.lblDayEnd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDayEnd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDayEnd.Location = new System.Drawing.Point(353, 62);
            this.lblDayEnd.Name = "lblDayEnd";
            this.lblDayEnd.Size = new System.Drawing.Size(39, 21);
            this.lblDayEnd.TabIndex = 29;
            this.lblDayEnd.Text = "Giờ";
            // 
            // cbxRoomID
            // 
            this.cbxRoomID.FormattingEnabled = true;
            this.cbxRoomID.Location = new System.Drawing.Point(162, 57);
            this.cbxRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxRoomID.Name = "cbxRoomID";
            this.cbxRoomID.Size = new System.Drawing.Size(168, 29);
            this.cbxRoomID.TabIndex = 41;
            // 
            // dtpHour
            // 
            this.dtpHour.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.dtpHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHour.Location = new System.Drawing.Point(413, 58);
            this.dtpHour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHour.Name = "dtpHour";
            this.dtpHour.ShowUpDown = true;
            this.dtpHour.Size = new System.Drawing.Size(158, 28);
            this.dtpHour.TabIndex = 37;
            // 
            // cbxFormatID
            // 
            this.cbxFormatID.FormattingEnabled = true;
            this.cbxFormatID.Location = new System.Drawing.Point(162, 19);
            this.cbxFormatID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxFormatID.Name = "cbxFormatID";
            this.cbxFormatID.Size = new System.Drawing.Size(168, 29);
            this.cbxFormatID.TabIndex = 40;
            this.cbxFormatID.SelectedValueChanged += new System.EventHandler(this.cbxFormatID_SelectedValueChanged);
            // 
            // dtpDay
            // 
            this.dtpDay.CustomFormat = "dd/MM/yyyy";
            this.dtpDay.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.dtpDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDay.Location = new System.Drawing.Point(415, 26);
            this.dtpDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(156, 28);
            this.dtpDay.TabIndex = 36;
            // 
            // lblMovieLength
            // 
            this.lblMovieLength.AutoSize = true;
            this.lblMovieLength.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMovieLength.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMovieLength.Location = new System.Drawing.Point(16, 26);
            this.lblMovieLength.Name = "lblMovieLength";
            this.lblMovieLength.Size = new System.Drawing.Size(126, 21);
            this.lblMovieLength.TabIndex = 26;
            this.lblMovieLength.Text = "Mã định dạng";
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Location = new System.Drawing.Point(162, 165);
            this.txtTicketPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.Size = new System.Drawing.Size(168, 28);
            this.txtTicketPrice.TabIndex = 39;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYear.Location = new System.Drawing.Point(16, 174);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(63, 21);
            this.lblYear.TabIndex = 38;
            this.lblYear.Text = "Giá vé";
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNation.Location = new System.Drawing.Point(16, 65);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(116, 21);
            this.lblNation.TabIndex = 30;
            this.lblNation.Text = "Phòng chiếu";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDirector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDirector.Location = new System.Drawing.Point(16, 103);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(53, 21);
            this.lblDirector.TabIndex = 32;
            this.lblDirector.Text = "Phim";
            // 
            // txtTypeScreen
            // 
            this.txtTypeScreen.Location = new System.Drawing.Point(162, 132);
            this.txtTypeScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTypeScreen.Name = "txtTypeScreen";
            this.txtTypeScreen.Size = new System.Drawing.Size(168, 28);
            this.txtTypeScreen.TabIndex = 35;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(162, 95);
            this.txtMovieName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(168, 28);
            this.txtMovieName.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(16, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 21);
            this.label9.TabIndex = 34;
            this.label9.Text = "Màn hình";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dtgvShowTimes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 302);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1535, 245);
            this.panel3.TabIndex = 2;
            // 
            // dtgvShowTimes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvShowTimes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvShowTimes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvShowTimes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvShowTimes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvShowTimes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvShowTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShowTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvShowTimes.GridColor = System.Drawing.SystemColors.Highlight;
            this.dtgvShowTimes.Location = new System.Drawing.Point(0, 0);
            this.dtgvShowTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvShowTimes.Name = "dtgvShowTimes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvShowTimes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvShowTimes.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgvShowTimes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvShowTimes.RowTemplate.Height = 29;
            this.dtgvShowTimes.Size = new System.Drawing.Size(1531, 241);
            this.dtgvShowTimes.TabIndex = 24;
            // 
            // ptrSearch
            // 
            this.ptrSearch.Image = global::QuanLyRapPhim.Properties.Resources.search;
            this.ptrSearch.Location = new System.Drawing.Point(297, 28);
            this.ptrSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptrSearch.Name = "ptrSearch";
            this.ptrSearch.Size = new System.Drawing.Size(33, 28);
            this.ptrSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrSearch.TabIndex = 47;
            this.ptrSearch.TabStop = false;
            this.ptrSearch.Click += new System.EventHandler(this.ptrSearch_Click);
            // 
            // ShowTimesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShowTimesUC";
            this.Size = new System.Drawing.Size(1535, 547);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtShowTimesID;
        private GroupBox groupBox2;
        private Label lblDayStart;
        private Label lblDayEnd;
        private DateTimePicker dtpHour;
        private DateTimePicker dtpDay;
        private GroupBox groupBox1;
        private Label lblMovieLength;
        private TextBox txtTicketPrice;
        private Label lblYear;
        private Label lblNation;
        private Label lblDirector;
        private TextBox txtTypeScreen;
        private TextBox txtMovieName;
        private Label label9;
        private Panel panel3;
        private ComboBox cbxRoomID;
        private ComboBox cbxFormatID;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnSee;
        private ToolTip toolTipRoomCinema;
        private PictureBox ptrSearch;
        private TextBox txtSearchByMovieName;
        private DataGridView dtgvShowTimes;
    }
}
