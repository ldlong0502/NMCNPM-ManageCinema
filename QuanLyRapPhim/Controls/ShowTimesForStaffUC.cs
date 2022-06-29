﻿using QuanLyRapPhim.DAO;
using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.Controls
{
    public partial class ShowTimesForStaffUC : UserControl
    {
        public ShowTimesForStaffUC()
        {
            InitializeComponent();
            dtpThoiGian.Value = DateTime.Now;
            LoadMovie(dtpThoiGian.Value);
        }

        private void LoadMovie(DateTime date)
        {
            cboFilmName.DataSource = MovieDAO.GetListMovieByDate(date);
            cboFilmName.DisplayMember = "Name";
            
        }

        private void ShowTimesForStaffUC_Load(object sender, EventArgs e)
        {
            LoadMovie(dtpThoiGian.Value);
            timer1.Start();
        }

        private void cboFilmName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFilmName.SelectedIndex != -1)
            {
                cboFormatFilm.DataSource = null;
                lvLichChieu.Items.Clear();
                Movie movie = cboFilmName.SelectedItem as Movie;
                cboFormatFilm.DataSource = FormatMovieDAO.GetListFormatMovieByMovie(movie.ID);
                cboFormatFilm.DisplayMember = "ScreenTypeName";
            }
        }

        private void cboFormatFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFormatFilm.SelectedIndex != -1)
            {
                lvLichChieu.Items.Clear();
                FormatMovie format = cboFormatFilm.SelectedItem as FormatMovie;
                LoadListShowTimeByFilm(format.ID);
            }
        }

        private void LoadListShowTimeByFilm(string formatMovieID)
        {
            DataTable data = ShowTimesDAO.GetListShowTimeByFormatMovie(formatMovieID, dtpThoiGian.Value);
            foreach (DataRow row in data.Rows)
            {
                ShowTimes showTimes = new ShowTimes(row);
                ListViewItem lvi = new ListViewItem("");
                lvi.SubItems.Add(showTimes.CinemaName);
                lvi.SubItems.Add(showTimes.MovieName);
                lvi.SubItems.Add(showTimes.Time.ToShortTimeString());
                lvi.Tag = showTimes;

                string statusShowTimes = TicketDAO.CountTheNumberOfTicketsSoldByShowTime(showTimes.ID)
                    + "/" + TicketDAO.CountToltalTicketByShowTime(showTimes.ID);

                lvi.SubItems.Add(statusShowTimes);

                float status = (float)TicketDAO.CountTheNumberOfTicketsSoldByShowTime(showTimes.ID)
                    / TicketDAO.CountToltalTicketByShowTime(showTimes.ID);

                //thêm ảnh status
                if (status == 1)
                    lvi.ImageIndex = 2;
                else if (status > 0.5f)
                    lvi.ImageIndex = 1;
                else lvi.ImageIndex = 0;

                lvLichChieu.Items.Add(lvi);
            }
        }

        private void dtpThoiGian_ValueChanged(object sender, EventArgs e)
        {
            LoadMovie(dtpThoiGian.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.OnLoad(null);
        }

        private void lvLichChieu_Click(object sender, EventArgs e)
        {
            if (lvLichChieu.SelectedItems.Count > 0)
            {
                timer1.Stop();
                ShowTimes showTimes = lvLichChieu.SelectedItems[0].Tag as ShowTimes;
                Movie movie = cboFilmName.SelectedItem as Movie;
                if (DateTime.Compare(DateTime.Now, showTimes.Time.AddMinutes(30)) > 0)
                {
                    MessageBox.Show("Phim đã được chiếu hơn 30 phútKhông thể mua VéVui lòng xem và chọn lịch chiếu khác", "Thông báo");
                    return;
                }
                SellerForm frm = new SellerForm(showTimes, movie);
                this.Hide();
                frm.ShowDialog();
                this.OnLoad(null);
                this.Show();
            }
        }
    }
}
