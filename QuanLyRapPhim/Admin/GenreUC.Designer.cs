using System.Windows.Forms;

namespace QuanLyRapPhim.Admin
{
    partial class GenreUC
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
            this.txtGenreDescripe = new System.Windows.Forms.TextBox();
            this.lblDescripe = new System.Windows.Forms.Label();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.lblGenreName = new System.Windows.Forms.Label();
            this.txtGenreID = new System.Windows.Forms.TextBox();
            this.lblGenreID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgVGenre = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnSee);
            this.panel1.Controls.Add(this.txtGenreDescripe);
            this.panel1.Controls.Add(this.lblDescripe);
            this.panel1.Controls.Add(this.txtGenreName);
            this.panel1.Controls.Add(this.lblGenreName);
            this.panel1.Controls.Add(this.txtGenreID);
            this.panel1.Controls.Add(this.lblGenreID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1535, 292);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(372, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 61);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(255, 225);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 61);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(138, 225);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(111, 61);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSee
            // 
            this.btnSee.Location = new System.Drawing.Point(21, 225);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(111, 61);
            this.btnSee.TabIndex = 14;
            this.btnSee.Text = "Xem";
            this.btnSee.UseVisualStyleBackColor = true;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // txtGenreDescripe
            // 
            this.txtGenreDescripe.Location = new System.Drawing.Point(824, 114);
            this.txtGenreDescripe.Multiline = true;
            this.txtGenreDescripe.Name = "txtGenreDescripe";
            this.txtGenreDescripe.Size = new System.Drawing.Size(302, 89);
            this.txtGenreDescripe.TabIndex = 13;
            // 
            // lblDescripe
            // 
            this.lblDescripe.AutoSize = true;
            this.lblDescripe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescripe.Location = new System.Drawing.Point(704, 116);
            this.lblDescripe.Name = "lblDescripe";
            this.lblDescripe.Size = new System.Drawing.Size(58, 21);
            this.lblDescripe.TabIndex = 12;
            this.lblDescripe.Text = "Mô tả";
            // 
            // txtGenreName
            // 
            this.txtGenreName.Location = new System.Drawing.Point(824, 70);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(302, 27);
            this.txtGenreName.TabIndex = 11;
            // 
            // lblGenreName
            // 
            this.lblGenreName.AutoSize = true;
            this.lblGenreName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenreName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenreName.Location = new System.Drawing.Point(704, 72);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(110, 21);
            this.lblGenreName.TabIndex = 10;
            this.lblGenreName.Text = "Tên thể loại";
            // 
            // txtGenreID
            // 
            this.txtGenreID.Location = new System.Drawing.Point(824, 26);
            this.txtGenreID.Name = "txtGenreID";
            this.txtGenreID.Size = new System.Drawing.Size(302, 27);
            this.txtGenreID.TabIndex = 9;
            // 
            // lblGenreID
            // 
            this.lblGenreID.AutoSize = true;
            this.lblGenreID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenreID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGenreID.Location = new System.Drawing.Point(704, 28);
            this.lblGenreID.Name = "lblGenreID";
            this.lblGenreID.Size = new System.Drawing.Size(104, 21);
            this.lblGenreID.TabIndex = 8;
            this.lblGenreID.Text = "Mã thể loại";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgVGenre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1535, 392);
            this.panel2.TabIndex = 1;
            // 
            // dgVGenre
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgVGenre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVGenre.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgVGenre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVGenre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgVGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgVGenre.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgVGenre.Location = new System.Drawing.Point(0, 0);
            this.dgVGenre.Name = "dgVGenre";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVGenre.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgVGenre.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgVGenre.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgVGenre.RowTemplate.Height = 29;
            this.dgVGenre.Size = new System.Drawing.Size(1535, 392);
            this.dgVGenre.TabIndex = 24;
            // 
            // GenreUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GenreUC";
            this.Size = new System.Drawing.Size(1535, 684);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVGenre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnSee;
        private TextBox txtGenreDescripe;
        private Label lblDescripe;
        private TextBox txtGenreName;
        private Label lblGenreName;
        private TextBox txtGenreID;
        private Label lblGenreID;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private DataGridView dgVGenre;
    }
}
