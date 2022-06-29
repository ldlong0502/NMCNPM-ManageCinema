using QuanLyRapPhim.DAO;
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
    public partial class TypeScreenUC : UserControl
    {
        BindingSource typeScreenList = new BindingSource();
        public TypeScreenUC()
        {
            InitializeComponent();
            LoadTypeScreen();
        }

        private void LoadTypeScreen()
        {
            dtgvTypeScreen.DataSource = typeScreenList;
            LoadTypeScreenList();
            AddTypeScreenBinding();
        }

        private void LoadTypeScreenList()
        {
            typeScreenList.DataSource = TypeScreenDAO.GetTypeScreen();
        }

        private void AddTypeScreenBinding()
        {
            txtTypeScreenID.DataBindings.Add("Text", dtgvTypeScreen.DataSource, "Mã loại màn hình", true, DataSourceUpdateMode.Never);
            txtTypeScreenName.DataBindings.Add("Text", dtgvTypeScreen.DataSource, "Tên màn hình", true, DataSourceUpdateMode.Never);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            LoadTypeScreenList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string typeScreenID = txtTypeScreenID.Text;
            string typeScreenName = txtTypeScreenName.Text;
            InsertTypeScreen(typeScreenID, typeScreenName);
            LoadTypeScreenList();
        }

        private void InsertTypeScreen(string id, string name)
        {
            try
            {
                if (TypeScreenDAO.InsertTypeScreen(id, name))
                {
                    MessageBox.Show("Thêm loại màn hình thành công");
                }
                else
                {
                    MessageBox.Show("Thêm loại màn hình thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void dtgvTypeScreen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string typeScreenID = txtTypeScreenID.Text;
            string typeScreenName = txtTypeScreenName.Text;
            UpdateTypeScreen(typeScreenID, typeScreenName);
            LoadTypeScreenList();
        }

        private void UpdateTypeScreen(string id, string name)
        {
            try
            {

                if (TypeScreenDAO.UpdateTypeScreen(id, name))
                {
                    MessageBox.Show("Sửa loại màn hình thành công");
                }
                else
                {
                    MessageBox.Show("Sửa loại màn hình thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string typeScreenID = txtTypeScreenID.Text;
            DeleteTypeScreen(typeScreenID);
            LoadTypeScreenList();
        }

        private void DeleteTypeScreen(string id)
        {
            try
            {
                if (TypeScreenDAO.DeleteTypeScreen(id))
                {
                    MessageBox.Show("Xóa loại màn hình thành công");
                }
                else
                {
                    MessageBox.Show("Xóa loại màn hình thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
    }
}
