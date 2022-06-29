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

namespace QuanLyRapPhim.Admin
{
    public partial class ShowTimesUC : UserControl
    {
        BindingSource showtimeList = new BindingSource();
        public ShowTimesUC()
        {
            InitializeComponent();
            LoadShowtime();
        }

        private void LoadShowtime()
        {
            dtgvShowTimes.DataSource = showtimeList;
            LoadShowtimeList();
            LoadFormatMovieIntoComboBox();
            AddShowtimeBinding();
        }

        private void AddShowtimeBinding()
        {
            txtShowTimesID.DataBindings.Add("Text", dtgvShowTimes.DataSource, "Mã lịch chiếu", true, DataSourceUpdateMode.Never);
            dtpDay.DataBindings.Add("Value", dtgvShowTimes.DataSource, "Thời gian chiếu", true, DataSourceUpdateMode.Never);
            dtpHour.DataBindings.Add("Value", dtgvShowTimes.DataSource, "Thời gian chiếu", true, DataSourceUpdateMode.Never);
            txtTicketPrice.DataBindings.Add("Text", dtgvShowTimes.DataSource, "Giá vé", true, DataSourceUpdateMode.Never);
        }
    

        private void LoadFormatMovieIntoComboBox()
        {
            cbxFormatID.DataSource = FormatMovieDAO.GetFormatMovie();
            cbxFormatID.DisplayMember = "ID";
        }

        private void LoadShowtimeList()
        {
            showtimeList.DataSource = ShowTimesDAO.GetListShowtime();
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            LoadShowtimeList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string showtimeID = txtShowTimesID.Text;
            string roomID = ((DTO.RoomCinema)cbxRoomID.SelectedItem).ID;
            string formatMovieID = ((DTO.FormatMovie)cbxFormatID.SelectedItem).ID;
            DateTime time = new DateTime(dtpDay.Value.Year, dtpDay.Value.Month, dtpDay.Value.Day, dtpHour.Value.Hour, dtpHour.Value.Minute, dtpHour.Value.Second);
            //Bind dtmShowtimeDate to "time.date" and dtmShowtimeTime to "time.time" ... TODO : Look for a better way to do this
            float ticketPrice = float.Parse(txtTicketPrice.Text);
            InsertShowtime(showtimeID, roomID, formatMovieID, time, ticketPrice);
            LoadShowtimeList();
        }

        private void InsertShowtime(string showtimeID, string roomID, string formatMovieID, DateTime time, float ticketPrice)
        {
            try
            {
                if (ShowTimesDAO.InsertShowtime(showtimeID, roomID, formatMovieID, time, ticketPrice))
                {
                    MessageBox.Show("Thêm lịch chiếu thành công");
                }
                else
                {
                    MessageBox.Show("Thêm lịch chiếu thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string showtimeID = txtShowTimesID.Text;
            string roomID = ((DTO.RoomCinema)cbxRoomID.SelectedItem).ID;
            string formatMovieID = ((DTO.FormatMovie)cbxFormatID.SelectedItem).ID;
            DateTime time = new DateTime(dtpDay.Value.Year, dtpDay.Value.Month, dtpDay.Value.Day, dtpHour.Value.Hour, dtpHour.Value.Minute, dtpHour.Value.Second);
            float ticketPrice = float.Parse(txtTicketPrice.Text);
            UpdateShowtime(showtimeID, roomID, formatMovieID, time, ticketPrice);
            LoadShowtimeList();
        }

        private void UpdateShowtime(string showtimeID, string roomID, string formatMovieID, DateTime time, float ticketPrice)
        {
            try
            {
                if (ShowTimesDAO.UpdateShowtime(showtimeID, roomID, formatMovieID, time, ticketPrice))
                {
                    MessageBox.Show("Sửa lịch chiếu thành công");
                }
                else
                {
                    MessageBox.Show("Sửa lịch chiếu thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string showtimeID = txtShowTimesID.Text;
            DeleteShowtime(showtimeID);
            LoadShowtimeList();
        }

        private void DeleteShowtime(string showtimeID)
        {
            try
            {
                if (ShowTimesDAO.DeleteShowtime(showtimeID))
                {
                    MessageBox.Show("Xóa lịch chiếu thành công");
                }
                else
                {
                    MessageBox.Show("Xóa lịch chiếu thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxFormatID_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxFormatID.SelectedIndex != -1)
            {
                FormatMovie formatMovieSelecting = (FormatMovie)cbxFormatID.SelectedItem;
                txtMovieName.Text = formatMovieSelecting.MovieName;
                txtTypeScreen.Text = formatMovieSelecting.ScreenTypeName;

                cbxRoomID.DataSource = null;
                TypeScreen screenType = TypeScreenDAO.GetTypeScreenByName(formatMovieSelecting.ScreenTypeName);
                cbxRoomID.DataSource = RoomCinemaDAO.GetRoomCinemaByScreenTypeID(screenType.ID);
                cbxRoomID.DisplayMember = "Name";
            }
        }

        private void txtShowTimesID_TextChanged(object sender, EventArgs e)
        {
            #region Change selected index of ComboBox FormatMovie
            string movieName = (string)dtgvShowTimes.SelectedCells[0].OwningRow.Cells["Tên phim"].Value;
            string screenTypeName = (string)dtgvShowTimes.SelectedCells[0].OwningRow.Cells["Màn hình"].Value;
            FormatMovie formatMovieSelecting = FormatMovieDAO.GetFormatMovieByName(movieName, screenTypeName);
            if (formatMovieSelecting == null)
                return;
            int indexFormatMovie = -1;
            for (int i = 0; i < cbxFormatID.Items.Count; i++)
            {
                FormatMovie item = cbxFormatID.Items[i] as FormatMovie;
                if (item.ID == formatMovieSelecting.ID)
                {
                    indexFormatMovie = i;
                    break;
                }
            }
            cbxFormatID.SelectedIndex = indexFormatMovie;
            #endregion
            #region Change selected index of ComboBox Cinema
            string roomID = (string)dtgvShowTimes.SelectedCells[0].OwningRow.Cells["Mã phòng"].Value;
            RoomCinema cinemaSelecting = RoomCinemaDAO.GetRoomCinemaByID(roomID);
            //This is the Cinema that we're currently selecting in dtgv

            if (cinemaSelecting == null)
                return;

            int indexRoomCinema = -1;
            int iRoomCinema = 0;
            foreach (RoomCinema item in cbxRoomID.Items)
            {
                if (item.ID == cinemaSelecting.ID)
                {
                    indexRoomCinema = iRoomCinema;
                    break;
                }
                iRoomCinema++;
            }
            cbxRoomID.SelectedIndex = indexRoomCinema;
            #endregion
            toolTipRoomCinema.SetToolTip(cbxRoomID, "Danh sách phòng chiếu hỗ trợ loại màn hình trên");
        }

        private void ptrSearch_Click(object sender, EventArgs e)
        {
            string movieName = txtSearchByMovieName.Text;
            showtimeList.DataSource = ShowTimesDAO.SearchShowtimeByMovieName(movieName);
        }
    }
}
