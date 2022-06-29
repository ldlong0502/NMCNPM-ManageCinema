using QuanLyRapPhim.DTO;
using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;//thư viện để mã hóa mật khẩu
using System.Text;
using QuanLyRapPhim.DAO;
namespace QuanLyRapPhim.DAO
{
    public class AccountDAO
    {
        private AccountDAO() { }

        private static string PasswordEncryption(string password)
        {
            //tính năng bảo mật cho việc đăng nhập
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);//chuyển qua mảng kiểu byte từ một chuỗi

            #pragma warning disable SYSLIB0021 // Type or member is obsolete
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            #pragma warning restore SYSLIB0021 // Type or member is obsolete


            //tạo ra bảng has(bảng băm) chứa các mảng byte
            //từ mật khẩu được mã hóa thành mảng băm

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }

            //tính năng mã hóa nâng cao bằng việc đảo ngược mật khẩu
            char[] arr = hasPass.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static int Login(string userName, string passWord)
        {
            string pass = PasswordEncryption(passWord);

            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, pass });

            if (result == null)
                return -1;
            else if (result.Rows.Count > 0)
                return 1;
            else
                return 0;

        }

        public static bool UpdatePasswordForAccount(string userName, string passWord, string newPassWord)
        {

            string oldPass = PasswordEncryption(passWord);
            string newPass = PasswordEncryption(newPassWord);

            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdatePasswordForAccount @username , @pass , @newPass", new object[] { userName, oldPass, newPass });

            return result > 0;
        }

        public static Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from TaiKhoan where userName = '" + userName + "'");

            foreach (DataRow row in data.Rows)
            {
                return new Account(row);
            }

            return null;
        }

        public static void DeleteAccountByIdStaff(string idStaff)
        {
            DataProvider.Instance.ExecuteQuery("DELETE dbo.TaiKhoan WHERE idNV = '" + idStaff + "'");
        }

        public static DataTable GetAccountList()
        {
            return DataProvider.Instance.ExecuteQuery("USP_GetAccountList");
        }

        public static bool InsertAccount(string username, int accountType, string staffID)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertAccount @username , @loaiTK , @idnv ", new object[] { username, accountType, staffID });
            return result > 0;
        }

        public static bool UpdateAccount(string username, int accountType)
        {
            string command = string.Format("USP_UpdateAccount  @username , @loaiTK", new object[] { username, accountType });
            int result = DataProvider.Instance.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool DeleteAccount(string username)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.TaiKhoan WHERE UserName = N'" + username + "'");
            return result > 0;
        }

        public static DataTable SearchAccountByStaffName(string name)
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_SearchAccount @hoten ", new object[] { name });
        }

        public static bool ResetPassword(string username)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_ResetPasswordtAccount @username", new object[] { username });
            return result > 0;
        }
    }
}
