using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        NGUOIDUNG_DTO obj = new NGUOIDUNG_DTO();
        private void btnDoi_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "")
            {
                MessageBox.Show("Mật khẩu cũ không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCu.Focus();
                return;
            }
            if (txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Mật khẩu mới không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauMoi.Focus();
                return;
            }
            if ((txtNhapLai.Text != txtMatKhauMoi.Text))
            {
                MessageBox.Show("Nhập lại mật khẩu không trùng khớp", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapLai.Focus();
                return;
            }
            if (txtMatKhauCu.Text != DangNhap.matKhau)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCu.Focus();
                return;
            }
            obj.TaiKhoan = DangNhap.taiKhoan;
            obj.MatKhau = txtMatKhauMoi.Text;
            QuanLyTaiKhoan_BUS.DoiMatKhau(obj);
            MessageBox.Show("Đổi mật khẩu thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtNhapLai.Text = "";
        }
    }
}
