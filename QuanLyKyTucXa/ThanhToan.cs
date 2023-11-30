using QuanLyKyTucXa.db;
using QuanLyKyTucXa.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyKyTucXa
{
	public partial class ThanhToan : Form
	{ string MaHD;
		public ThanhToan()
		{
			InitializeComponent();
		}
		public ThanhToan(string mahd)
		{
			InitializeComponent();
			HoaDon hoadon = HoaDondb.getInstance().SelectByMa(mahd);
			txtTP.Text = hoadon.tenPhong;
			MaHD = mahd;
			txtThang.Text=hoadon.Thang.ToString();
			txtNam.Text=hoadon.Nam.ToString();
			txtTD.Text=hoadon.SoDien.ToString();
			txtTN.Text=hoadon.SoNuoc.ToString();
			int tongtien = hoadon.SoNuoc + hoadon.SoDien;
			txtTT.Text=tongtien.ToString();
			btnIn.Visible = false;
			


		}

		private void ThanhToan_Load(object sender, EventArgs e)
		{

		}

		private void txtTT_TextChanged(object sender, EventArgs e)
		{

		}

		private void iconButton1_Click(object sender, EventArgs e)
		{
			int tongtien=int.Parse(txtTT.Text);
			string tiendua=txtTien.Text;
			if (string.IsNullOrEmpty(tiendua))
			{
				MessageBox.Show("bạn chưa nhập tiền ");
			}
			else
			{
				int tienduaInt=int.Parse(tiendua);
				if (tienduaInt < tongtien)
				{
					MessageBox.Show("sô tiền nhập ít hơn tổng tiền");
				}
				else
				{
					int tienconlai = tienduaInt - tongtien;
					txtTCL.Text=tienconlai.ToString();
					txtTCL.Visible = true;
					lbTCL.Visible = true;

					HoaDondb.getInstance().updateHD(MaHD);
					btnIn.Visible = true;
				}
			}
		}

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook exBook = excelApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1];

            Excel.Range titleCell = (Excel.Range)exSheet.Cells[1, 1];
            titleCell.Font.Size = 15;
            titleCell.Font.Bold = true;
            titleCell.Font.Color = Color.Blue;
            titleCell.Value = "Ký túc xã đại học Giao thông Vận tải";

            // Thêm thông tin "Hóa đơn điện nước"
            Excel.Range titleCell2 = (Excel.Range)exSheet.Cells[2, 1];
            titleCell2.Font.Size = 15;
            titleCell2.Font.Bold = true;
            titleCell2.Font.Color = Color.Red;
            titleCell2.Value = "Hóa đơn điện nước";

          
        exSheet.Cells[3, 1].Value = "Tên Phòng:";
            exSheet.Cells[3, 2].Value = txtTP.Text;
            exSheet.Cells[4, 1].Value = "Số Tiền Điện:";
            exSheet.Cells[4, 2].Value = txtTD.Text;
            exSheet.Cells[5, 1].Value = "Số Tiền Nước:";
            exSheet.Cells[5, 2].Value = txtTN.Text;
            exSheet.Cells[6, 1].Value = "Tổng Tiền:";
            exSheet.Cells[6, 2].Value = txtTT.Text;
            exSheet.Cells[7, 1].Value = "Số Tiền Đưa:";
            exSheet.Cells[7, 2].Value = txtTien.Text;
            exSheet.Cells[8, 1].Value = "Số Tiền Giả Lại:";
            exSheet.Cells[8, 2].Value = txtTCL.Text;

            // Đặt độ rộng cột cho ô tiêu đề và ô dữ liệu
            titleCell.EntireColumn.AutoFit();
            titleCell2.EntireColumn.AutoFit();
            exBook.Activate();
			SaveFileDialog save=new SaveFileDialog();
            save.Filter = "Excel Files|*.xlsx";
            if (save.ShowDialog() == DialogResult.OK)
			{
				exBook.SaveAs(save.FileName.ToLower());
			}
			excelApp.Quit();

           
            
        }
    }
}
