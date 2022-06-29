using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapPhim.DAO;
namespace QuanLyRapPhim.Admin
{
    public partial class StaffUC : UserControl
    {
        BindingSource staffList = new BindingSource();
        public StaffUC()
        {
            InitializeComponent();
            LoadStaff();
        }
        void LoadStaff()
        {
            dtgvStaff.DataSource = staffList;
            LoadStaffList();
            AddStaffBinding();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void LoadStaffList()
        {
            staffList.DataSource = StaffDAO.GetListStaff();
        }
        void AddStaffBinding()
        {
            txtStaffId.DataBindings.Add("Text", dtgvStaff.DataSource, "Mã nhân viên", true, DataSourceUpdateMode.Never);
            txtStaffName.DataBindings.Add("Text", dtgvStaff.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
            txtStaffBirth.DataBindings.Add("Text", dtgvStaff.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
            txtStaffAddress.DataBindings.Add("Text", dtgvStaff.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never);
            txtStaffPhone.DataBindings.Add("Text", dtgvStaff.DataSource, "SĐT", true, DataSourceUpdateMode.Never);
            txtStaffINumber.DataBindings.Add("Text", dtgvStaff.DataSource, "CMND", true, DataSourceUpdateMode.Never);

        }

        void AddStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
        {
            try
            {
                if (StaffDAO.InsertStaff(id, hoTen, ngaySinh, diaChi, sdt, cmnd))
                {
                    MessageBox.Show("Thêm nhân viên thành công");
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text;
            string staffName = txtStaffName.Text;
            DateTime staffBirth = DateTime.Parse(txtStaffBirth.Text);
            string staffAddress = txtStaffAddress.Text;
            string staffPhone = txtStaffPhone.Text;
            int staffINumber = Int32.Parse(txtStaffINumber.Text);
            AddStaff(staffId, staffName, staffBirth, staffAddress, staffPhone, staffINumber);
            LoadStaffList();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadStaffList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text;
            string staffName = txtStaffName.Text;
            DateTime staffBirth = DateTime.Parse(txtStaffBirth.Text);
            string staffAddress = txtStaffAddress.Text;
            string staffPhone = txtStaffPhone.Text;
            int staffINumber = Int32.Parse(txtStaffINumber.Text);
            UpdateStaff(staffId, staffName, staffBirth, staffAddress, staffPhone, staffINumber);
            LoadStaffList();
        }

        void UpdateStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
        {
            try
            {
                if (StaffDAO.UpdateStaff(id, hoTen, ngaySinh, diaChi, sdt, cmnd))
                {
                    MessageBox.Show("Sửa nhân viên thành công");
                }
                else
                {
                    MessageBox.Show("Sửa nhân viên thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text;
            DeleteStaff(staffId);
            LoadStaffList();
        }

        void DeleteStaff(string id)
        {
            try
            {
                if (StaffDAO.DeleteStaff(id))
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string staffName = txtSearchStaff.Text;
            DataTable staffSearchList = StaffDAO.SearchStaffByName(staffName);
            staffList.DataSource = staffSearchList;
        }
    }
}
