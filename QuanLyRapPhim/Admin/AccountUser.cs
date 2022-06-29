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
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.Admin
{
    public partial class AccountUser : UserControl
    {
        BindingSource accountList = new BindingSource();
        public AccountUser()
        {
            InitializeComponent();
            LoadAccount();
        }
        void LoadAccount()
        {
            dtgvAccount.DataSource = accountList;
            LoadAccountList();
            AddAccountBinding();
        }
        void LoadAccountList()
        {
            accountList.DataSource = AccountDAO.GetAccountList();
        }
        void AddAccountBinding()
        {
            txtUsername.DataBindings.Add("Text", dtgvAccount.DataSource, "Username", true, DataSourceUpdateMode.Never);
            nudAccountType.DataBindings.Add("Value", dtgvAccount.DataSource, "Loại tài khoản", true, DataSourceUpdateMode.Never);
            LoadStaffIntoComboBox(cboStaffID_Account);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }

        void LoadStaffIntoComboBox(ComboBox cbo)
        {
            cbo.DataSource = StaffDAO.GetStaff();
            cbo.DisplayMember = "ID";
            cbo.ValueMember = "ID";
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string staffID = (string)dtgvAccount.SelectedCells[0].OwningRow.Cells["Mã nhân viên"].Value;
            Staff staff = StaffDAO.GetStaffByID(staffID);//The staff that we're currently selecting

            if (staff == null)
                //The case that nothing on dtgv - no result after searched
                return;

            cboStaffID_Account.SelectedItem = staff;

            int index = -1;
            int i = 0;
            foreach (Staff item in cboStaffID_Account.Items)
            {
                if (item.ID == staff.ID)
                {
                    index = i;
                    break;
                }
                i++;
            }
            cboStaffID_Account.SelectedIndex = index;
        }

        private void cboStaffID_Account_SelectedIndexChanged(object sender, EventArgs e)
        {
            Staff staff = cboStaffID_Account.SelectedItem as Staff;
            if (staff == null)
                return;
            txtStaffName_Account.Text = staff.Name;
        }

        void InsertAccount(string username, int accountType, string idStaff)
        {
            try
            {
                if (AccountDAO.InsertAccount(username, accountType, idStaff))
                {
                    MessageBox.Show("Thêm tài khoản thành công, mật khẩu mặc định : 1");
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            int accountType = (int)nudAccountType.Value;
            string staffID = cboStaffID_Account.SelectedValue.ToString();
            InsertAccount(username, accountType, staffID);
            LoadAccountList();
        }

        void UpdateAccount(string username, int accountType)
        {
            try
            {
                if (AccountDAO.UpdateAccount(username, accountType))
                {
                    MessageBox.Show("Sửa tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Sửa tài khoản thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            int accountType = (int)nudAccountType.Value;
            UpdateAccount(username, accountType);
            LoadAccountList();
        }

        void DeleteAccount(string username)
        {
            try
            {
                if (AccountDAO.DeleteAccount(username))
                {
                    MessageBox.Show("Xóa tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            DeleteAccount(username);
            LoadAccountList();
        }

        void ResetPassword(string username)
        {
            try
            {
                if (AccountDAO.ResetPassword(username))
                {
                    MessageBox.Show("Reset mật khẩu thành công, mật khẩu mặc định : 1");
                }
                else
                {
                    MessageBox.Show("Reset mật khẩu thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }          
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            ResetPassword(username);
            LoadAccountList();
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {

            string staffName = txtSearchAccount.Text;
            accountList.DataSource = AccountDAO.SearchAccountByStaffName(staffName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePassForm passForm = new ChangePassForm();
            passForm.ShowDialog();
        }
    }
}
