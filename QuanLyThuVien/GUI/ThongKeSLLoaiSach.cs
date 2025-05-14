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
    public partial class ThongKeSLLoaiSach : Form
    {
        public ThongKeSLLoaiSach()
        {
            InitializeComponent();
        }

        private void ThongKeSLLoaiSach_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = BaoCao_BUS.ThongKeSachTheoLoai();
            dgvData.Columns[0].HeaderText = "Tên loại";
            dgvData.Columns[1].HeaderText = "Số lượng";
        }
    }
}
