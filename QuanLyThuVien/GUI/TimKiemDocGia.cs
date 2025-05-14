using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TimKiemDocGia : Form
    {
        public TimKiemDocGia()
        {
            InitializeComponent();
        }
        DOCGIA_DTO Obj = new DOCGIA_DTO();
        public static string madocgia;
        public static string tendocgia;
        void Load_Obj()
        {
            Obj.MaDocGia = txtMaDocGia.Text;
            Obj.TenDocGia = txtTenDocGia.Text;
            Obj.GioiTinh = txtGioiTinh.Text;
            Obj.DiaChi = txtDiaChi.Text;
            Obj.SDT = txtSDT.Text;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            hienthi();
        }
        public void hienthi()
        {
            Load_Obj();
            dgvDocGia.DataSource = QuanLyDocGia_BUS.TimKiemDocGia(Obj);
            dgvDocGia.Columns[0].HeaderText = "Mã độc giả";
            dgvDocGia.Columns[1].HeaderText = "Loại độc giả";
            dgvDocGia.Columns[2].HeaderText = "Tên độc giả";
            dgvDocGia.Columns[3].HeaderText = "Mã khoa";
            dgvDocGia.Columns[4].HeaderText = "Tên khoa";
            dgvDocGia.Columns[5].HeaderText = "Lớp";
            dgvDocGia.Columns[6].HeaderText = "Giới tính";
            dgvDocGia.Columns[7].HeaderText = "Ngày sinh";
            dgvDocGia.Columns[8].HeaderText = "Địa chỉ";
            dgvDocGia.Columns[9].HeaderText = "SĐT";
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimKiemDocGia_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (dgvDocGia.Rows.Count == 0)
            {
                MessageBox.Show("Không có độc giả để chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            madocgia = dgvDocGia.Rows[dgvDocGia.CurrentCell.RowIndex].Cells[0].Value.ToString();
            tendocgia = dgvDocGia.Rows[dgvDocGia.CurrentCell.RowIndex].Cells[2].Value.ToString();
            this.Close();
        }
    }
}
