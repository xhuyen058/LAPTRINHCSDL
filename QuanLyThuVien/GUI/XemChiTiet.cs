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
using System.Xml.Linq;

namespace GUI
{
    public partial class XemChiTiet : Form
    {
        public XemChiTiet()
        {
            InitializeComponent();
        }

        private void XemChiTiet_Load(object sender, EventArgs e)
        {
            hienthiPM();
            hienthiPMCT();
        }
        public void hienthiPM()
        {
            dgvPhieuMuon.DataSource = PhieuMuon_BUS.XemPhieuMuon(BaoCao.MaHDCT);
            dgvPhieuMuon.Columns[0].HeaderText = "Mã PM";
            dgvPhieuMuon.Columns[1].HeaderText = "Ngày mượn";
            dgvPhieuMuon.Columns[2].HeaderText = "Mã độc giả";
            dgvPhieuMuon.Columns[3].HeaderText = "Tên độc giả";
            dgvPhieuMuon.Columns[4].HeaderText = "Người lập phiếu mượn";
            dgvPhieuMuon.Columns[5].HeaderText = "Ghi chú";
        }
        public void hienthiPMCT()
        {
            dgvChiTietPhieuMuon.DataSource = PhieuMuon_BUS.XemChiTietPhieuMuon(BaoCao.MaHDCT);
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
    }
}
