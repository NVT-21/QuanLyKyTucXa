
using QuanLyKyTucXa.Database;
using QuanLyKyTucXa.db;
using QuanLyKyTucXa.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKyTucXa.AllFormChild
{
	public partial class GhiTienDienNuoc : UserControl
	{
		List<Phong> listPhong;
		public GhiTienDienNuoc()
		{
			InitializeComponent();
			dGEdit.Visible = false;
			DateTime date = DateTime.Now;
			int nam = date.Year;
			txtNam.Text = nam.ToString();
			cbThang.Items.Add(" 1 ");
			cbThang.Items.Add(" 2 ");
			cbThang.Items.Add(" 3 ");
			cbThang.Items.Add(" 4 ");
			cbThang.Items.Add(" 5 ");
			cbThang.Items.Add(" 6 ");
			cbThang.Items.Add(" 7 ");
			cbThang.Items.Add(" 8 ");
			cbThang.Items.Add(" 9 ");
			cbThang.Items.Add(" 10 ");
			cbThang.Items.Add(" 11 ");
			cbThang.Items.Add(" 12 ");


			cbKhu.Items.Add("Ký túc xá nam");
			cbKhu.Items.Add("Ký túc xá nữ");
			dataGridP.Visible = false;
			/*	dataGridP.Columns["MaPhong"].ReadOnly = true;
				dataGridP.Columns["TenPhong"].ReadOnly = true;
				dataGridP.Columns["TrangThai"].ReadOnly = true;
				dataGridP.Columns["Khu"].ReadOnly = true;
				dataGridP.Columns["LoaiPhong"].ReadOnly = true;
				dataGridP.Columns["SoNguoiToiDa"].ReadOnly = true;
				dataGridP.Columns["Gia"].ReadOnly = true;*/
			btL.Visible = false;
			btedit.Visible = false;
		}

		private void dataGridP_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void GhiTienDienNuoc_Load(object sender, EventArgs e)
		{

		}

		private void iconButton1_Click(object sender, EventArgs e)
		{
			int nam = int.Parse(txtNam.Text);
			string Thang = cbThang.SelectedItem.ToString();
			int thang = int.Parse(Thang);
			int soDien = 0;
			bool kt = true;
			int soNuoc = 0;
			foreach (DataGridViewRow row in dataGridP.Rows)
			{

				if (row.Cells["SoDien"].Value == null || row.Cells["SoNuoc"].Value == null)
				{
					kt = false;
					break;
				}
			}
			if (kt == true)
			{

				foreach (DataGridViewRow row in dataGridP.Rows)
				{


					string maPhong = row.Cells["MaPhong"].Value.ToString();
					soDien = int.Parse(row.Cells["SoDien"].Value.ToString());
					soNuoc = int.Parse(row.Cells["SoNuoc"].Value.ToString());
					string mahoadon = "MHD" + maPhong + txtNam.Text + Thang;
					if (!HoaDondb.getInstance().Kt(mahoadon))
					{

						HoaDondb.getInstance().insertHD(mahoadon, soDien, soNuoc, thang, nam, maPhong);
					}
					else
					{
						MessageBox.Show("Hóa đơn đã tồn tại");
						return;
					}


				}
				MessageBox.Show("Thêm số điện nước thành công");
			}
			else
			{
				MessageBox.Show("Bạn chưa điền đủ thông tin ");
			}

		}

		private void iconButton2_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(cbKhu.SelectedItem?.ToString()) && !string.IsNullOrEmpty(cbThang.SelectedItem?.ToString()))
			{
				string Khu = cbKhu.SelectedItem?.ToString();
				int nam = int.Parse(txtNam.Text);
				string Thang = cbThang.SelectedItem.ToString();
				DateTime date = DateTime.Now;
				int ThangHienTai = date.Month;
				int thang = int.Parse(Thang);


				List<Phong> listP = Phongdb.getInstance().SelectKhu(Khu);








				dataGridP.DataSource = listP;

				dataGridP.Visible = true;
				dGEdit.Visible = false;
				btL.Visible = true;
				btedit.Visible = false;

			}
			else
			{
				MessageBox.Show("Bạn chưa điền đủ thông tin ");
			}

		}

		private void iconButton1_Click_1(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(cbKhu.SelectedItem?.ToString()) || !string.IsNullOrEmpty(cbThang.SelectedItem?.ToString()))
			{
				string Khu = cbKhu.SelectedItem.ToString();
				int nam = int.Parse(txtNam.Text);
				string Thang = cbThang.SelectedItem.ToString();

				int thang = int.Parse(Thang);

				DataTable listHd = HoaDondb.getInstance().selectHDTheoThang(thang, nam);
				if (listHd.Rows.Count < 1)
				{
					MessageBox.Show("dữ liệu chưa được tạo ");
				}
				else
				{

					dGEdit.DataSource = listHd;

					dGEdit.Visible = true;

					dataGridP.Visible = false;
					btL.Visible = false;
					btedit.Visible = true;
				}



			}
			else
			{
				MessageBox.Show("Bạn chưa điền đủ thông tin ");
			}


		}

		private void btedit_Click(object sender, EventArgs e)
		{
            int nam = int.Parse(txtNam.Text);
            string Thang = cbThang.SelectedItem.ToString();

            int thang = int.Parse(Thang);
            foreach (DataGridViewRow row in dGEdit.Rows)
            {
                if (!row.IsNewRow) // Đảm bảo không xử lý dòng mới
                {
                    int soDien = int.Parse(row.Cells["SoDien"].Value.ToString());
                    int soNuoc = int.Parse(row.Cells["SoNuoc"].Value.ToString());
                    string maphong = row.Cells["maphong"].Value.ToString();
                    HoaDondb.getInstance().updateDC(maphong, thang, nam, soDien, soNuoc);
                }
            }

            MessageBox.Show("Cập nhật thành công");
        }

	}
}
	

