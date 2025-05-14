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
    public partial class BaoCaoTop5 : Form
    {
        public BaoCaoTop5()
        {
            InitializeComponent();
        }

        private void BaoCaoTop5_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = BaoCao_BUS.GetTop5();
            dgvData.Columns[0].HeaderText = "Tên sách";
            dgvData.Columns[1].HeaderText = "Số lượng";
        }
    }
}
