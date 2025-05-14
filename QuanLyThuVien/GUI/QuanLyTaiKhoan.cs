using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class QuanLyTaiKhoan : Form
    {

        private NGUOIDUNG_DTO Obj_Qltk = new NGUOIDUNG_DTO();
        void Load_Obj()
        {
            Obj_Qltk.TaiKhoan = txtTaiKhoan.Text;
            Obj_Qltk.MatKhau = txtMatKhau.Text;
            Obj_Qltk.MaQuyen = cboQuyen.Text;
        }

        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        //Hàm ẩn hiện các txt, cmb
        void Enlable(bool a)
        {
            txtTaiKhoan.ReadOnly = !a;
            txtMatKhau.ReadOnly = !a;

            cboQuyen.Enabled = a;
            btnLuu.Enabled = a;
            btnKhongLuu.Enabled = a;
        }
        //Hàm hiển thị
        public void hienthi()
        {
            txtSearch.Text = "";
            Enlable(false);

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            dgvTaiKhoan.DataSource = QuanLyTaiKhoan_BUS.GetAll();
            this.dgvTaiKhoan.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void CboQuyen()
        {
            DataTable dataTable = new DataTable();
            cboQuyen.Items.Clear();
            dataTable.Columns.Add("MaQuyen", typeof(string));
            dataTable.Rows.Add("Quản trị viên");
            dataTable.Rows.Add("Nhân viên");
            cboQuyen.DataSource = dataTable;
            cboQuyen.DisplayMember = "MaQuyen";
            cboQuyen.ValueMember = "MaQuyen";
        }
        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            CboQuyen();
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvTaiKhoan.Rows[dgvTaiKhoan.CurrentCell.RowIndex].Cells[0].Value.ToString() == "ADMIN")
            {
                MessageBox.Show("Không được xóa tài khoản admin mặc định!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            if (txtTaiKhoan.Text == DangNhap.taiKhoan)
            {
                MessageBox.Show("Bạn không thể xóa chính mình được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            else
                if (MessageBox.Show("Bạn thực sự muốn xóa tài khoản này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Load_Obj();
                if (QuanLyTaiKhoan_BUS.Xoa(Obj_Qltk) == "Success")
                {
                    hienthi();
                }
                else
                {
                    MessageBox.Show("Dữ liệu đã phát sinh khóa ngoại ở bảng khác, không xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }    
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Enlable(true);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtTaiKhoan.Focus();
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Enlable(true);
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtTaiKhoan.ReadOnly = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Không được bỏ trống tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Không được bỏ trống mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            if (btnThem.Enabled == true)
            {
                Load_Obj();
                string ketQua = QuanLyTaiKhoan_BUS.Them(Obj_Qltk);
                if (ketQua != "Success")
                {
                    MessageBox.Show("Đã tồn tại tài khoản này, vui lòng tạo bằng mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                hienthi();
                return;
            }
            if (btnSua.Enabled == true)
            {
                Load_Obj();
                string ketQua = QuanLyTaiKhoan_BUS.Sua(Obj_Qltk);
                if (ketQua != "Success")
                {
                    MessageBox.Show(ketQua, "Lỗi");
                }
                hienthi();
            }
        }

        private void dgvTaiKhoan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtTaiKhoan.Text = dgvTaiKhoan.Rows[dong].Cells[0].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoan.Rows[dong].Cells[1].Value.ToString();
            cboQuyen.Text = dgvTaiKhoan.Rows[dong].Cells[2].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            NGUOIDUNG_DTO obj = new NGUOIDUNG_DTO();
            obj.TaiKhoan = txtSearch.Text;
            dgvTaiKhoan.DataSource = QuanLyTaiKhoan_BUS.GetSearch(obj);
        }

        private void cboQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

