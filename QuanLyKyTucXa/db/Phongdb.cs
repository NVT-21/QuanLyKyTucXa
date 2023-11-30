using QuanLyKyTucXa.Class;
using QuanLyKyTucXa.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLyKyTucXa.Database
{
	 class Phongdb
	{
		DataBaseProcess db = new DataBaseProcess();
		public static Phongdb getInstance()
		{
			return new Phongdb();
		}
		public List<Phong> SelectAll()
		{ 
		string query= @"select * from Phong";
		DataTable listphongdb=db.DataReader(query);
			List<Phong>listphong=new List<Phong>();
			foreach (DataRow row in listphongdb.Rows)
			{


				string Maphong = row["Maphong"].ToString();
				string TenPhong = row["TenPhong"].ToString();
				string TrangThai = row["TrangThai"].ToString();
				string Khu = row["Khu"].ToString();
				string LoaiPhong = row["LoaiPhong"].ToString();
				int SoNguoiToiDa = Convert.ToInt32(row["SoNguoiToiDa"]);
				int Gia = Convert.ToInt32(row["GiaTien"]);

				Phong p = new Phong(Maphong, TenPhong, TrangThai, Khu, LoaiPhong, SoNguoiToiDa,Gia);

				listphong.Add(p);
			}

			return listphong;
		}
		public List<Phong> SelectByFloor (string floor,string khu)
		{
			string query = @"select * from Phong Where tang= N'"+floor+ "'and Khu=N'"+khu+"'";
			DataTable listphongdb = db.DataReader(query);
			List<Phong> listphong = new List<Phong>();
			foreach (DataRow row in listphongdb.Rows)
			{


				string Maphong = row["Maphong"].ToString();
				string TenPhong = row["TenPhong"].ToString();
				string TrangThai = row["TrangThai"].ToString();
				string Khu = row["Khu"].ToString();
				string LoaiPhong = row["LoaiPhong"].ToString();
				int SoNguoiToiDa = Convert.ToInt32(row["SoNguoiToiDa"]);
				int Gia = Convert.ToInt32(row["GiaTien"]);

				Phong p = new Phong(Maphong, TenPhong, TrangThai, Khu, LoaiPhong, SoNguoiToiDa,Gia);

				listphong.Add(p);
			}

			return listphong;
		}
		public List<Phong> SelectKhu( string Khu)
		{
			string query = @"select * from Phong Where  Khu=N'" + Khu + "'";
			DataTable listphongdb = db.DataReader(query);
			List<Phong> listphong = new List<Phong>();
			foreach (DataRow row in listphongdb.Rows)
			{


				string Maphong = row["Maphong"].ToString();
				string TenPhong = row["TenPhong"].ToString();
				string TrangThai = row["TrangThai"].ToString();
				string khu = row["Khu"].ToString();
				string LoaiPhong = row["LoaiPhong"].ToString();
				int SoNguoiToiDa = Convert.ToInt32(row["SoNguoiToiDa"]);
				int Gia = Convert.ToInt32(row["GiaTien"]);

				Phong p = new Phong(Maphong, TenPhong, TrangThai, khu, LoaiPhong, SoNguoiToiDa, Gia);

				listphong.Add(p);
			}

			return listphong;
		}
		public Phong SelectRoombyMa(string maphong)
		{
			string query = @"select * from Phong Where maphong= '" + maphong + "'";
			DataTable listphongdb = db.DataReader(query);
			foreach (DataRow row in listphongdb.Rows)
			{


				string Maphong = row["Maphong"].ToString();
				string TenPhong = row["TenPhong"].ToString();
				string TrangThai = row["TrangThai"].ToString();
				string Khu = row["Khu"].ToString();
				string LoaiPhong = row["LoaiPhong"].ToString();
				int SoNguoiToiDa = Convert.ToInt32(row["SoNguoiToiDa"]);
				int Gia = Convert.ToInt32(row["GiaTien"]);

				Phong p = new Phong(Maphong, TenPhong, TrangThai, Khu, LoaiPhong, SoNguoiToiDa,Gia);
				return p;
			}
			return null;
		}
		public int CountNumberStudent(string maphong)
		{ int count = 0;
			string query = @"SELECT COUNT(*)
                FROM ChiTietPhong
                JOIN Phong ON ChiTietPhong.MaPhong = Phong.MaPhong
				join SinhVien sv on sv.MaSv=ChiTietPhong.MaSv
                WHERE Phong.MaPhong =  '" + maphong + "'  GROUP BY Phong.MaPhong";
			DataTable SlSV=db.DataReader(query);
			if (SlSV.Rows.Count > 0)
			{
				count = Convert.ToInt32(SlSV.Rows[0][0]);
			}

			return count;

		}
		public void updateState(string MaPhong,string trangthai)
		{
			string sql =@"update Phong set trangthai=N'" + trangthai + "'where MaPhong=  '" + MaPhong + "'" ;
			db.DataChange(sql);

		}
	}
}
