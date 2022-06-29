using System.Windows.Forms;

namespace QuanLyRapPhim.Admin
{
    partial class RoomCinemaUC
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSee = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.txtSeatPerRow = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtNumRows = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxScreen = new System.Windows.Forms.ComboBox();
            this.lblMovieLength = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNation = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvRoom = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnSee);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1535, 307);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(389, 254);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 48);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(266, 254);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 48);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsert.Location = new System.Drawing.Point(143, 254);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(117, 48);
            this.btnInsert.TabIndex = 47;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSee
            // 
            this.btnSee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSee.Location = new System.Drawing.Point(20, 254);
            this.btnSee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(117, 48);
            this.btnSee.TabIndex = 46;
            this.btnSee.Text = "Xem";
            this.btnSee.UseVisualStyleBackColor = true;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDirector);
            this.groupBox2.Controls.Add(this.txtSeat);
            this.groupBox2.Controls.Add(this.txtSeatPerRow);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblYear);
            this.groupBox2.Controls.Add(this.txtNumRows);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(894, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(489, 224);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chỗ ngồi";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDirector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDirector.Location = new System.Drawing.Point(69, 41);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(111, 21);
            this.lblDirector.TabIndex = 32;
            this.lblDirector.Text = "Số chỗ ngồi";
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(215, 38);
            this.txtSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(207, 26);
            this.txtSeat.TabIndex = 33;
            // 
            // txtSeatPerRow
            // 
            this.txtSeatPerRow.Location = new System.Drawing.Point(215, 108);
            this.txtSeatPerRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSeatPerRow.Name = "txtSeatPerRow";
            this.txtSeatPerRow.Size = new System.Drawing.Size(207, 26);
            this.txtSeatPerRow.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(69, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 21);
            this.label9.TabIndex = 34;
            this.label9.Text = "Số hàng ghế";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYear.Location = new System.Drawing.Point(69, 111);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(129, 21);
            this.lblYear.TabIndex = 38;
            this.lblYear.Text = "Ghế mỗi hàng";
            // 
            // txtNumRows
            // 
            this.txtNumRows.Location = new System.Drawing.Point(215, 74);
            this.txtNumRows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumRows.Name = "txtNumRows";
            this.txtNumRows.Size = new System.Drawing.Size(207, 26);
            this.txtNumRows.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxScreen);
            this.groupBox1.Controls.Add(this.lblMovieLength);
            this.groupBox1.Controls.Add(this.txtRoomID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNation);
            this.groupBox1.Controls.Add(this.txtRoomName);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(344, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(495, 224);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Phòng";
            // 
            // cbxScreen
            // 
            this.cbxScreen.FormattingEnabled = true;
            this.cbxScreen.Location = new System.Drawing.Point(207, 111);
            this.cbxScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxScreen.Name = "cbxScreen";
            this.cbxScreen.Size = new System.Drawing.Size(235, 26);
            this.cbxScreen.TabIndex = 44;
            // 
            // lblMovieLength
            // 
            this.lblMovieLength.AutoSize = true;
            this.lblMovieLength.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMovieLength.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMovieLength.Location = new System.Drawing.Point(81, 44);
            this.lblMovieLength.Name = "lblMovieLength";
            this.lblMovieLength.Size = new System.Drawing.Size(95, 21);
            this.lblMovieLength.TabIndex = 26;
            this.lblMovieLength.Text = "Mã phòng";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(207, 41);
            this.txtRoomID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(235, 26);
            this.txtRoomID.TabIndex = 27;
            this.txtRoomID.TextChanged += new System.EventHandler(this.txtRoomID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(81, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "Màn hình";
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNation.Location = new System.Drawing.Point(81, 153);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(98, 21);
            this.lblNation.TabIndex = 30;
            this.lblNation.Text = "Tình trạng";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(207, 78);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(235, 26);
            this.txtRoomName.TabIndex = 41;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(207, 150);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(235, 26);
            this.txtStatus.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(81, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tên phòng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvRoom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 307);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1535, 240);
            this.panel2.TabIndex = 1;
            // 
            // dtgvRoom
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRoom.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvRoom.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvRoom.GridColor = System.Drawing.SystemColors.Highlight;
            this.dtgvRoom.Location = new System.Drawing.Point(0, 0);
            this.dtgvRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvRoom.Name = "dtgvRoom";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvRoom.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgvRoom.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvRoom.RowTemplate.Height = 29;
            this.dtgvRoom.Size = new System.Drawing.Size(1535, 240);
            this.dtgvRoom.TabIndex = 24;
            // 
            // RoomCinemaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RoomCinemaUC";
            this.Size = new System.Drawing.Size(1535, 547);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private Label lblDirector;
        private TextBox txtSeat;
        private TextBox txtSeatPerRow;
        private Label label9;
        private Label lblYear;
        private TextBox txtNumRows;
        private GroupBox groupBox1;
        private ComboBox cbxScreen;
        private Label lblMovieLength;
        private TextBox txtRoomID;
        private Label label1;
        private Label lblNation;
        private TextBox txtRoomName;
        private TextBox txtStatus;
        private Label label2;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnSee;
        private Panel panel2;
        private DataGridView dtgvRoom;
    }
}
