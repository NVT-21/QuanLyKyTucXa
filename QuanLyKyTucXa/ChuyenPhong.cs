using QuanLyKyTucXa.Database;
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

namespace QuanLyKyTucXa
{
    public partial class ChuyenPhong : Form
    {
        public ChuyenPhong()
        {
            InitializeComponent();
        }
        public ChuyenPhong(string Masv,string HT,string GioiTinh)
        {
            InitializeComponent();
            txtHT.Text = HT;
            txtM.Text= Masv;
            txtGT.Text= GioiTinh;
            if (GioiTinh.Equals("Nam"))
            {
                cbKhu.Items.Clear();
                cbKhu.Items.Add("Ký túc xá Nam");
            }
            else if (GioiTinh.Equals("Nữ"))
            {
                cbKhu.Items.Clear();
                cbKhu.Items.Add("Ký túc xá Nữ");
            }


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string maphong=txtMP.Text;
            string masv=txtM.Text;
            Phong phong = Phongdb.getInstance().SelectRoombyMa(maphong);
           

            if (cbKhu.SelectedItem == null || string.IsNullOrEmpty(maphong))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin ");
            }
            else if (phong == null)
            {
                MessageBox.Show("Không tồn tại phòng này ");
            }
            else
            {

            int SLSV =Phongdb.getInstance().CountNumberStudent(maphong);
            Phong p = Phongdb.getInstance().SelectRoombyMa(maphong);
            int songuoitoida = p.SoNguoiToiDa;
           
            
           
            if (SLSV >= songuoitoida)
            {
                MessageBox.Show("Phòng này đã đầy ");
            }

            else
            {

                ChiTietDkydb.getInstance().chuyenphong(masv, maphong);
                MessageBox.Show("Chuyển phòng thành công ");
            }

            }

        }

        private void ChuyenPhong_Load(object sender, EventArgs e)
        {

        }

        private void cbKhu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
