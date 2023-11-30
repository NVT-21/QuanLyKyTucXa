using QuanLyKyTucXa.AllFormChild;
using QuanLyKyTucXa.Class;
using QuanLyKyTucXa.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.db
{
	class HoaDondb
	{
		DataBaseProcess db = new DataBaseProcess();
		public static HoaDondb getInstance()
		{
			return new HoaDondb();
		}
		public void insertHD(string Mahd, int sodien, int sonuoc, int thang, int nam, string maphong)
		{


			string query = $@"INSERT INTO sotiendien (MaHoaDon, SoDien, SoNuoc, Thang, Nam, MaPhong)
								VALUES (N'{Mahd}', {sodien}, {sonuoc}, {thang}, {nam}, N'{maphong}' )";

			db.DataChange(query);

		}
        public void updateHD(string maHD)
        {
            string query = $@"UPDATE sotiendien
							SET TrangThai = N'Đã thanh toán'
							WHERE MaHoaDon = N'" + maHD + "' ";

            db.DataChange(query);

        }

        public bool Kt(string mahd)
		{
			string sql = @"select *
               from sotiendien where MaHoaDon=N'" + mahd + "'";

			DataTable hdTable = db.DataReader(sql);
			if (hdTable.Rows.Count > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public DataTable selectDC(string tenphong, string Khu)
		{
			string query = @"select std.MaHoaDon, p.TenPhong,p.Khu,p.tang,std.Thang,std.Nam,(4000*std.SoDien) as tiendien,(30000*std.SoNuoc) as tiennuoc,std.TrangThai
							from sotiendien std join Phong p on std.MaPhong=p.MaPhong
							where p.tenphong=N'" + tenphong + "' and p.Khu=N'" + Khu + "' ";
			DataTable listHD = db.DataReader(query);
			return listHD;

		}
		public DataTable selectHDTheoThang(int thang,int nam)
		{
			string query = @"select p.Maphong, p.TenPhong,p.Khu,p.tang,p.Loaiphong,std.Thang,std.Nam,std.SoDien,std.SoNuoc
			from Phong p  join sotiendien std on p.MaPhong=std.MaPhong where thang=" + thang+" and nam="+nam+"";
            DataTable hdDataTable = db.DataReader(query);


			return hdDataTable;
        }

		public void updateDC(string maphong, int thang, int nam, int sodien, int sonuoc)
		{
			string query = @" UPDATE SoTienDien SET SoDien ="+sodien+" ,SoNuoc= "+sonuoc+ "  from sotiendien WHERE MaPhong = '" + maphong+"' and thang=" + thang+" and nam="+nam+"";
			db.DataChange(query);
		}
		public DataTable ChuaThanhToan()
		{
			string query = @"select std.MaHoaDon, p.TenPhong,p.Khu,p.tang,std.Thang,std.Nam,(4000*std.SoDien) as tiendien,(30000*std.SoNuoc) as tiennuoc,std.TrangThai from sotiendien std join Phong p on std.MaPhong=p.MaPhong where std.trangthai=N'Chưa thanh toán'";
							
            DataTable listHD = db.DataReader(query);
            return listHD;

        }
		public HoaDon SelectByMa(string maHd)
		{
			string query = @"select top 1 std.MaHoaDon,p.MaPhong,p.TenPhong,std.Thang,std.Nam,std.SoDien,std.SoNuoc,std.TrangThai,(4000*std.SoDien) as tiendien,(30000*std.SoNuoc) as tiennuoc
							from sotiendien std join Phong p on std.MaPhong=p.MaPhong
							where std.MaHoaDon=N'" + maHd + "' ";



			DataTable hdDataTable = db.DataReader(query);
			if (hdDataTable != null)
			{
				foreach (DataRow row in hdDataTable.Rows)
				{

					string MaHoaDon = row["MaHoaDon"].ToString();
					string tenphong = row["tenphong"].ToString();
					
					string thang = row["Thang"].ToString();
					int thangAsInt = int.Parse(thang);

					string nam = row["Nam"].ToString();
					int namAsInt = int.Parse(nam);

					string tiendien = row["tiendien"].ToString();
					int tiendienAsInt = int.Parse(tiendien);

					string tiennuoc = row["tiennuoc"].ToString();
					int tiennuocAsInt = int.Parse(tiennuoc);
					string trangthai = row["trangthai"].ToString();


					HoaDon hd = new HoaDon(MaHoaDon, tiendienAsInt, tiennuocAsInt, thangAsInt, namAsInt, trangthai, tenphong);
					return hd;
				}



			}
			return null;
		}
	}
}
