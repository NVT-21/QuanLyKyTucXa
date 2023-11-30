using QuanLyKyTucXa.Class;
using QuanLyKyTucXa.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKyTucXa.db
{
	class ChiTietDkydb
	{
		DataBaseProcess db = new DataBaseProcess();
		public static ChiTietDkydb getInstance()
		{
			return new ChiTietDkydb();
		}
		public void insertStudent(string MaDky,string MaSv,string MaPhong,DateTime NgayDuKienVao)
		{	

			string query = $@"insert into ChiTietPhong(MaChiTietPhong,MaSV,MaPhong,NgayDuKienVao)
							values (N'{MaDky}',N'{MaSv}',N'{MaPhong}',N'{NgayDuKienVao}')";

			db.DataChange(query);
		}
		public bool findStudent(string ma)
		{
			string query = $@"select * from ChiTietPhong 
							where Masv=N'{ma}'";
			DataTable sv=db.DataReader(query);

			if(sv.Rows.Count==0)
			{
				return true;
			}
			return false;

		}
		public DataTable informartion(string MaSv)
		{
			string query = @"select sv.MaSv,sv.HoTen,sv.Khoa,sv.Lop,sv.NgaySinh,Phong.TenPhong,ChiTietPhong.NgayDuKienVao
							from ChiTietPhong 
							join Phong on ChiTietPhong.MaPhong=Phong.MaPhong
							join SinhVien sv on sv.MaSv=ChiTietPhong.MaSv
							where sv.MaSv=N'" + MaSv + "'";
			DataTable sv=db.DataReader(query);
			return sv;
		}
		public void deleteSv(string Masv)
		{
			string query = @"DELETE FROM ChiTietPhong WHERE MaSv = '" + Masv + "'";
			db.DataChange(query);
		}
		public void chuyenphong(string Masv,string maphong)
		{
			string query = @"update ChiTietPhong
							Set MaPhong=N'" + maphong + "'where MaSv=N'" + Masv + "' ";
            db.DataChange(query);

        }
	}
}
