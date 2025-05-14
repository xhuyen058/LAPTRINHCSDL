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
    public partial class TimKiemSach : Form
    {
        public TimKiemSach()
        {
            InitializeComponent();
        }
        SACH_DTO Obj = new SACH_DTO();
        public static string masach;
        public static string tensach;
        void Load_Obj ()
        {
            Obj.MaSach = txtMaSach.Text;
            Obj.TenSach = txtTenSach.Text;
            Obj.MaKe = txtMaKe.Text;
            Obj.NhaXuatBan = txtNhaXuatBan.Text;
            Obj.NamXuatBan = txtNamXuatBan.Text;
            Obj.TacGia = txtTacGia.Text;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            hienthi();
        }
        public void hienthi()
        {
            Load_Obj();
            dgvSach.DataSource = QuanLySach_BUS.TimKiemSach(Obj);
            dgvSach.Columns[0].HeaderText = "Mã sách";
            dgvSach.Columns[1].HeaderText = "Tên sách";
            dgvSach.Columns[2].HeaderText = "Mã kệ";
            dgvSach.Columns[3].HeaderText = "Nhà xuất bản";
            dgvSach.Columns[4].HeaderText = "Năm xuất bản";
            dgvSach.Columns[5].HeaderText = "Tác giả";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimKiemSach_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (dgvSach.Rows.Count == 0)
            {
                MessageBox.Show("Không có sách để chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            masach = dgvSach.Rows[dgvSach.CurrentCell.RowIndex].Cells[0].Value.ToString();
            tensach = dgvSach.Rows[dgvSach.CurrentCell.RowIndex].Cells[1].Value.ToString();
            this.Close();
        }
       
    }
}
