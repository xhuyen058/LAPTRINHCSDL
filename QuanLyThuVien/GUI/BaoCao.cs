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
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }
        public static string MaHDCT = "";
        private void BaoCao_Load(object sender, EventArgs e)
        {

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            
            dgvData.DataSource = BaoCao_BUS.GetAll(txtThang.Text,txtNam.Text);
            this.dgvData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvData.Columns[0].HeaderText = "Tháng";
            dgvData.Columns[1].HeaderText = "Năm";
            dgvData.Columns[2].HeaderText = "Tên người mượn";
            dgvData.Columns[3].HeaderText = "Tên sách";
            dgvData.Columns[4].HeaderText = "Trạng thái";
            dgvData.Columns[5].Visible = false;
            DataGridViewImageColumn btn2 = new DataGridViewImageColumn();
            dgvData.Columns.Add(btn2);
            btn2.Width = 80;
            btn2.ReadOnly = true;
            btn2.Name = "Xem chi tiết";
            if (dgvData.Rows.Count == 0)
            {
                lblSL1.Text = "0";
                lblSL2.Text = "0";
                return;
            }
            int SL1 = 0;
            int SL2 = 0;
            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                if(dgvData.Rows[i].Cells["TrangThai"].Value.ToString() == "Đang Mượn")
                {
                    SL1 += 1;
                }  
                else
                {
                    SL2 += 1;
                }
            }
            lblSL1.Text = SL1.ToString();
            lblSL2.Text = SL2.ToString();
        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaoCaoTop5 frm = new BaoCaoTop5();
            frm.ShowDialog();
        }

        private void dgvData_DoubleClick(object sender, EventArgs e)
        {
            if(dgvData.CurrentCell.ColumnIndex.ToString() == "6")
            {
                MaHDCT = dgvData.Rows[dgvData.CurrentCell.RowIndex].Cells["MaPM"].Value.ToString();
                XemChiTiet frm = new XemChiTiet();
                frm.ShowDialog();
            }    
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
