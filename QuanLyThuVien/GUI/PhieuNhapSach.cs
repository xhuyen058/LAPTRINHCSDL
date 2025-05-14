using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PhieuNhapSach : Form
    {
        public PhieuNhapSach()
        {
            InitializeComponent();
        }
        private PHIEUNHAP_DTO ObjPN = new PHIEUNHAP_DTO();
        private CHITIETNHAP_DTO ObjCT = new CHITIETNHAP_DTO();
        void Load_ObjPN()
        {
            ObjPN.MaPN = txtMaPN.Text;
            ObjPN.NgayLap = dtNgayLap.Value.ToString("yyyyMMdd");
            ObjPN.GhiChu = txtGhiChu.Text;
            ObjPN.NguoiLap = DangNhap.taiKhoan;
        }
        void Load_ObjCT()
        {
            ObjCT.MaPN = txtMaPNCT.Text;
            ObjCT.MaSach = txtMaSach.Text;
            ObjCT.MaNCC = cboMaNCC.SelectedValue.ToString();
            if (txtSoLuong.Text == "") txtSoLuong.Text = "0";
            ObjCT.SoLuong = int.Parse(txtSoLuong.Text);
        }
        private void cboDanhSachNCC()
        {
            DataTable dt = PhieuNhap_BUS.DanhSachNCC();
            cboMaNCC.DataSource = dt;
            cboMaNCC.DisplayMember = "TenNCC";
            cboMaNCC.ValueMember = "MaNCC";
        }
        //Hàm ẩn hiện các txt, cmb
        void Enlable(bool a)
        {
            dtNgayLap.Enabled = a;
            txtGhiChu.Enabled = a;
            btnLuu.Enabled = a;
            btnKhongLuu.Enabled = a;
        }
        //Hàm hiển thị
        public void hienthiPN()
        {
            Enlable(false);

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            dgvPhieuNhap.DataSource = PhieuNhap_BUS.GetAll();
            dgvPhieuNhap.Columns[0].HeaderText = "Mã PN";
            dgvPhieuNhap.Columns[1].HeaderText = "Ngày lập";
            dgvPhieuNhap.Columns[2].HeaderText = "Ghi chú";
            dgvPhieuNhap.Columns[3].HeaderText = "Người lập";
            if (dgvPhieuNhap.Rows.Count == 0)
            {
                txtMaPN.Text = "";
                txtMaPNCT.Text = "";
                txtMaSach.Text = "";
                txtTenSach.Text = "";
                txtSoLuong.Text = "0";
                txtGhiChu.Text = "";
            }
        }
        public void hienthiPNCT()
        {
            Load_ObjCT();
            dgvChiTietPhieuNhap.DataSource = ChiTietNhap_BUS.GetAll(ObjCT);
            dgvChiTietPhieuNhap.Columns[0].HeaderText = "Mã PN";
            dgvChiTietPhieuNhap.Columns[1].HeaderText = "Mã sách";
            dgvChiTietPhieuNhap.Columns[2].HeaderText = "Tên sách";
            dgvChiTietPhieuNhap.Columns[3].HeaderText = "Mã NCC";
            dgvChiTietPhieuNhap.Columns[4].HeaderText = "Tên NCC";
            dgvChiTietPhieuNhap.Columns[5].HeaderText = "Số lượng";
        }
        private void PhieuNhapSach_Load(object sender, EventArgs e)
        {
            cboDanhSachNCC();
            hienthiPN();
            hienthiPNCT();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgvPhieuNhap_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaPN.Text = dgvPhieuNhap.Rows[dong].Cells[0].Value.ToString();
            txtMaPNCT.Text = dgvPhieuNhap.Rows[dong].Cells[0].Value.ToString();
            dtNgayLap.Text = dgvPhieuNhap.Rows[dong].Cells[1].Value.ToString();
            txtGhiChu.Text = dgvPhieuNhap.Rows[dong].Cells[2].Value.ToString();
            txtNguoiLap.Text = dgvPhieuNhap.Rows[dong].Cells[3].Value.ToString();
            hienthiPNCT();
            if(dgvChiTietPhieuNhap.Rows.Count == 0)
            {
                txtMaSach.Text = "";
                txtTenSach.Text = "";
                txtSoLuong.Text = "0";
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Enlable(true);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaPN.Text = "PN_" + DateTime.Now.ToString("yyyyMMddhhmmss");
            txtGhiChu.Text = "";
            txtNguoiLap.Text = DangNhap.taiKhoan;
            txtGhiChu.Focus();
            dtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.Rows.Count == 0)
            {
                MessageBox.Show("Không có phiếu nhập để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Enlable(true);
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn xóa phiếu nhập này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Load_ObjPN();
                if (PhieuNhap_BUS.Xoa(ObjPN) == "Success")
                {
                    hienthiPN();
                    hienthiPNCT();
                }
                else
                {
                    MessageBox.Show("Dữ liệu đã phát sinh khóa ngoại ở bảng khác, không xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true)
            {
                Load_ObjPN();
                string ketQua = PhieuNhap_BUS.Them(ObjPN);
                if (ketQua != "Success")
                {
                    MessageBox.Show("Đã tồn tại phiếu nhập này, vui lòng tạo bằng mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                hienthiPN();
                return;
            }
            if (btnSua.Enabled == true)
            {
                Load_ObjPN();
                string ketQua = PhieuNhap_BUS.Sua(ObjPN);
                if (ketQua != "Success")
                {
                    MessageBox.Show(ketQua, "Lỗi");
                }
                hienthiPN();
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            hienthiPN();
        }

        private void btnMaSach_Click(object sender, EventArgs e)
        {
            TimKiemSach frm = new TimKiemSach();
            frm.ShowDialog();
            txtMaSach.Text = TimKiemSach.masach;
            txtTenSach.Text = TimKiemSach.tensach;
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có phiếu nhập để thêm chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Chưa chọn sách để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach.Focus();
                return;
            }

            if (txtSoLuong.Text == "" || txtSoLuong.Text.Trim() == "0")
            {
                MessageBox.Show("Số lượng phải khác 0 và không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }
            Load_ObjCT();
            string ketQua = ChiTietNhap_BUS.Them(ObjCT);
            if (ketQua != "Success")
            {
                MessageBox.Show("Phiếu này đã tồn tại mã sách này, vui lòng chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hienthiPNCT();
            MessageBox.Show("Thêm thành công!");
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có phiếu nhập để thêm chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Chưa chọn sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach.Focus();
                return;
            }
            if (txtSoLuong.Text == "" || txtSoLuong.Text.Trim() == "0")
            {
                MessageBox.Show("Số lượng phải khác 0 và không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }
            Load_ObjCT();
            string ketQua = ChiTietNhap_BUS.Sua(ObjCT);
            if (ketQua != "Success")
            {
                MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hienthiPNCT();
            MessageBox.Show("Sửa thành công!");
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có phiếu nhập để thêm chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Load_ObjCT();
            string ketQua = ChiTietNhap_BUS.Xoa(ObjCT);
            if (ketQua != "Success")
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hienthiPNCT();
            MessageBox.Show("Xóa thành công!");
        }

        private void dgvChiTietPhieuNhap_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaSach.Text = dgvChiTietPhieuNhap.Rows[dong].Cells[1].Value.ToString();
            txtTenSach.Text = dgvChiTietPhieuNhap.Rows[dong].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvChiTietPhieuNhap.Rows[dong].Cells[5].Value.ToString();
            cboMaNCC.SelectedValue = dgvChiTietPhieuNhap.Rows[dong].Cells[3].Value.ToString();
        }

        private void PhieuNhapSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            string ketQua = PhieuNhap_BUS.XoaPhieuNhapKhongCoChiTiet();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
