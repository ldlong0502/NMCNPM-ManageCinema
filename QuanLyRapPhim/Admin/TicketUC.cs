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
    public partial class TicketUC : UserControl
    {
        public TicketUC()
        {
            InitializeComponent();
            LoadAllListShowTimes();
        }

        private void LoadAllListShowTimes()
        {
            lsvAllListShowTimes.Items.Clear();

            List<ShowTimes> allListShowTime = ShowTimesDAO.GetAllListShowTimes();
            foreach (ShowTimes showTimes in allListShowTime)
            {
                ListViewItem lvi = new ListViewItem(showTimes.CinemaName);
                lvi.SubItems.Add(showTimes.MovieName);
                lvi.SubItems.Add(showTimes.Time.ToString("HH:mm:ss dd/MM/yyyy"));
                lvi.Tag = showTimes;

                if (showTimes.Status == 1)
                {
                    lvi.SubItems.Add("Đã tạo");
                }
                else
                {
                    lvi.SubItems.Add("Chưa Tạo");
                }
                lsvAllListShowTimes.Items.Add(lvi);
            }
        }

        private void btnAutoAddTicketByShowTimes_Click(object sender, EventArgs e)
        {
            if (lsvAllListShowTimes.SelectedItems.Count > 0)
            {
                ShowTimes showTimes = lsvAllListShowTimes.SelectedItems[0].Tag as ShowTimes;
                if (showTimes.Status == 1)
                {
                    MessageBox.Show("LỊCH CHIẾU NÀY ĐÃ ĐƯỢC TẠO VÉ", "THÔNG BÁO");
                    return;
                }
                AutoCreateTicketsByShowTimes(showTimes);
                LoadAllListShowTimes();
                LoadTicketsByShowTimes(showTimes.ID);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ TẠO", "THÔNG BÁO");
            }
        }

        private void LoadTicketsByShowTimes(string id)
        {
            List<Ticket> listTicket = TicketDAO.GetListTicketsByShowTimes(id);
            dtgvTicket.DataSource = listTicket;
        }

        private void AutoCreateTicketsByShowTimes(ShowTimes showTimes)
        {
            int result = 0;
            RoomCinema cinema = RoomCinemaDAO.GetRoomCinemaByName(showTimes.CinemaName);
            int Row = cinema.Row;
            int Column = cinema.SeatInRow;
            for (int i = 0; i < Row; i++)
            {
                int temp = i + 65;
                char nameRow = (char)(temp);
                for (int j = 1; j <= Column; j++)
                {
                    string seatName = nameRow.ToString() + j;
                    result += TicketDAO.InsertTicketByShowTimes(showTimes.ID, seatName);
                }
            }
            if (result == Row * Column)
            {
                int ret = ShowTimesDAO.UpdateStatusShowTimes(showTimes.ID, 1);
                if (ret > 0)
                    MessageBox.Show("TẠO VÉ TỰ ĐỘNG THÀNH CÔNG", "THÔNG BÁO");
            }
            else
                MessageBox.Show("TẠO VÉ TỰ ĐỘNG THẤT BẠI", "THÔNG BÁO");
        }

        private void lsvAllListShowTimes_Click(object sender, EventArgs e)
        {
            if (lsvAllListShowTimes.SelectedItems.Count > 0)
            {
                ShowTimes showTimes = lsvAllListShowTimes.SelectedItems[0].Tag as ShowTimes;
                LoadTicketsByShowTimes(showTimes.ID);
            }
        }

        private void btnDeleteTicketByShowTimes_Click(object sender, EventArgs e)
        {
            if (lsvAllListShowTimes.SelectedItems.Count > 0)
            {
                ShowTimes showTimes = lsvAllListShowTimes.SelectedItems[0].Tag as ShowTimes;
                if (showTimes.Status == 0)
                {
                    MessageBox.Show("LỊCH CHIẾU NÀY CHƯA ĐƯỢC TẠO VÉKHÔNG THỂ XÓA", "THÔNG BÁO");
                    return;
                }
                DeleteTicketsByShowTimes(showTimes);
                LoadAllListShowTimes();
                LoadTicketsByShowTimes(showTimes.ID);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ TẠO", "THÔNG BÁO");
            }
        }

        private void DeleteTicketsByShowTimes(ShowTimes showTimes)
        {
            RoomCinema cinema = RoomCinemaDAO.GetRoomCinemaByName(showTimes.CinemaName);
            int Row = cinema.Row;
            int Column = cinema.SeatInRow;
            int result = TicketDAO.DeleteTicketsByShowTimes(showTimes.ID);
            if (result == Row * Column)
            {
                int ret = ShowTimesDAO.UpdateStatusShowTimes(showTimes.ID, 0);
                if (ret > 0)
                    MessageBox.Show("XÓA TẤT CẢ CÁC VÉ CỦA LỊCH CHIẾU ID=" + showTimes.ID + " THÀNH CÔNG", "THÔNG BÁO");
            }
            else
                MessageBox.Show("XÓA TẤT CẢ CÁC VÉ CỦA LỊCH CHIẾU ID=" + showTimes.ID + " THẤT BẠI", "THÔNG BÁO");
        }

        private void btnSeeTicketSelledByShowTimes_Click(object sender, EventArgs e)
        {
            if (lsvAllListShowTimes.SelectedItems.Count > 0)
            {
                ShowTimes showTimes = lsvAllListShowTimes.SelectedItems[0].Tag as ShowTimes;
                LoadTicketsBoughtByShowTimes(showTimes.ID);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ XEM", "THÔNG BÁO");
            }
        }

        private void LoadTicketsBoughtByShowTimes(string showTimesID)
        {
            List<Ticket> listTicket = TicketDAO.GetListTicketsBoughtByShowTimes(showTimesID);
            dtgvTicket.DataSource = listTicket;
        }

        private void btnSeeAllTicketByShowTimes_Click(object sender, EventArgs e)
        {
            if (lsvAllListShowTimes.SelectedItems.Count > 0)
            {
                ShowTimes showTimes = lsvAllListShowTimes.SelectedItems[0].Tag as ShowTimes;
                LoadTicketsByShowTimes(showTimes.ID);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ XEM", "THÔNG BÁO");
            }
        }

        private void btnSeeShowTimesNotCreatedTicket_Click(object sender, EventArgs e)
        {
            LoadListShowTimesNotCreateTickets();
        }

        private void LoadListShowTimesNotCreateTickets()
        {
            lsvAllListShowTimes.Items.Clear();

            List<ShowTimes> allListShowTime = ShowTimesDAO.GetListShowTimesNotCreateTickets();
            foreach (ShowTimes showTimes in allListShowTime)
            {
                ListViewItem lvi = new ListViewItem(showTimes.CinemaName);
                if (showTimes.Status == 1)
                {
                    return;
                }
                lvi.SubItems.Add(showTimes.MovieName);
                lvi.SubItems.Add(showTimes.Time.ToString("HH:mm:ss dd/MM/yyyy"));
                lvi.Tag = showTimes;
                lvi.SubItems.Add("Chưa Tạo");
                lsvAllListShowTimes.Items.Add(lvi);
            }
        }

        private void btnSeeAllShowTimes_Click(object sender, EventArgs e)
        {
            LoadAllListShowTimes();
        }
    }
    
}
