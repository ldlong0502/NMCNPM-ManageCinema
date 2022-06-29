using System;
using System.Data;
using System.Linq;

namespace QuanLyRapPhim.DAO
{
    public class CustomerDAO
    {
        public static DataTable GetCustomerMember(string sdt)
        {
            string query = "Select * from KhachHang where SDT = '" + sdt + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static DataTable GetListCustomer()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetCustomer");
        }

        public static bool InsertCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertCustomer @idCus , @hoTen , @ngaySinh , @diaChi , @sdt , @cmnd ", new object[] { id, hoTen, ngaySinh, diaChi, sdt, cmnd });
            return result > 0;
        }

        public static bool UpdateCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd, int point)
        {
            string command = string.Format("UPDATE dbo.KhachHang SET HoTen = N'{0}', NgaySinh = '{1}', DiaChi = N'{2}', SDT = '{3}', CMND = {4}, DiemTichLuy = {5} WHERE id = '{6}'", hoTen, ngaySinh, diaChi, sdt, cmnd, point, id);
            int result = DataProvider.Instance.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool UpdatePointCustomer(string id, int point)
        {
            string command = string.Format("UPDATE dbo.KhachHang SET  DiemTichLuy = {0} WHERE id = '{1}'", point, id);
            int result = DataProvider.Instance.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool DeleteCustomer(string id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.KhachHang WHERE id = '" + id + "'");
            return result > 0;
        }

        public static DataTable SearchCustomerByName(string name)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_SearchCustomer @hoTen", new object[] { name });
        }
    }
}
