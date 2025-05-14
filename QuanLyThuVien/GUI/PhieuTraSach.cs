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
    public partial class PhieuTraSach : Form
    {
        public PhieuTraSach()
        {
            InitializeComponent();
        }
        private CHITIETMUON_DTO ObjCT = new CHITIETMUON_DTO();
        string MaSach;
        void Load_ObjCT()
        {
            ObjCT.MaPM = txtMaPM.Text;
            ObjCT.NgayTra = dtNgayMuon.Value.ToString("yyyyMMdd");
            ObjCT.TrangThai = "Đã trả";
            ObjCT.NguoiLapPhieuTra = DangNhap.taiKhoan;
            ObjCT.TinhTrangSachKhiTra = cboMaTinhTrangSach.Text;
            
        }
        public void hienthiPM()
        {
            dgvPhieuMuon.DataSource = PhieuMuon_BUS.GetPhieuMuonCanTra();
            dgvPhieuMuon.Columns[0].HeaderText = "Mã PM";
            dgvPhieuMuon.Columns[1].HeaderText = "Ngày mượn";
            dgvPhieuMuon.Columns[2].HeaderText = "Mã độc giả";
            dgvPhieuMuon.Columns[3].HeaderText = "Tên độc giả";
            dgvPhieuMuon.Columns[4].HeaderText = "Người lập phiếu mượn";
            dgvPhieuMuon.Columns[5].HeaderText = "Ghi chú";
        }
        public void hienthiPMCT()
        {
            ObjCT.MaPM = txtMaPM.Text;
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
        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
        private void PhieuTraSach_Load(object sender, EventArgs e)
        {
            cboTinhTrangSach();
            hienthiPM();
            hienthiPMCT();
            txtNguoiLapPhieuTra.Text = DangNhap.taiKhoan;
        }

        private void dgvPhieuMuon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaPM.Text = dgvPhieuMuon.Rows[dong].Cells[0].Value.ToString();
            MaSach = dgvPhieuMuon.Rows[dong].Cells[1].Value.ToString();
            hienthiPMCT();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvPhieuMuon.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có phiếu mượn để trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn thực sự muốn trả sách không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Load_ObjCT();
                ObjCT.MaSach = dgvChiTietPhieuMuon.Rows[dgvChiTietPhieuMuon.CurrentCell.RowIndex].Cells[1].Value.ToString();
                string ketQua = ChiTietMuon_BUS.TraSach(ObjCT);
                if (ketQua != "Success")
                {
                    MessageBox.Show("Trả sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Trả sách thành công!");   
                hienthiPM();
                if (dgvPhieuMuon.Rows.Count == 0)
                {
                    txtMaPM.Text = "";
                    ObjCT.MaPM = "";
                }
                hienthiPMCT();
                return;
            }
        }
    }
}
