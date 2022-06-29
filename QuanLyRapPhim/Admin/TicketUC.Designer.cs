using System.Windows.Forms;

namespace QuanLyRapPhim.Admin
{
    partial class TicketUC
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
            this.btnSeeAllShowTimes = new System.Windows.Forms.Button();
            this.btnSeeShowTimesNotCreatedTicket = new System.Windows.Forms.Button();
            this.btnSeeAllTicketByShowTimes = new System.Windows.Forms.Button();
            this.btnSeeTicketSelledByShowTimes = new System.Windows.Forms.Button();
            this.btnDeleteTicketByShowTimes = new System.Windows.Forms.Button();
            this.btnAutoAddTicketByShowTimes = new System.Windows.Forms.Button();
            this.lsvAllListShowTimes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvTicket = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnSeeAllShowTimes);
            this.panel1.Controls.Add(this.btnSeeShowTimesNotCreatedTicket);
            this.panel1.Controls.Add(this.btnSeeAllTicketByShowTimes);
            this.panel1.Controls.Add(this.btnSeeTicketSelledByShowTimes);
            this.panel1.Controls.Add(this.btnDeleteTicketByShowTimes);
            this.panel1.Controls.Add(this.btnAutoAddTicketByShowTimes);
            this.panel1.Controls.Add(this.lsvAllListShowTimes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1535, 279);
            this.panel1.TabIndex = 0;
            // 
            // btnSeeAllShowTimes
            // 
            this.btnSeeAllShowTimes.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSeeAllShowTimes.Location = new System.Drawing.Point(1309, 186);
            this.btnSeeAllShowTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeeAllShowTimes.Name = "btnSeeAllShowTimes";
            this.btnSeeAllShowTimes.Size = new System.Drawing.Size(186, 60);
            this.btnSeeAllShowTimes.TabIndex = 6;
            this.btnSeeAllShowTimes.Text = "Xem Tất Cả Lịch Chiếu";
            this.btnSeeAllShowTimes.UseVisualStyleBackColor = true;
            this.btnSeeAllShowTimes.Click += new System.EventHandler(this.btnSeeAllShowTimes_Click);
            // 
            // btnSeeShowTimesNotCreatedTicket
            // 
            this.btnSeeShowTimesNotCreatedTicket.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSeeShowTimesNotCreatedTicket.Location = new System.Drawing.Point(1065, 186);
            this.btnSeeShowTimesNotCreatedTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeeShowTimesNotCreatedTicket.Name = "btnSeeShowTimesNotCreatedTicket";
            this.btnSeeShowTimesNotCreatedTicket.Size = new System.Drawing.Size(186, 60);
            this.btnSeeShowTimesNotCreatedTicket.TabIndex = 5;
            this.btnSeeShowTimesNotCreatedTicket.Text = "Xem Lịch Chiếu Chưa Được Tạo Vé";
            this.btnSeeShowTimesNotCreatedTicket.UseVisualStyleBackColor = true;
            this.btnSeeShowTimesNotCreatedTicket.Click += new System.EventHandler(this.btnSeeShowTimesNotCreatedTicket_Click);
            // 
            // btnSeeAllTicketByShowTimes
            // 
            this.btnSeeAllTicketByShowTimes.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSeeAllTicketByShowTimes.Location = new System.Drawing.Point(1309, 97);
            this.btnSeeAllTicketByShowTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeeAllTicketByShowTimes.Name = "btnSeeAllTicketByShowTimes";
            this.btnSeeAllTicketByShowTimes.Size = new System.Drawing.Size(186, 66);
            this.btnSeeAllTicketByShowTimes.TabIndex = 4;
            this.btnSeeAllTicketByShowTimes.Text = "Xem Tất Cả Các Vé Theo Lịch Chiếu";
            this.btnSeeAllTicketByShowTimes.UseVisualStyleBackColor = true;
            this.btnSeeAllTicketByShowTimes.Click += new System.EventHandler(this.btnSeeAllTicketByShowTimes_Click);
            // 
            // btnSeeTicketSelledByShowTimes
            // 
            this.btnSeeTicketSelledByShowTimes.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSeeTicketSelledByShowTimes.Location = new System.Drawing.Point(1065, 97);
            this.btnSeeTicketSelledByShowTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeeTicketSelledByShowTimes.Name = "btnSeeTicketSelledByShowTimes";
            this.btnSeeTicketSelledByShowTimes.Size = new System.Drawing.Size(186, 66);
            this.btnSeeTicketSelledByShowTimes.TabIndex = 3;
            this.btnSeeTicketSelledByShowTimes.Text = "Xem Các Vé Được Bán Theo Lịch Chiếu";
            this.btnSeeTicketSelledByShowTimes.UseVisualStyleBackColor = true;
            this.btnSeeTicketSelledByShowTimes.Click += new System.EventHandler(this.btnSeeTicketSelledByShowTimes_Click);
            // 
            // btnDeleteTicketByShowTimes
            // 
            this.btnDeleteTicketByShowTimes.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnDeleteTicketByShowTimes.Location = new System.Drawing.Point(1309, 15);
            this.btnDeleteTicketByShowTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteTicketByShowTimes.Name = "btnDeleteTicketByShowTimes";
            this.btnDeleteTicketByShowTimes.Size = new System.Drawing.Size(186, 64);
            this.btnDeleteTicketByShowTimes.TabIndex = 2;
            this.btnDeleteTicketByShowTimes.Text = "Xóa Vé Theo Lịch Chiếu";
            this.btnDeleteTicketByShowTimes.UseVisualStyleBackColor = true;
            this.btnDeleteTicketByShowTimes.Click += new System.EventHandler(this.btnDeleteTicketByShowTimes_Click);
            // 
            // btnAutoAddTicketByShowTimes
            // 
            this.btnAutoAddTicketByShowTimes.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnAutoAddTicketByShowTimes.Location = new System.Drawing.Point(1065, 15);
            this.btnAutoAddTicketByShowTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAutoAddTicketByShowTimes.Name = "btnAutoAddTicketByShowTimes";
            this.btnAutoAddTicketByShowTimes.Size = new System.Drawing.Size(186, 64);
            this.btnAutoAddTicketByShowTimes.TabIndex = 1;
            this.btnAutoAddTicketByShowTimes.Text = "Tự Động Thêm Vé Theo Lịch Chiếu";
            this.btnAutoAddTicketByShowTimes.UseVisualStyleBackColor = true;
            this.btnAutoAddTicketByShowTimes.Click += new System.EventHandler(this.btnAutoAddTicketByShowTimes_Click);
            // 
            // lsvAllListShowTimes
            // 
            this.lsvAllListShowTimes.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lsvAllListShowTimes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvAllListShowTimes.FullRowSelect = true;
            this.lsvAllListShowTimes.GridLines = true;
            this.lsvAllListShowTimes.Location = new System.Drawing.Point(0, 0);
            this.lsvAllListShowTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvAllListShowTimes.Name = "lsvAllListShowTimes";
            this.lsvAllListShowTimes.Size = new System.Drawing.Size(775, 280);
            this.lsvAllListShowTimes.TabIndex = 0;
            this.lsvAllListShowTimes.UseCompatibleStateImageBehavior = false;
            this.lsvAllListShowTimes.View = System.Windows.Forms.View.Details;
            this.lsvAllListShowTimes.Click += new System.EventHandler(this.lsvAllListShowTimes_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Phòng Chiếu";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Phim";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời gian";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trạng Thái";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvTicket);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 279);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1535, 268);
            this.panel2.TabIndex = 1;
            // 
            // dtgvTicket
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvTicket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTicket.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvTicket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTicket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTicket.GridColor = System.Drawing.SystemColors.Highlight;
            this.dtgvTicket.Location = new System.Drawing.Point(0, 0);
            this.dtgvTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvTicket.Name = "dtgvTicket";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTicket.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvTicket.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgvTicket.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvTicket.RowTemplate.Height = 29;
            this.dtgvTicket.Size = new System.Drawing.Size(1535, 268);
            this.dtgvTicket.TabIndex = 24;
            // 
            // TicketUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TicketUC";
            this.Size = new System.Drawing.Size(1535, 547);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnSeeAllShowTimes;
        private Button btnSeeShowTimesNotCreatedTicket;
        private Button btnSeeAllTicketByShowTimes;
        private Button btnSeeTicketSelledByShowTimes;
        private Button btnDeleteTicketByShowTimes;
        private Button btnAutoAddTicketByShowTimes;
        private ListView lsvAllListShowTimes;
        private Panel panel2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private DataGridView dtgvTicket;
    }
}
