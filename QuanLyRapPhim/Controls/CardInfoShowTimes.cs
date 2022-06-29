using QuanLyRapPhim.DAO;
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
    public partial class CardInfoShowTimes : Form
    {
        public String MovieName;
        public Movie Movie;
        public CardInfoShowTimes(Movie movie)
        {
            InitializeComponent();
            LoadShowTime(movie);
        }

        private void LoadShowTime(Movie movie)
        {
            Movie = movie;
            MovieName = movie.Name;
            lblMovieName.Text = movie.Name;
            LoadShowTimeChange();
        }

        private void LoadShowTimeChange()
        {
            flowLayoutShowtine.Controls.Clear();
            DataTable dt = ShowTimesDAO.SearchShowtimeByMovieNameOrdeyByShowtimesASC(MovieName);
            foreach (DataRow dr in dt.Rows)
            {
                DateTime time = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day);
                DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                DateTime lc = (DateTime)dr["Thời gian chiếu"];
                String formatID = (String)dr["Mã định dạng phim"];
                string[] list = lc.ToString().Split(' ');
                if (time.ToString().Split(' ')[0] == list[0])
                {
                    Button btn = new Button();
                    if (DateTime.Compare(lc, DateTime.Now) < 0)
                    {
                        btn.Enabled = false;
                    }
                    btn.Size = new Size(80, 50);
                    btn.Margin = new Padding(5, 5, 5, 5);
                    btn.Text = list[1] + " " + list[2];
                    btn.BackColor = Color.White;
                    btn.Tag = formatID + " " + lc.ToString();
                    btn.Click += Btn_Click;
                    flowLayoutShowtine.Controls.Add(btn);
                }
            }
            if (flowLayoutShowtine.Controls.Count <= 0)
            {
                Label lbl = new Label();
                lbl.Text = "Chưa có lịch chiếu";
                lbl.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                lbl.AutoSize = true;
                lbl.ForeColor = Color.White;
                flowLayoutShowtine.Controls.Add(lbl);
                return;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            ShowTimes time = null;
            Button button = sender as Button;
            string[] list = button.Tag.ToString().Split(' ');
            DataTable data = ShowTimesDAO.GetListShowTimeByFormatMovie(list[0], dtpDate.Value);
            foreach (DataRow row in data.Rows)
            {
                ShowTimes showTimes = new ShowTimes(row);
                if (DateTime.Compare(showTimes.Time, DateTime.Parse(list[1] +" "+list[2]+ " "+list[3])) == 0)
                {
                    time = showTimes;
                    break;
                }
            }
            SellerForm frm = new SellerForm(time, Movie);
            frm.ShowDialog();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadShowTimeChange();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
