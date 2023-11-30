using QuanLyKyTucXa.db;
using QuanLyKyTucXa.models;
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
	public partial class TraCuuHoSo : UserControl
	{
		public TraCuuHoSo()
		{
			InitializeComponent();
            HienThi();
        }
		public void HienThi()
		{
            int soSvNam = SinhViendb.getInstance().soSv("Nam");
            int soSvNu = SinhViendb.getInstance().soSv("Nữ");
            int tongSv = SinhViendb.getInstance().TongSv();
            txtSVN.Text = soSvNam.ToString();
            txtSV.Text = soSvNu.ToString();
            txtT.Text = tongSv.ToString();
        }

		private void iconButton1_Click(object sender, EventArgs e)
		{
			
			







		}

		private void dataGridSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridSv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

        private void txtMSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void TraCuuHoSo_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtT_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
