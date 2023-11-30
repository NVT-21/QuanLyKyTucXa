using QuanLyKyTucXa.Database;
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
	public partial class QuanLyLuuTru : UserControl
	{
		public QuanLyLuuTru()
		{
			InitializeComponent();
			cbTang.Items.Add("Tầng 1 ");
			cbTang.Items.Add("Tầng 2 ");
			cbTang.Items.Add("Tầng 3 ");
			cbTang.Items.Add("Tầng 4 ");
			cbTang.Items.Add("Tầng 5 ");
			cbTang.Items.Add("Tầng 6 ");
			cbKhu.Items.Add("Ký túc xá nam");
			cbKhu.Items.Add("Ký túc xá nữ ");
		}
		private void RenderRoomsbyfloor(string floor,string Khu)
		{

			List<models.Phong> listphong = Phongdb.getInstance().SelectByFloor(floor,Khu);
			int SLSV = 0;


			if (listphong.Count == 0)
			{
				MessageBox.Show("Không có phòng nào ở tầng này ");
			}
			foreach (models.Phong room in listphong)
			{
				Button roomButton = new Button();
				roomButton.Height = 260;
				roomButton.Tag = room.Maphong;
				roomButton.Text = room.TenPhong;
				roomButton.ForeColor = Color.White;
				roomButton.Width = 240;
				switch (room.TrangThai)
				{
					case "còn trống":
						roomButton.BackColor = Color.Green;
						break;
					case "đang sửa":
						roomButton.BackColor = Color.Gray;
						roomButton.Enabled = false;
						break;
					case "đầy":
						roomButton.BackColor = Color.Red;
						
						break;
					default: roomButton.BackColor = Color.Wheat; roomButton.Enabled = false; break;
				}
				SLSV = Phongdb.getInstance().CountNumberStudent(room.Maphong);
				if (SLSV >= room.SoNguoiToiDa)
				{
					roomButton.BackColor = Color.Red;
					
					Phongdb.getInstance().updateState(room.Maphong, "đầy");
				}
				else
				{
					roomButton.BackColor = Color.Green;
					roomButton.Enabled = true;
					Phongdb.getInstance().updateState(room.Maphong, "còn trống");

				}
				roomButton.Click += RoomButton_Click;
				Label label = new Label();
				label.Text = "Số người ở " + SLSV + "/" + room.SoNguoiToiDa.ToString();
				label.Width = 100;
				label.Height = 40;
				label.BackColor = Color.Tomato;
				label.ForeColor = Color.White;
				label.TextAlign = ContentAlignment.MiddleCenter;


				roomButton.Controls.Add(label);


				roomButton.Name = room.Maphong; // Đặt tên (Name) của button là tên phòng (hoặc ID của phòng)
				flowLayoutPanel1.Controls.Add(roomButton);

			}
		}

		private void btChon_Click(object sender, EventArgs e)
		{
			if (cbTang.SelectedItem != null && cbKhu.SelectedItem!=null)
			{
				flowLayoutPanel1.Controls.Clear();
				string tang = cbTang.SelectedItem.ToString();
				string Khu =cbKhu.SelectedItem.ToString();
				RenderRoomsbyfloor(tang, Khu);

			}
			else
			{
				MessageBox.Show("Bạn chưa chọn đủ thông tin ");
			}
		}
		private void RoomButton_Click(object sender, EventArgs e)
		{
			if (sender is Button button)
			{
				string maphong = button.Tag?.ToString();

				if (!string.IsNullOrEmpty(maphong))
				{
					ThongTinLuuTru thongTinLuuTru = new ThongTinLuuTru(maphong);
					thongTinLuuTru.Show();
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (cbTang.SelectedItem != null)
			{
				flowLayoutPanel1.Controls.Clear();
				string tang = cbTang.SelectedItem.ToString();
				string Khu = cbKhu.SelectedItem.ToString();
				RenderRoomsbyfloor(tang, Khu);

			}
			else
			{
				MessageBox.Show("Bạn chưa chọn tầng ");
			}
		}

		private void QuanLyLuuTru_Load(object sender, EventArgs e)
		{

		}

        private void cbKhu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
