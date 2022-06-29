using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class RoomCinemaDAO
    {
        public static RoomCinema GetRoomCinemaByName(string RoomCinemaName)
        {
            string query = "select * from dbo.PhongChieu where TenPhong = '" + RoomCinemaName + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return new RoomCinema(data.Rows[0]);
        }

        public static RoomCinema GetRoomCinemaByID(string id)
        {
            string query = "select * from dbo.PhongChieu where id = '" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
                return new RoomCinema(data.Rows[0]);
            return null;
        }

        public static List<RoomCinema> GetRoomCinemaByScreenTypeID(string screenTypeID)
        {
            List<RoomCinema> RoomCinemaList = new List<RoomCinema>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.PhongChieu where idManHinh ='" + screenTypeID + "'");
            foreach (DataRow item in data.Rows)
            {
                RoomCinema RoomCinema = new RoomCinema(item);
                RoomCinemaList.Add(RoomCinema);
            }
            return RoomCinemaList;
        }

        public static DataTable GetListRoomCinema()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetRoom");
        }

        public static bool InsertRoomCinema(string id, string name, string idMH, int seats, int status, int numberOfRows, int seatsPerRow)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertRoom @idRoom , @tenPhong , @idMH , @soChoNgoi , @tinhTrang , @soHangGhe , @soGheMotHang", new object[] { id, name, idMH, seats, status, numberOfRows, seatsPerRow });
            return result > 0;
        }

        public static bool UpdateRoomCinema(string id, string name, string idMH, int seats, int status, int numberOfRows, int seatsPerRow)
        {
            string command = string.Format("UPDATE dbo.PhongChieu SET TenPhong = N'{0}', idManHinh = '{1}', SoChoNgoi = {2}, TinhTrang = {3}, SoHangGhe = {4}, SoGheMotHang = {5} WHERE id = '{6}'", name, idMH, seats, status, numberOfRows, seatsPerRow, id);
            int result = DataProvider.Instance.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool DeleteRoomCinema(string id)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE dbo.LichChieu WHERE idPhong = '" + id + "'");

            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.PhongChieu WHERE id = '" + id + "'");
            return result > 0;
        }
    }
}
