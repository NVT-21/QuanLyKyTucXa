using QuanLyKyTucXa.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKyTucXa.AllFormChild
{
	public partial class ThanhToanDienNuoccs : UserControl
	{
		public ThanhToanDienNuoccs()
		{
		
			InitializeComponent();
			cbKhu.Items.Add("Ký túc xá nam");
			cbKhu.Items.Add("Ký túc xá nữ");
			dataGridTT.Visible=false;
		}

		private void ThanhToanDienNuoccs_Load(object sender, EventArgs e)
		{

		}

		private void iconButton1_Click(object sender, EventArgs e)
		{
			string tenphong = "Phòng" + " " + txtTP.Text;
			string toa = cbKhu.SelectedItem?.ToString();
			if (string.IsNullOrEmpty(tenphong) || string.IsNullOrEmpty(toa))
			{
				MessageBox.Show("Bạn chưa nhập thông tin đầy đủ ");
			}
			else
			{
				
				DataTable listHD = HoaDondb.getInstance().selectDC(tenphong, toa);
				if(listHD.Rows.Count < 1)
				{
					MessageBox.Show("Không có thông tin thanh toán của phòng này ");
					return;

				}
				else {
					dataGridTT.Visible = true;
					dataGridTT.DataSource = listHD;
						}
			}
		}

		private void dataGridTT_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			DataGridViewRow selectedRow = dataGridTT.Rows[e.RowIndex];
			string mahd = selectedRow.Cells["MaHoaDon"].Value.ToString();
			if (string.IsNullOrEmpty(mahd))
			{
				MessageBox.Show("lỗi ");
				return;
			}
            string trangthai = selectedRow.Cells["TrangThai"].Value.ToString().Trim();
			if (string.IsNullOrEmpty(trangthai))
			{
				MessageBox.Show("Trạng thái thanh toán bị để trống ");
			}
            if (string.Equals(trangthai, "Đã thanh toán", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Hóa đơn này đã thanh toán");
                return;
            }





            ThanhToan thanhtoan = new ThanhToan(mahd);
			thanhtoan.Show();
		}

		private void dataGridTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{


			
		}

        private void iconButton2_Click(object sender, EventArgs e)
        {
			DataTable listHD = HoaDondb.getInstance().ChuaThanhToan();
            if (listHD.Rows.Count < 1)
            {
                MessageBox.Show("Không có phòng nào chưa thanh toán tiền  ");
                return;

            }
            else
            {
                dataGridTT.Visible = true;
                dataGridTT.DataSource = listHD;
            }
        }
    }
    }

