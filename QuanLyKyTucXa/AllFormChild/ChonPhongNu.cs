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
	public partial class ChonPhongNu : UserControl
	{
		public ChonPhongNu()
		{
			InitializeComponent();
			cbTang.Items.Add("Tầng 1 ");
			cbTang.Items.Add("Tầng 2 ");
			cbTang.Items.Add("Tầng 3 ");
			cbTang.Items.Add("Tầng 4 ");
			cbTang.Items.Add("Tầng 5 ");
			cbTang.Items.Add("Tầng 6 ");
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
				roomButton.Text = room.TenPhong;
				roomButton.Tag = room.Maphong;
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
						roomButton.Enabled = false;
						break;
					default: roomButton.BackColor = Color.Wheat; roomButton.Enabled = false; break;
				}
				SLSV = Phongdb.getInstance().CountNumberStudent(room.Maphong);
				if (SLSV >= room.SoNguoiToiDa)
				{
					roomButton.BackColor = Color.Red;
					roomButton.Enabled = false;
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

		private void ChonPhongNu_Load(object sender, EventArgs e)
		{

		}
		private void RoomButton_Click(object sender, EventArgs e)
		{
			if (sender is Button button)
			{
				string maphong = button.Tag?.ToString();

				if (!string.IsNullOrEmpty(maphong))
				{	
					DangKyPhong dangkyphong = new DangKyPhong(maphong,1300,600);
					dangkyphong.Show();
				}
			}
		}

		private void iconButton1_Click(object sender, EventArgs e)
		{
			if (cbTang.SelectedItem != null)
			{
				flowLayoutPanel1.Controls.Clear();
				string tang = cbTang.SelectedItem.ToString();
                string khu = lbKhu.Text;
                RenderRoomsbyfloor(tang, khu);

            }
			else
			{
				MessageBox.Show("Bạn chưa chọn tầng ");
			}
		}

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (cbTang.SelectedItem != null)
            {
                flowLayoutPanel1.Controls.Clear();
                string tang = cbTang.SelectedItem.ToString();
                string Khu = lbKhu.Text;
                RenderRoomsbyfloor(tang, Khu);

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tầng ");
            }
        }
    }
}
