using QuanLyKyTucXa.Database;
using QuanLyKyTucXa.db;
using QuanLyKyTucXa.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKyTucXa
{
	public partial class DangKyPhong : Form
	{
		public DangKyPhong()
		{
			InitializeComponent();
		}
		public DangKyPhong(string maphong, int width, int height)
		{
			InitializeComponent();
			this.Width = width;
			this.Height = height;
			Phong phong = Phongdb.getInstance().SelectRoombyMa(maphong);
			txtKhu.Text = phong.Khu;
			txtMaP.Text = phong.Maphong;
			txtTenP.Text = phong.TenPhong;
			txtGia.Text = phong.Gia.ToString();
			txtLP.Text = phong.LoaiPhong;
			


		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void DTns_ValueChanged(object sender, EventArgs e)
		{
			DTns.Format = DateTimePickerFormat.Custom;
			DTns.CustomFormat = "dd/MM/yyyy";
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Tất cả các tệp (*.*)|*.*|Tệp ảnh (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string selectedImagePath = openFileDialog.FileName;
				string selectedFileName = openFileDialog.FileName;
				string fileName = System.IO.Path.GetFileName(selectedFileName);
				picAnh.Tag = fileName;
				picAnh.Image = Image.FromFile(openFileDialog.FileName);

				// Làm bất kỳ xử lý nào bạn cần với tệp ảnh tại đây
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void DangKyPhong_Load(object sender, EventArgs e)
		{

		}
		public bool IsEmailValid(string email)
		{
			string pattern = @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$";
			return Regex.IsMatch(email, pattern);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{

				string hoten = txtHoTen.Text;
				string Masv = txtMSV.Text;
				string Khoa = txtKhoa.Text;
				string Lop = txtLop.Text;
				DateTime ngaysinh = DTns.Value;
				string gioiTinh = radioNam.Checked ? "Nam" : "Nữ";
				string NoiSinh = txtNS.Text;
				string HoKhau = txtKH.Text;
				string Sdt = txtSDT.Text;
				string Email = txtE.Text;
				string MaPhong = txtMaP.Text;
				string khu=txtKhu.Text;
				// Lấy đối tượng Image từ PictureBox





				if (string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(Masv) || string.IsNullOrEmpty(Khoa) ||
	string.IsNullOrEmpty(Lop) || ngaysinh == null || string.IsNullOrEmpty(NoiSinh) ||
	string.IsNullOrEmpty(HoKhau) || string.IsNullOrEmpty(Sdt) || string.IsNullOrEmpty(Email) ||
	string.IsNullOrEmpty(MaPhong))
				{
					// Một trong số các biến là null, hiển thị thông báo lỗi
					MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
				}
				else if (!IsEmailValid(Email))
				{
					MessageBox.Show("Email bạn nhập không hợp lệ ");
				}


				else
				{

                        if (SinhViendb.getInstance().gioiTinh(Masv) == 1 && khu.Equals("Ký túc xá nữ"))
                    {
                        MessageBox.Show("Sinh viên này là nam nên không thể ở ký túc xá nữ");
                    }
					 else if (!ChiTietDkydb.getInstance().findStudent(Masv))
					{
						MessageBox.Show("Sinh viên này đã đăng ký rồi ");
					}
				
                    else if (SinhViendb.getInstance().gioiTinh(Masv) == 0 && khu.Equals("Ký túc xá nam"))
                    {
                        MessageBox.Show("Sinh viên này là nữ nên không thể ở ký túc xá nam");
                    }
                    else
					{



						DateTime thoigianvao = dtNgayVao.Value;
						//luu anh
						/*if (!string.IsNullOrEmpty(tenTepAnh))
						{
							// Đường dẫn thư mục trong project để lưu ảnh
							string thuMucLuuAnh = "D:\\Learn in class\\C#(truc quan)\\QuanLyKyTucXa\\QuanLyKyTucXa\\bin\\image";

							// Đường dẫn đầy đủ đến thư mục lưu ảnh
							string duongDanThuMuc = thuMucLuuAnh;

							// Tạo thư mục nếu nó chưa tồn tại
							if (!Directory.Exists(duongDanThuMuc))
							{
								Directory.CreateDirectory(duongDanThuMuc);
							}

							// Lưu ảnh vào thư mục
							string duongDanLuuAnh = Path.Combine(duongDanThuMuc, tenTepAnh);
							picAnh.Image.Save(duongDanLuuAnh);
						}*/
						string madky = "dk" + Masv;

						ChiTietDkydb.getInstance().insertStudent(madky, Masv, MaPhong, thoigianvao);

						MessageBox.Show("Đăng ký thành công  ");


					}



				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
			}

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void iconButton1_Click(object sender, EventArgs e)
		{	string MaSv=txtMSV.Text;
			SinhVien sv = SinhViendb.getInstance().findStudent(MaSv);
			

			if (sv != null )
			{
				txtHoTen.Text = sv.HoTen;
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
			else
			{
				MessageBox.Show("Không tìm thấy sinh viên với Mã SV: " + MaSv);
			}
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			dtNgayVao.Format = DateTimePickerFormat.Custom;
			dtNgayVao.CustomFormat = "dd/MM/yyyy";
		}

		private void picAnh_Click(object sender, EventArgs e)
		{
			DangKyPhong dangkyphong = new DangKyPhong();
			dangkyphong.Show();
		}
	}
}
