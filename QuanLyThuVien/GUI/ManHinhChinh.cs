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
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void ManHinhChinh_Load_1(object sender, EventArgs e)
        {
            if (DangNhap.maQuyen == "Nhân viên")
            {
                btnQLTK.Enabled = false;
                btnSach.Enabled = false;
                btnPhieuNhap.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn đăng xuất phần mềm không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan frm = new QuanLyTaiKhoan();
            frm.ShowDialog();
        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau frm = new DoiMatKhau();
            frm.ShowDialog();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            QuanLySach frm = new QuanLySach();
            frm.ShowDialog();
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            QuanLyDocGia frm = new QuanLyDocGia();
            frm.ShowDialog();
        }

        private void btnKeSach_Click(object sender, EventArgs e)
        {
            QuanLyKeSach frm = new QuanLyKeSach();
            frm.ShowDialog();
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            PhieuNhapSach frm = new PhieuNhapSach();
            frm.ShowDialog();
        }

        private void btnPhieuMuonTra_Click(object sender, EventArgs e)
        {
            PhieuMuonSach frm = new PhieuMuonSach();
            frm.ShowDialog();
        }

        private void phiếuTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuTraSach frm = new PhieuTraSach();
            frm.ShowDialog();
        }

        private void menuTKP_Click(object sender, EventArgs e)
        {
            BaoCao frm = new BaoCao();
            frm.ShowDialog();
        }

        private void menuDSPQH_Click(object sender, EventArgs e)
        {
            DanhSachPhieuQuaHan frm = new DanhSachPhieuQuaHan();
            frm.ShowDialog();
        }

        private void menuTKLS_Click(object sender, EventArgs e)
        {
            ThongKeSLLoaiSach frm = new ThongKeSLLoaiSach();
            frm.ShowDialog();
        }

        private void menuTKDG_Click(object sender, EventArgs e)
        {
            TimKiemDocGia frm = new TimKiemDocGia();
            frm.ShowDialog();
        }

        private void menuTKS_Click(object sender, EventArgs e)
        {
            TimKiemSach frm = new TimKiemSach();
            frm.ShowDialog();
        }
    }

}
