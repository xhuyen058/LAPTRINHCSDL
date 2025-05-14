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
    public partial class PhieuMuonSach : Form
    {
        public PhieuMuonSach()
        {
            InitializeComponent();
        }
        private PHIEUMUON_DTO ObjPM = new PHIEUMUON_DTO();
        private CHITIETMUON_DTO ObjCT = new CHITIETMUON_DTO();
        void Load_ObjPN()
        {
            ObjPM.MaPM = txtMaPM.Text;
            ObjPM.NgayMuon = dtNgayMuon.Value.ToString("yyyyMMdd");
            ObjPM.NguoiLapPhieuMuon = DangNhap.taiKhoan;
            ObjPM.MaDocGia = txtMaDG.Text;
            ObjPM.GhiChu = txtGhiChu.Text;
        }
        void Load_ObjCT()
        {
            ObjCT.MaPM = txtMaPMCT.Text;
            ObjCT.MaSach = txtMaSach.Text;
            if (txtSoLuong.Text == "") txtSoLuong.Text = "0";
            ObjCT.SoLuong = int.Parse(txtSoLuong.Text);
            ObjCT.TrangThai = "Đang mượn";
            ObjCT.TinhTrangSachKhiMuon = cboMaTinhTrangSach.Text;
        }
        //Hàm ẩn hiện các txt, cmb
        void Enlable(bool a)
        {
            dtNgayMuon.Enabled = a;
            txtGhiChu.Enabled = a;
            btnLuu.Enabled = a;
            btnKhongLuu.Enabled = a;
        }
        //Hàm hiển thị
        public void hienthiPM()
        {
            Enlable(false);

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            dgvPhieuMuon.DataSource = PhieuMuon_BUS.GetAll();
            dgvPhieuMuon.Columns[0].HeaderText = "Mã PM";
            dgvPhieuMuon.Columns[1].HeaderText = "Ngày mượn";
            dgvPhieuMuon.Columns[2].HeaderText = "Mã độc giả";
            dgvPhieuMuon.Columns[3].HeaderText = "Tên độc giả";
            dgvPhieuMuon.Columns[4].HeaderText = "Người lập phiếu mượn";
            dgvPhieuMuon.Columns[5].HeaderText = "Ghi chú";
            if(dgvPhieuMuon.Rows.Count ==0)
            {
                txtMaPMCT.Text = "";
                txtMaPM.Text = "";
                txtMaSach.Text = "";
                txtTenSach.Text = "";
                txtSoLuong.Text = "0";
                txtMaDG.Text = "";
                txtTenDG.Text = "";
                txtGhiChu.Text = "";
            }    
        }
        public void hienthiPMCT()
        {
            Load_ObjCT();
            dgvChiTietPhieuMuon.DataSource = ChiTietMuon_BUS.GetAll(ObjCT);
            dgvChiTietPhieuMuon.Columns[0].HeaderText = "Mã phiếu mượn";
            dgvChiTietPhieuMuon.Columns[1].HeaderText = "Mã sách";
            dgvChiTietPhieuMuon.Columns[2].HeaderText = "Tên sách";
            dgvChiTietPhieuMuon.Columns[3].HeaderText = "Số lượng";
            dgvChiTietPhieuMuon.Columns[4].HeaderText = "Ngày trả";
            dgvChiTietPhieuMuon.Columns[5].HeaderText = "Trạng thái";
            dgvChiTietPhieuMuon.Columns[6].HeaderText = "Người lập phiếu trả";
            dgvChiTietPhieuMuon.Columns[7].HeaderText = "Tình trạng sách khi mượn";
            dgvChiTietPhieuMuon.Columns[8].HeaderText = "Tình trạng sách khi trả";
        }
        private void PhieuMuonSach_Load(object sender, EventArgs e)
        {
            cboTinhTrangSach();
            hienthiPM();
            hienthiPMCT();
        }
        private void cboTinhTrangSach()
        {
            DataTable dataTable = new DataTable();
            cboMaTinhTrangSach.Items.Clear();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Rows.Add("Còn nguyên");
            dataTable.Rows.Add("Có rách");
            cboMaTinhTrangSach.DataSource = dataTable;
            cboMaTinhTrangSach.DisplayMember = "Name";
            cboMaTinhTrangSach.ValueMember = "Name";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Enlable(true);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaPM.Text = "PM_" + DateTime.Now.ToString("yyyyMMddhhmmss");//Định dạng thời gian hiện tại theo chuỗi "yyyyMMddhhmmss" sử dụng phương thức ToString(). Ví dụ, nếu thời gian hiện tại là 31/05/2024 lúc 14:30:25, kết quả sẽ là "20240531143025".
            txtGhiChu.Text = "";
            txtMaDG.Text = "";
            txtTenDG.Text = "";
            txtNguoiLapPhieuMuon.Text = DangNhap.taiKhoan;
            txtGhiChu.Focus();
            dtNgayMuon.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvPhieuMuon.Rows.Count == 0)
            {
                MessageBox.Show("Không có phiếu mượn để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if (dgvPhieuMuon.Rows[dgvChiTietPhieuMuon.CurrentCell.RowIndex].Cells[5].Value.ToString() == "Đã trả")
            //{
            //    MessageBox.Show("Phiếu này đã được trả, không được phép sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            Enlable(true);
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn xóa phiếu mượn này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Load_ObjPN();
                if (PhieuMuon_BUS.Xoa(ObjPM) == "Success")
                {
                    MessageBox.Show("Xóa thành công");
                    hienthiPM();
                    hienthiPMCT();
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
            if (txtMaDG.Text == "")
            {
                MessageBox.Show("Chưa có độc giả để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDG.Focus();
                return;
            }
            if (btnThem.Enabled == true)
            {
                Load_ObjPN();
                string ketQua = PhieuMuon_BUS.Them(ObjPM);
                if (ketQua != "Success")
                {
                    MessageBox.Show("Đã tồn tại phiếu mượn này, vui lòng tạo bằng mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Thêm thành công");
                hienthiPM();
                return;
            }
            if (btnSua.Enabled == true)
            {
                Load_ObjPN();
                string ketQua = PhieuMuon_BUS.Sua(ObjPM);
                if (ketQua != "Success")
                {
                    MessageBox.Show(ketQua, "Lỗi");
                }
                MessageBox.Show("Sửa thành công");
                hienthiPM();
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            hienthiPM();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChonDG_Click(object sender, EventArgs e)
        {
            TimKiemDocGia frm = new TimKiemDocGia();
            frm.ShowDialog();
            txtMaDG.Text = TimKiemDocGia.madocgia;
            txtTenDG.Text = TimKiemDocGia.tendocgia;
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
            if (dgvPhieuMuon.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có phiếu mượn để thêm chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if (dgvPhieuMuon.Rows[dgvChiTietPhieuMuon.CurrentCell.RowIndex].Cells[5].Value.ToString() == "Đã trả")
            //{
            //    MessageBox.Show("Phiếu này đã được trả, không được phép thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
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
            string ketQua = ChiTietMuon_BUS.Them(ObjCT);
            if (ketQua != "Success")
            {
                MessageBox.Show("Phiếu này đã tồn tại mã sách này, vui lòng chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hienthiPMCT();
            MessageBox.Show("Thêm thành công!");
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            if (dgvPhieuMuon.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có phiếu mượn để thêm chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvChiTietPhieuMuon.Rows[dgvChiTietPhieuMuon.CurrentCell.RowIndex].Cells[5].Value.ToString() == "Đã trả")
            {
                MessageBox.Show("Phiếu này đã được trả, không được phép sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string ketQua = ChiTietMuon_BUS.Sua(ObjCT);
            if (ketQua != "Success")
            {
                MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hienthiPMCT();
            MessageBox.Show("Sửa thành công!");
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (dgvPhieuMuon.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có phiếu nhập để thêm chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvPhieuMuon.Rows[dgvChiTietPhieuMuon.CurrentCell.RowIndex].Cells[5].Value.ToString() == "Đã trả")
            {
                MessageBox.Show("Phiếu này đã được trả, không được phép xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Load_ObjCT();
            string ketQua = ChiTietMuon_BUS.Xoa(ObjCT);
            if (ketQua != "Success")
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hienthiPMCT();
            MessageBox.Show("Xóa thành công!");
        }

        private void PhieuMuonSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            string ketQua = PhieuMuon_BUS.XoaPhieuMuonKhongCoChiTiet();
        }

        private void dgvPhieuMuon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaPM.Text = dgvPhieuMuon.Rows[dong].Cells[0].Value.ToString();
            txtMaPMCT.Text = dgvPhieuMuon.Rows[dong].Cells[0].Value.ToString();
            dtNgayMuon.Text = dgvPhieuMuon.Rows[dong].Cells[1].Value.ToString();
            txtMaDG.Text = dgvPhieuMuon.Rows[dong].Cells[2].Value.ToString();
            txtTenDG.Text = dgvPhieuMuon.Rows[dong].Cells[3].Value.ToString();
            txtGhiChu.Text = dgvPhieuMuon.Rows[dong].Cells[5].Value.ToString();
            txtNguoiLapPhieuMuon.Text = dgvPhieuMuon.Rows[dong].Cells[4].Value.ToString();
            hienthiPMCT();
            if (dgvChiTietPhieuMuon.Rows.Count == 0)
            {
                txtMaSach.Text = "";
                txtTenSach.Text = "";
                txtSoLuong.Text = "0";
            }
        }

        private void dgvChiTietPhieuMuon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaSach.Text = dgvChiTietPhieuMuon.Rows[dong].Cells[1].Value.ToString();
            txtTenSach.Text = dgvChiTietPhieuMuon.Rows[dong].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvChiTietPhieuMuon.Rows[dong].Cells[3].Value.ToString();
            cboMaTinhTrangSach.Text = dgvChiTietPhieuMuon.Rows[dong].Cells[7].Value.ToString();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgvChiTietPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
