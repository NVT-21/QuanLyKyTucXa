using QuanLyKyTucXa.Database;
using QuanLyKyTucXa.db;
using QuanLyKyTucXa.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using QuanLyKyTucXa.AllFormChild;

namespace QuanLyKyTucXa
{
	public partial class PheDuyetHoSO : Form
	{
		public PheDuyetHoSO()
		{
			InitializeComponent();
		}
		public PheDuyetHoSO(SinhVien sv)
		{
			InitializeComponent();
			

			
				txtHo.Text = sv.HoTen;
				txtMSV.Text = sv.MaSv;
				txtLop.Text = sv.Lop;
				txtKH.Text = sv.HoKhau;
				if (sv.GioiTinh == "Nam")
				{
					radioNam.Checked = true;
					radioNu.Checked = false;
				}
				else if (sv.GioiTinh == "Nữ")
				{
					radioNam.Checked = false;
					radioNu.Checked = true;
				}
				else
				{
					// Xử lý trường hợp khác nếu cần
					radioNam.Checked = false;
					radioNu.Checked = false;
				}
				txtKhoa.Text = sv.Khoa;
				DTns.Value = sv.NgaySinh;
				txtNS.Text = sv.NoiSinh;
				txtSDT.Text = sv.Sdt;
				txtE.Text = sv.Email;
				string fileAnh = sv.Anh;
				string imageFolderPath = @"D:\Learn in class\Năm 3-kì 1\C#(truc quan)\QuanLyKyTucXa\QuanLyKyTucXa\bin\image";

				// Sử dụng đường dẫn tới thư mục ảnh
				try
				{
					picAnh.Image = System.Drawing.Image.FromFile(Path.Combine(imageFolderPath, fileAnh));
				}
				catch (Exception ex)
				{
					// Xử lý lỗi, ví dụ hiển thị thông báo hoặc thực hiện một hành động phù hợp
					MessageBox.Show("Không thể nạp ảnh. Lỗi: " + ex.Message);
				}
				
				
			
		
			
		}

		private void PheDuyetHoSO_Load(object sender, EventArgs e)
		{

		}

		private void DTns_ValueChanged(object sender, EventArgs e)
		{
			DTns.Format = DateTimePickerFormat.Custom;
			DTns.CustomFormat = "dd/MM/yyyy";
		}

		private void button3_Click(object sender, EventArgs e)
		{	
			string masv=txtMSV.Text;	
			SinhViendb.getInstance().updateStudent(masv);
			MessageBox.Show("Bạn đã phê duyệt thành công ");
			



		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void iconButton1_Click(object sender, EventArgs e)
		{
			string Masv=txtMSV.Text;
			if (Masv != null)
			{
				ChiTietDkydb.getInstance().deleteSv(Masv);
				MessageBox.Show("Bạn đã xóa sinh viên ra khỏi phòng thành công ! ");
			}
		}

        private void picAnh_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
			string Masv=txtMSV.Text;
            string GioiTinh = radioNam.Checked ? "Nam" : "Nữ";
            string HoTen=txtHo.Text;
			ChuyenPhong cp=new ChuyenPhong(Masv,HoTen,GioiTinh);
			cp.Show();
			this.Close();

        }
    }
}
