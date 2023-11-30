using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.models
{
	public class HoaDon
	{
		public string MaHoaDon { get; set; }
		public int SoDien { get; set; }
		public int SoNuoc { get; set; }
		public int Thang { get; set; }
		public int Nam { get; set; }
		public string TrangThai { get; set; }
		public string tenPhong { get; set; }
       

		public HoaDon(int soDien,int soNuoc) {
			SoDien= soDien;
			SoNuoc = soNuoc;

		}
        public HoaDon(string maHoaDon, int soDien, int soNuoc, int thang, int nam, string trangThai, string tenphong)
		{
			MaHoaDon = maHoaDon;
			SoDien = soDien;
			SoNuoc = soNuoc;
			Thang = thang;
			Nam = nam;
			TrangThai = trangThai;
			tenPhong = tenphong;
		}
	}

}
