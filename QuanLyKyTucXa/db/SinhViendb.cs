using QuanLyKyTucXa.Class;
using QuanLyKyTucXa.Database;
using QuanLyKyTucXa.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.db
{
	 class SinhViendb
	{
		DataBaseProcess db = new DataBaseProcess();
		public static SinhViendb getInstance()
		{
			return new SinhViendb();
		}
		public List<SinhVien> SelectAll()
		{
			string query = @"select * from SinhVien";
			DataTable studentDataTable = db.DataReader(query);
			List<SinhVien> listSinhVien = new List<SinhVien>();

			foreach (DataRow row in studentDataTable.Rows)
			{
				string hoTen = row["HoTen"].ToString();
				string maSv = row["MaSv"].ToString();
				string khoa = row["Khoa"].ToString();
				string lop = row["Lop"].ToString();
				DateTime ngaySinh = Convert.ToDateTime(row["NgaySinh"]);
				string gioiTinh = row["GioiTinh"].ToString();
				string noiSinh = row["NoiSinh"].ToString();
				string hoKhau = row["HoKhau"].ToString();
				string sdt = row["Sdt"].ToString();
				string email = row["Email"].ToString();
				string anh = row["Anh"].ToString();
				string trangThai = row["TrangThai"].ToString();
				string maPhong = row["MaPhong"].ToString();

				SinhVien sv = new SinhVien(hoTen, maSv, khoa, lop, ngaySinh, gioiTinh, noiSinh, hoKhau, sdt, email, anh, trangThai);

				listSinhVien.Add(sv);
			}

			return listSinhVien;

		}
		public List<SinhVien> SelectSV(string maphong)
		{
			string query = @"select *
								from sinhvien join chitietphong on sinhvien.MaSv=chitietphong.MaSv
								where MaPhong=N'" + maphong + "'";
			DataTable studentDataTable = db.DataReader(query);
			List<SinhVien> listSinhVien = new List<SinhVien>();

			foreach (DataRow row in studentDataTable.Rows)
			{
				string hoTen = row["HoTen"].ToString();
				string maSv = row["MaSv"].ToString();
				string khoa = row["Khoa"].ToString();
				string lop = row["Lop"].ToString();
				DateTime ngaySinh = Convert.ToDateTime(row["NgaySinh"]);
				string gioiTinh = row["GioiTinh"].ToString();
				string noiSinh = row["NoiSinh"].ToString();
				string hoKhau = row["HoKhau"].ToString();
				string sdt = row["Sdt"].ToString();
				string email = row["Email"].ToString();
				string anh = row["Anh"].ToString();
				string trangThai = row["TrangThai"].ToString();
				

				SinhVien sv = new SinhVien(hoTen, maSv, khoa, lop, ngaySinh, gioiTinh, noiSinh, hoKhau, sdt, email, anh, trangThai);

				listSinhVien.Add(sv);
			}

			return listSinhVien;

		}
		public void insertStudent(SinhVien sv)
		{

			string query = $@"INSERT INTO SinhVien (HoTen, MaSv, Khoa, Lop, NgaySinh, GioiTinh, NoiSinh, HoKhau, Sdt, Email, Anh, TrangThai)
                     VALUES ('N{sv.HoTen}', N'{sv.MaSv}', N'{sv.Khoa}', N'{sv.Lop}', N'{sv.NgaySinh}', N'{sv.GioiTinh}', 
                             'N{sv.NoiSinh}', N'{sv.HoKhau}', N'{sv.Sdt}', N'{sv.Email}', N'{sv.Anh}', N'{sv.TrangThai}')";

			db.DataChange(query);
		}
		public void deleteSV(string MaSv)
		{
			string query = @"DELETE FROM SinhVien WHERE MaSv = '" + MaSv + "'";
			db.DataChange(query);
		}
		public SinhVien findStudent(string ma)
		{
			string query = @"select * from SinhVien Where MaSv= '" + ma + "'";
			DataTable listphongdb = db.DataReader(query);
			if (listphongdb != null ) {
			foreach (DataRow row in listphongdb.Rows)
			{


								string hoTen = row["HoTen"].ToString();
								string maSv = row["MaSv"].ToString();
								string khoa = row["Khoa"].ToString();
								string lop = row["Lop"].ToString();
								DateTime ngaySinh = Convert.ToDateTime(row["NgaySinh"]);
								string gioiTinh = row["GioiTinh"].ToString();
								string noiSinh = row["NoiSinh"].ToString();
								string hoKhau = row["HoKhau"].ToString();
								string sdt = row["Sdt"].ToString();
								string email = row["Email"].ToString();
								string anh = row["Anh"].ToString();
								string trangThai = row["TrangThai"].ToString();
								


				SinhVien sv = new SinhVien(hoTen, maSv, khoa, lop, ngaySinh, gioiTinh, noiSinh, hoKhau, sdt, email, anh, trangThai);
								return sv;
			}
			}
			else { return null; }
			return null;
		}
		public void updateStudent(string Masv)
		{
			string sql = @"UPDATE sinhvien 
              SET trangthai = N'đã duyệt'
              WHERE MaSv = '" + Masv + "'";

			db.DataChange(sql);
		}
		public int soSv(string gioitinh)
		{
			string query = @"select gioitinh from sinhvien sv join ChiTietPhong ctp on sv.MaSv=ctp.MaSv where GioiTinh=N'"+gioitinh+"'";
			DataTable sv=db.DataReader(query);
            return sv.Rows.Count;

        }
		public int gioiTinh(string Masv)
		{
			string query = @"select gioitinh from sinhvien where MaSv=N'"+Masv+"'";
            DataTable sv = db.DataReader(query);
            if (sv != null && sv.Rows.Count > 0)
            {
                string gioiTinh = sv.Rows[0]["gioitinh"].ToString();
                if (gioiTinh.Equals("Nam"))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            return 8;
        }
		public int TongSv()
		{
            string query = @"select * from sinhvien sv join ChiTietPhong ctp on sv.MaSv=ctp.MaSv ";
            DataTable sv = db.DataReader(query);
            return sv.Rows.Count;
        }
		/*public void insertToCt(string MaSv,string MaPhong) 
		{
			try
			{
				string MaCt = "Ct" + MaSv;
				string sql = @"insert into ChiTietPhong(MaChiTietPhong, MaSV, MaPhong)
                    values('" + MaCt + "', '" + MaSv + "', '" + MaPhong + "')";
				db.DataChange(sql);
			}
			catch (Exception ex)
			{
				// Xử lý lỗi ở đây, ví dụ:
				Console.WriteLine("Lỗi xảy ra: " + ex.Message);
			}

		}*/

	}
	}

