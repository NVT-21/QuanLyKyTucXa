using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKyTucXa.models
{
	public class ChiTietDky
	{
		public string MaDky { get; set; }
		public string MaSv { get; set; }
		public string MaPhong { get; set; }
		public DateTime ThoiGianTao { get; set; }
		public DateTime NgayDuKienVao { get; set; }

		public ChiTietDky(string maDky, string maSv, string maPhong, DateTime thoiGianTao,DateTime ngayDuKienVao
			)
		{
			MaDky = maDky;
			MaSv = maSv;
			MaPhong = maPhong;
			ThoiGianTao = thoiGianTao;
			NgayDuKienVao = ngayDuKienVao;
		}
	}

}
