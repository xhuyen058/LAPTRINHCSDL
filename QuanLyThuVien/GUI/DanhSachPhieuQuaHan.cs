using BUS;
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
    public partial class DanhSachPhieuQuaHan : Form
    {
        public DanhSachPhieuQuaHan()
        {
            InitializeComponent();
        }

        private void DanhSachPhieuQuaHan_Load(object sender, EventArgs e)
        {
            hienthiPM();
            if(dgvPhieuMuon.Rows.Count > 0)
            {
                hienthiPMCT(dgvPhieuMuon.Rows[dgvPhieuMuon.CurrentCell.RowIndex].Cells[0].Value.ToString());
            }    
            else
            {
                hienthiPMCT("");
            }    
        }
        public void hienthiPM()
        {
            dgvPhieuMuon.DataSource = BaoCao_BUS.DanhSachPhieuMuonQuaHan(DateTime.Now.ToString("yyyy/MM/dd"));
            dgvPhieuMuon.Columns[0].HeaderText = "Mã PM";
            dgvPhieuMuon.Columns[1].HeaderText = "Ngày mượn";
            dgvPhieuMuon.Columns[2].HeaderText = "Mã độc giả";
            dgvPhieuMuon.Columns[3].HeaderText = "Tên độc giả";
            dgvPhieuMuon.Columns[4].HeaderText = "Người lập phiếu mượn";
            dgvPhieuMuon.Columns[5].HeaderText = "Ghi chú";
        }
        public void hienthiPMCT(string MaPM)
        {
            dgvChiTietPhieuMuon.DataSource = BaoCao_BUS.DanhSachCTPhieuMuonQuaHan(MaPM);
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

        private void dgvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPhieuMuon.Rows[e.RowIndex];
                hienthiPMCT(row.Cells[0].Value.ToString());
            }
        }
    }
}
