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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public static string taiKhoan;
        public static string matKhau;
        public static string maQuyen;
        NGUOIDUNG_DTO ObjDangnhap = new NGUOIDUNG_DTO();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            ObjDangnhap.TaiKhoan = txtTaiKhoan.Text;
            ObjDangnhap.MatKhau = txtMatKhau.Text;

            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Không được bỏ trống các trường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtTaiKhoan.Text == "")
                    txtTaiKhoan.Focus();
                else txtMatKhau.Focus();
                return;
            }
            else
            {
                if (QuanLyTaiKhoan_BUS.DangNhap(ObjDangnhap) == true)
                {
                    taiKhoan = ObjDangnhap.TaiKhoan;
                    matKhau = ObjDangnhap.MatKhau;
                    DataTable dt = new DataTable();
                    dt = QuanLyTaiKhoan_BUS.MaQuyen(ObjDangnhap);
                    maQuyen = dt.Rows[0][0].ToString();
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ManHinhChinh frm = new ManHinhChinh();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaiKhoan.Focus();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }  
}
