using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.models
{
	public class SinhVien
	{
		public string HoTen { get; set; }
		public string MaSv { get; set; }
		public string Khoa { get; set; }
		public string Lop { get; set; }
		public DateTime NgaySinh { get; set; }
		public string GioiTinh { get; set; }
		public string NoiSinh { get; set; }
		public string HoKhau { get; set; }
		public string Sdt { get; set; }
		public string Email { get; set; }
		public string Anh { get; set; }
		public string TrangThai { get; set; }
	
	
		public SinhVien()
		{

		}

		public SinhVien(
			string hoTen,
			string maSv,
			string khoa,
			string lop,
			DateTime ngaySinh,
			string gioiTinh,
			string noiSinh,
			string hoKhau,
			string sdt,
			string email,
			string anh,
			string trangThai

			

			)
		{
			HoTen = hoTen;
			MaSv = maSv;
			Khoa = khoa;
			Lop = lop;
			NgaySinh = ngaySinh;
			GioiTinh = gioiTinh;
			NoiSinh = noiSinh;
			HoKhau = hoKhau;
			Sdt = sdt;
			Email = email;
			Anh = anh;
			TrangThai = trangThai;
			
		}
		/*public SinhVien(
			string hoTen,
			string maSv,
			string khoa,
			string lop,
			DateTime ngaySinh,
			string gioiTinh,
			string noiSinh,
			string hoKhau,
			string sdt,
			string email,
			string anh,
			string trangThai
			

			)
		{
			HoTen = hoTen;
			MaSv = maSv;
			Khoa = khoa;
			Lop = lop;
			NgaySinh = ngaySinh;
			GioiTinh = gioiTinh;
			NoiSinh = noiSinh;
			HoKhau = hoKhau;
			Sdt = sdt;
			Email = email;
			Anh = anh;
			TrangThai = trangThai;
		}*/
	}
}



