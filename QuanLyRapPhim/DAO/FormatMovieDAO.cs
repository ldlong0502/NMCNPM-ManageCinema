﻿using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class FormatMovieDAO
    {
        public static List<FormatMovie> GetListFormatMovieByMovie(string movieID)
        {
            List<FormatMovie> listFormat = new List<FormatMovie>();
            string query = "select d.id, p.TenPhim, m.TenMH " +
                "from Phim p, DinhDangPhim d, LoaiManHinh m " +
                "where p.id = d.idPhim and d.idLoaiManHinh = m.id "
                + "and p.id = '" + movieID + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                FormatMovie format = new FormatMovie(row);
                listFormat.Add(format);
            }
            return listFormat;
        }

        public static DataTable GetFormatMovieByID(string movieID, string screenTypeID)
        {
            string query = "select d.id, p.TenPhim, m.TenMH " +
                "from Phim p, DinhDangPhim d, LoaiManHinh m " +
                "where p.id = d.idPhim and d.idLoaiManHinh = m.id "
                + "and p.id = '" + movieID + "' and m.id = '" + screenTypeID + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public static FormatMovie GetFormatMovieByName(string movieName, string screenTypeName)
        {
            string command = "SELECT DD.id, P.TenPhim, MH.TenMH " +
                                "FROM dbo.DinhDangPhim DD, dbo.Phim P, dbo.LoaiManHinh MH " +
                                "WHERE DD.idPhim = P.id AND DD.idLoaiManHinh = MH.id AND P.TenPhim = N'" + movieName + "' AND MH.TENMH = N'" + screenTypeName + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(command);
            return new FormatMovie(data.Rows[0]);
        }

        public static List<FormatMovie> GetFormatMovie()
        {
            List<FormatMovie> formatMovieList = new List<FormatMovie>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT DD.id, P.TenPhim, MH.TenMH " +
                                                        "FROM dbo.DinhDangPhim DD, dbo.Phim P, dbo.LoaiManHinh MH " +
                                                        "WHERE DD.idPhim = P.id AND DD.idLoaiManHinh = MH.id");
            foreach (DataRow item in data.Rows)
            {
                FormatMovie formatMovie = new FormatMovie(item);
                formatMovieList.Add(formatMovie);
            }
            return formatMovieList;
        }

        public static DataTable GetListFormatMovie()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetListFormatMovie");
        }

        public static bool InsertFormatMovie(string id, string idMovie, string idScreen)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertFormatMovie @id , @idPhim , @idLoaiManHinh ", new object[] { id, idMovie, idScreen });
            return result > 0;
        }

        public static bool UpdateFormatMovie(string id, string idMovie, string idScreen)
        {
            string command = string.Format("UPDATE dbo.DinhDangPhim SET idPhim = '{0}', idLoaiManHinh = '{1}' WHERE id = '{2}'", idMovie, idScreen, id);
            int result = DataProvider.Instance.ExecuteNonQuery(command);
            return result > 0;
        }

        public static bool DeleteFormatMovie(string id)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE dbo.LichChieu WHERE idDinhDang = '" + id + "'");

            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.DinhDangPhim WHERE id = '" + id + "'");
            return result > 0;
        }
    } 
}
