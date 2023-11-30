using QuanLyKyTucXa.AllFormChild;
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

namespace QuanLyKyTucXa
{
	public partial class DashBoard : Form
	{
		public DashBoard()
		{
			InitializeComponent();
			test1.Visible = false;
			chonPhongNu1.Visible = false;
			traCuuHoSo1.Visible = false;
			quanLyLuuTru1.Visible=false;
			thanhToanDienNuoccs1.Visible = false;
			ghiTienDienNuoc1.Visible = false;
			
			



		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Size = Screen.PrimaryScreen.WorkingArea.Size;

			// Đặt vị trí của Form ở góc trái trên cùng của màn hình
			this.Location = Screen.PrimaryScreen.WorkingArea.Location;

		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void iconButton6_Click(object sender, EventArgs e)
		{
		
		}

		private void chonPhongNam_Load(object sender, EventArgs e)
		{
			this.Size = Screen.PrimaryScreen.WorkingArea.Size;

			// Đặt vị trí của Form ở góc trái trên cùng của màn hình
			this.Location = Screen.PrimaryScreen.WorkingArea.Location;
		}

		private void chonPhong2_Load(object sender, EventArgs e)
		{

		}

		private void chonPhong1_Load(object sender, EventArgs e)
		{

		}

		private void iconButton7_Click(object sender, EventArgs e)
		{
			chonPhongNu1.Visible = false;
			traCuuHoSo1.Visible = false;
			quanLyLuuTru1 .Visible = false;	
			thanhToanDienNuoccs1 .Visible = false;
			ghiTienDienNuoc1 .Visible = false;
		
			test1.Visible = true;

		}
		

		private void iconButton8_Click(object sender, EventArgs e)
		{
			test1.Visible = false;
			traCuuHoSo1.Visible = false;
			quanLyLuuTru1.Visible = false;
            thanhToanDienNuoccs1.Visible = false;
			ghiTienDienNuoc1.Visible= false;
            chonPhongNu1.Visible = true;




		}
		

		private void iconButton5_Click(object sender, EventArgs e)
		{
			chonPhongNu1.Visible = false;
			test1.Visible = false;
			quanLyLuuTru1.Visible = false;
            thanhToanDienNuoccs1.Visible = false;
			ghiTienDienNuoc1.Visible= false;

            traCuuHoSo1.Visible = true;
		}

		private void iconButton9_Click(object sender, EventArgs e)
		{
			chonPhongNu1.Visible = false;
			test1.Visible = false;
			traCuuHoSo1.Visible = false;
            thanhToanDienNuoccs1.Visible = false;
			ghiTienDienNuoc1.Visible= false;
            quanLyLuuTru1.Visible = true;
			
		}

		private void pheDuyetHoSo1_Load(object sender, EventArgs e)
		{

		}

        private void thanhToanDienNuoccs1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            chonPhongNu1.Visible = false;
            test1.Visible = false;
            traCuuHoSo1.Visible = false;
            thanhToanDienNuoccs1.Visible = false;
            quanLyLuuTru1.Visible = false;
			ghiTienDienNuoc1.Visible = true;
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            chonPhongNu1.Visible = false;
            test1.Visible = false;
            traCuuHoSo1.Visible = false;
            thanhToanDienNuoccs1.Visible = true;
            quanLyLuuTru1.Visible = false;
			ghiTienDienNuoc1.Visible = false;
        }
    }
}
