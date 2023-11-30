using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.models
{
	public class Phong
	{
		public string Maphong { get; set; }
		public string TenPhong { get; set; }
		public string TrangThai { get; set; }
		public string Khu { get; set; }
		public string LoaiPhong { get; set; }
		public int SoNguoiToiDa { get; set; }
		public int Gia { get; set; }
		public Phong() { }

		public Phong(string maphong, string tenPhong, string trangThai, string khu, string loaiPhong, int soNguoiToiDa,int gia)
		{
			Maphong = maphong;
			TenPhong = tenPhong;
			TrangThai = trangThai;
			Khu = khu;
			LoaiPhong = loaiPhong;
			SoNguoiToiDa = soNguoiToiDa;
			Gia = gia;
		}
	}

}
