using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class TypeScreenDAO
    {
        public static List<TypeScreen> GetListTypeScreen()
        {
            List<TypeScreen> TypeScreenList = new List<TypeScreen>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.LoaiManHinh");
            foreach (DataRow item in data.Rows)
            {
                TypeScreen TypeScreen = new TypeScreen(item);
                TypeScreenList.Add(TypeScreen);
            }
            return TypeScreenList;
        }

        public static DataTable GetTypeScreen()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT id AS [Mã loại màn hình], TenMH as [Tên màn hình] FROM dbo.LoaiManHinh");
        }

        public static DataTable GetTypeScreenByFormatFilm(string TypeScreenID)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT *  FROM dbo.LoaiManHinh where id = '" + TypeScreenID + "'");
        }

        public static bool InsertTypeScreen(string id, string name)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertTypeScreen @idTypeScreen , @ten", new object[] { id, name });
            return result > 0;
        }

        public static bool UpdateTypeScreen(string id, string name)
        {
            string command = string.Format("UPDATE dbo.LoaiManHinh SET TenMH = N'{0}' WHERE id = '{1}'", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool DeleteTypeScreen(string id)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE dbo.PhongChieu WHERE idManHinh = '" + id + "'");
            DataProvider.Instance.ExecuteNonQuery("DELETE dbo.DinhDangPhim WHERE idLoaiManHinh = '" + id + "'");

            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.LoaiManHinh WHERE id = '" + id + "'");
            return result > 0;
        }

        public static TypeScreen GetTypeScreenByName(string screenName)
        {
            TypeScreen TypeScreen = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.LoaiManHinh WHERE TenMH = N'" + screenName + "'");
            foreach (DataRow item in data.Rows)
            {
                TypeScreen = new TypeScreen(item);
                return TypeScreen;
            }
            return TypeScreen;
        }
    }
}
