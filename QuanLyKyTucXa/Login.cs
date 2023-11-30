using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyKyTucXa
{
	public partial class Login : Form
	{
		/*string strCon = @"Data Source=LAPTOP-0QV26TOC;Initial Catalog=QuanLyKyTucXa;Integrated Security=True";
		SqlConnection sqlCon = null;*/
		Class.DataBaseProcess dtbase = new Class.DataBaseProcess();
		public Login()
		{
			InitializeComponent();
			this.Text = "Đăng nhập ";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string taikhoan = txtTK.Text;
			string matkhau = txtMK.Text;
			string query = $"SELECT * FROM  TaiKhoan WHERE TaiKhoan = N'{taikhoan}' AND MatKhau = N'{matkhau}'";

			DataTable result = dtbase.DataReader(query);


			if (result.Rows.Count > 0)
			{
				// Đăng nhập thành công
				try
				{
                    
                    MessageBox.Show("Đăng nhập thành công!");

                    this.Hide();
                    // Hiển thị form chính
                    DashBoard dashBoard = new DashBoard();
                    dashBoard.FormClosed += (s, args) => this.Close(); // Đóng ứng dụng khi form chính đóng
                    dashBoard.Show();



                }
			catch (Exception ex)
			{
				Console.WriteLine("Lỗi: " + ex.Message);
			}

			}
			else
			{
				// Đăng nhập thất bại
				MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tài khoản và mật khẩu.");
			}


		}

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
