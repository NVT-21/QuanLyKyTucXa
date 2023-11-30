using QuanLyKyTucXa.db;
using QuanLyKyTucXa.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKyTucXa
{
	public partial class ThongTinLuuTru : Form
	{
		public ThongTinLuuTru()
		{
			InitializeComponent();
		}
		public ThongTinLuuTru(string maphong)
		{
			InitializeComponent();
			List<SinhVien> listSv = SinhViendb.getInstance().SelectSV(maphong);
			foreach (models.SinhVien sv in listSv)
			{


				PictureBox picSinhVien = new PictureBox();
				picSinhVien.Width = 220; // Điều chỉnh kích thước của PictureBox
				picSinhVien.Height = 250;
				picSinhVien.Tag = sv.MaSv;

				picSinhVien.SizeMode = PictureBoxSizeMode.Zoom;
				picSinhVien.Click += picSinhVien_Click;

				string fileAnh = sv.Anh;
				string imageFolderPath = @"D:\Learn in class\Năm 3-kì 1\C#(truc quan)\QuanLyKyTucXa\QuanLyKyTucXa\bin\image";

				// Sử dụng đường dẫn tới thư mục ảnh
				try
				{
					picSinhVien.Image = System.Drawing.Image.FromFile(Path.Combine(imageFolderPath, fileAnh));

					Label lblTenSinhVien = new Label();
					lblTenSinhVien.Text ="Họ Tên:"+ sv.HoTen;
					lblTenSinhVien.AutoSize = true;
					lblTenSinhVien.ForeColor = Color.Black;

					// Tạo Label cho mã sinh viên
					Label lblMaSinhVien = new Label();
					lblMaSinhVien.Text ="Mã :"+ sv.MaSv;
					lblMaSinhVien.AutoSize = true;
					lblMaSinhVien.ForeColor = Color.Black;

					// Thiết lập vị trí cho các Label (tùy chỉnh tọa độ cho phù hợp)
					lblTenSinhVien.Location = new Point(10, 10); // Điểm bắt đầu (X, Y) cho Label tên sinh viên.
					lblMaSinhVien.Location = new Point(10, 30); // Điểm bắt đầu (X, Y) cho Label mã sinh viên.

					// Đặt các Label vào PictureBox
					picSinhVien.Controls.Add(lblTenSinhVien);
					picSinhVien.Controls.Add(lblMaSinhVien);

					flowLayoutPanel1.Controls.Add(picSinhVien);

				
				}
				catch (Exception ex)
				{
					// Xử lý lỗi, ví dụ hiển thị thông báo hoặc thực hiện một hành động phù hợp
					MessageBox.Show("Không thể nạp ảnh. Lỗi: " + ex.Message);
				}

				
			}
			
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void ThongTinLuuTru_Load(object sender, EventArgs e)
		{

		}
		private void picSinhVien_Click(object sender, EventArgs e)
		{

			PictureBox picSinhVien = (PictureBox)sender;

			string maSv = picSinhVien.Tag.ToString();
            SinhVien sv = SinhViendb.getInstance().findStudent(maSv);
            if (sv != null)
			{
				PheDuyetHoSO pheDuyet=new PheDuyetHoSO(sv);
				pheDuyet.Show();
			}
			else
			{
				MessageBox.Show("Không tồn tại sinh viên này ");
			}
		




		
				
			
		}
	}
}
