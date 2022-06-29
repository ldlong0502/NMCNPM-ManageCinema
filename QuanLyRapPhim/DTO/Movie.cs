using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DTO
{
    public class Movie
    {

        public Movie(string iD, string name, string desc, float time
            , DateTime starDate, DateTime endDate, string country
            , string director,string actor, int yearProduction, byte[] poster)
        {
            this.ID = iD;
            this.Name = name;
            this.Desc = desc;
            this.Time = time;
            this.StartDate = starDate;
            this.EndDate = endDate;
            this.Country = country;
            this.Director = director;
            this.Actor = actor;
            this.YearProduction = yearProduction;
            this.Poster = poster;
        }

        public Movie(DataRow row)
        {
            this.ID = row["id"].ToString();
            this.Name = row["TenPhim"].ToString();
            this.Desc = row["MoTa"].ToString();
            this.Time = float.Parse(row["ThoiLuong"].ToString());
            this.StartDate = (DateTime)row["NgayKhoiChieu"];
            this.EndDate = (DateTime)row["NgayKetThuc"];
            this.Country = row["NuocSanXuat"].ToString();
            this.Director = row["DaoDien"].ToString();
            this.Actor = row["DienVien"].ToString();
            this.YearProduction = (int)row["NamSanXuat"];
            if (row["ApPhich"].ToString() == "")
                this.Poster = null;
            else
                this.Poster = (byte[])row["ApPhich"];
        }

        public Movie()
        {
        }

        public string ID { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }

        public float Time { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Country { get; set; }

        public int YearProduction { get; set; }

        public string Director { get; set; }
        public string Actor { get; set; }

        public byte[] Poster { get; set; }
    }
}
