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
    public partial class RoomCinemaUC : UserControl
    {
        BindingSource roomList = new BindingSource();
        public RoomCinemaUC()
        {
            InitializeComponent();
            LoadRoom();
        }

        private void LoadRoom()
        {
            dtgvRoom.DataSource = roomList;
            LoadRoomList();
            AddRoomBinding();
        }

        private void AddRoomBinding()
        {
            txtRoomID.DataBindings.Add("Text", dtgvRoom.DataSource, "Mã phòng", true, DataSourceUpdateMode.Never);
            txtRoomName.DataBindings.Add("Text", dtgvRoom.DataSource, "Tên phòng", true, DataSourceUpdateMode.Never);
            txtSeat.DataBindings.Add("Text", dtgvRoom.DataSource, "Số chỗ ngồi", true, DataSourceUpdateMode.Never);
            txtStatus.DataBindings.Add("Text", dtgvRoom.DataSource, "Tình trạng", true, DataSourceUpdateMode.Never);
            txtNumRows.DataBindings.Add("Text", dtgvRoom.DataSource, "Số hàng ghế", true, DataSourceUpdateMode.Never);
            txtSeatPerRow.DataBindings.Add("Text", dtgvRoom.DataSource, "Ghế mỗi hàng", true, DataSourceUpdateMode.Never);
            LoadScreenTypeIntoComboBox(cbxScreen);
        }

        private void LoadScreenTypeIntoComboBox(ComboBox cbx)
        {
            cbx.DataSource = TypeScreenDAO.GetListTypeScreen();
            cbx.DisplayMember = "Name";
            cbx.ValueMember = "ID";
        }

        private void LoadRoomList()
        {
            roomList.DataSource = RoomCinemaDAO.GetListRoomCinema();
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            LoadRoomList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string roomID = txtRoomID.Text;
            string roomName = txtRoomName.Text;
            string screenTypeID = cbxScreen.SelectedValue.ToString();
            int roomSeats = int.Parse(txtSeat.Text);
            int roomStatus = int.Parse(txtStatus.Text);
            int numberOfRows = int.Parse(txtNumRows.Text);
            int seatsPerRows = int.Parse(txtSeatPerRow.Text);
            InsertRoom(roomID, roomName, screenTypeID, roomSeats, roomStatus, numberOfRows, seatsPerRows);
            LoadRoomList();
        }

        private void InsertRoom(string id, string name, string idMH, int seats, int status, int numberOfRows, int seatsPerRows)
        {
            try
            {
                if (RoomCinemaDAO.InsertRoomCinema(id, name, idMH, seats, status, numberOfRows, seatsPerRows))
                {
                    MessageBox.Show("Thêm phòng chiếu thành công");
                }
                else
                {
                    MessageBox.Show("Thêm phòng chiếu thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string roomID = txtRoomID.Text;
            string roomName = txtRoomName.Text;
            string screenTypeID = cbxScreen.SelectedValue.ToString();
            int roomSeats = int.Parse(txtSeat.Text);
            int roomStatus = int.Parse(txtStatus.Text);
            int numberOfRows = int.Parse(txtNumRows.Text);
            int seatsPerRows = int.Parse(txtSeatPerRow.Text);
            UpdateRoom(roomID, roomName, screenTypeID, roomSeats, roomStatus, numberOfRows, seatsPerRows);
            LoadRoomList();
        }

        private void UpdateRoom(string id, string name, string idMH, int seats, int status, int numberOfRows, int seatsPerRows)
        {
            try
            {
                if (RoomCinemaDAO.UpdateRoomCinema(id, name, idMH, seats, status, numberOfRows, seatsPerRows))
                {
                    MessageBox.Show("Sửa phòng chiếu thành công");
                }
                else
                {
                    MessageBox.Show("Sửa phòng chiếu thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string roomID = txtRoomID.Text;
            DeleteRoom(roomID);
            LoadRoomList();
        }

        private void DeleteRoom(string id)
        {

            try
            {
                if (RoomCinemaDAO.DeleteRoomCinema(id))
                {
                    MessageBox.Show("Xóa phòng chiếu thành công");
                }
                else
                {
                    MessageBox.Show("Xóa phòng chiếu thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtRoomID_TextChanged(object sender, EventArgs e)
        {
            string screenName = (string)dtgvRoom.SelectedCells[0].OwningRow.Cells["Tên màn hình"].Value;
            TypeScreen screenType = TypeScreenDAO.GetTypeScreenByName(screenName);
            //This is the ScreenType that we're currently selecting in dtgv

            cbxScreen.SelectedItem = screenType;

            int index = -1;
            int i = 0;
            foreach (TypeScreen item in cbxScreen.Items)
            {
                if (item.Name == screenType.Name)
                {
                    index = i;
                    break;
                }
                i++;
            }
            cbxScreen.SelectedIndex = index;
        }
    }
}
