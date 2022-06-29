using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace QuanLyRapPhim.DAO
{
    public class StaffDAO
    {
        public static Staff GetStaffByID(string id)
        {
            Staff staff = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.NhanVien WHERE id = '" + id + "'");
            foreach (DataRow item in data.Rows)
            {
                staff = new Staff(item);
                return staff;
            }
            return staff;
        }

        public static List<Staff> GetStaff()
        {
            List<Staff> staffList = new List<Staff>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.NhanVien");
            foreach (DataRow item in data.Rows)
            {
                Staff staff = new Staff(item);
                staffList.Add(staff);
            }
            return staffList;
        }

        public static DataTable GetListStaff()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetStaff");
        }

        public static bool InsertStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertStaff @idStaff , @hoTen , @ngaySinh , @diaChi , @sdt , @cmnd ", new object[] { id, hoTen, ngaySinh, diaChi, sdt, cmnd });
            return result > 0;
        }

        public static bool UpdateStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
        {
            string command = string.Format("UPDATE dbo.NhanVien SET HoTen = N'{0}', NgaySinh = '{1}', DiaChi = N'{2}', SDT = '{3}', CMND = {4} WHERE id = '{5}'", hoTen, ngaySinh, diaChi, sdt, cmnd, id);
            int result = DataProvider.Instance.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool DeleteStaff(string id)
        {
            AccountDAO.DeleteAccountByIdStaff(id);
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.NhanVien WHERE id = '" + id + "'");
            return result > 0;
        }

        public static DataTable SearchStaffByName(string name)
        {

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchStaff @hoTen", new object[] { name });
           
            return data;
            
        }
    }
}