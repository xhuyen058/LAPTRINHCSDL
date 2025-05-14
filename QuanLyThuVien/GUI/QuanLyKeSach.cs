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
    public partial class QuanLyKeSach : Form
    {
        public QuanLyKeSach()
        {
            InitializeComponent();
        }

        //Tạo một đối tượng KESACH_DTO đại diện cho 1 kệ sách
        private KESACH_DTO Obj = new KESACH_DTO();
   
        void Load_Obj() //Gán dữ liệu từ các TextBox vào đối tượng Obj.
        {
            Obj.MaKe = txtMaKe.Text;
            Obj.ChatLieu = txtChatLieu.Text;
            Obj.SucChua = int.Parse(txtSucChua.Text);
            Obj.LoaiSach = txtLoaiSach.Text;    
        }

        //Hàm ẩn hiện các txt, cmb
        void Enlable(bool a)
        {
            txtMaKe.ReadOnly = !a;
            txtChatLieu.ReadOnly = !a;

            txtSucChua.Enabled = a;
            txtLoaiSach.Enabled = a;
            btnLuu.Enabled = a;
            btnKhongLuu.Enabled = a;
        }
        //Hàm hiển thị
        public void hienthi()
        {
            txtSearch.Text = ""; //xóa trống
            Enlable(false);      //vô hiệu hóa các nút được Enable ban đầu
            //khi hiển thị -> màn hình cho phép thêm sửa xóa dữ liệu theo mong muốn
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //gọi BUS.GetAll() để lấy tất cả kệ sách từ DB hiển thị lên DataGridView.
            dgvKeSach.DataSource = QuanLyKeSach_BUS.GetAll();
            //không cho phép người dùng chỉnh sửa trực tiếp lên lưới (thêm mới)
            dgvKeSach.AllowUserToAddRows = false;
        }
        private void QuanLyKeSach_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Enlable(true);
            //vô hiệu hóa xóa - sửa
            btnSua.Enabled = false; 
            btnXoa.Enabled = false;
            //xóa trống 
            txtMaKe.Text = ""; 
            txtChatLieu.Text = "";
            txtSucChua.Text = "";
            txtLoaiSach.Text = "";
            //đưa con trỏ chuột vào MaKe
            txtMaKe.Focus(); 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //kích hoạt cho các nút được enable ban đầu
            Enlable(true);
            //vô hiệu hóa xóa - thêm
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            //cho phép sửa MaKe
            txtMaKe.ReadOnly = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn xóa kệ sách này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Load_Obj();
                if (QuanLyKeSach_BUS.Xoa(Obj) == "Success") //gọi BUS.Xoa()
                {
                    hienthi(); //Nếu xóa thành công thì reload dữ liệu
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
            if (txtMaKe.Text == "") //nếu bỏ trống
            {
                MessageBox.Show("Không được bỏ trống kệ sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKe.Focus();
                return;
            }
            
            if (txtSucChua.Text == "") //nếu bỏ trống
                txtSucChua.Text = "0"; //tự động gán bằng "0" để tránh gián đoạn ct
            
            if (btnThem.Enabled == true)
            {
                Load_Obj(); // Lấy dữ liệu từ các textbox đưa vào đối tượng Obj
                string ketQua = QuanLyKeSach_BUS.Them(Obj); //gọi BUS.Them()
                if (ketQua != "Success")
                {
                    MessageBox.Show("Đã tồn tại kệ sách này, vui lòng tạo bằng mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                hienthi(); //gọi lại hienthi() để làm mới form và load lại danh sách kệ sách.
                return;
            }
            
            if (btnSua.Enabled == true)
            {
                Load_Obj(); // Lấy dữ liệu từ các textbox đưa vào đối tượng Obj
                string ketQua = QuanLyKeSach_BUS.Sua(Obj); //gọi BUS.Sua()
                if (ketQua != "Success")
                {
                    MessageBox.Show(ketQua, "Lỗi");
                }
                hienthi(); //gọi lại hienthi() để làm mới form và load lại danh sách kệ sách.
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //Tạo một đối tượng mới thuộc lớp đại diện cho dữ liệu kệ sách (DTO)
            KESACH_DTO obj = new KESACH_DTO();
            //Gán giá trị người dùng nhập vào ô txtSearch vào thuộc tính MaKe của đối tượng obj
            obj.MaKe = txtSearch.Text;
            //Gọi hàm GetSearch() trong tầng BUS truyền obj vào làm điều kiện tìm kiếm
            dgvKeSach.DataSource = QuanLyKeSach_BUS.GetSearch(obj);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Gán dữ liệu từ DataGridView vào TextBox
        private void dgvKeSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong < 0 || dong >= dgvKeSach.Rows.Count) return;

            txtMaKe.Text = dgvKeSach.Rows[dong].Cells["MaKe"].Value?.ToString() ?? "";
            txtChatLieu.Text = dgvKeSach.Rows[dong].Cells["ChatLieu"].Value?.ToString() ?? "";
            txtSucChua.Text = dgvKeSach.Rows[dong].Cells["SucChua"].Value?.ToString() ?? "";
            txtLoaiSach.Text = dgvKeSach.Rows[dong].Cells["LoaiSach"].Value?.ToString() ?? "";
        }

        //Ràng buộc chỉ cho nhập số
        private void txtSucChua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //Sự kiện CellClick (giống RowEnter)
        private void dgvKeSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong < 0 || dong >= dgvKeSach.Rows.Count) return;

            // Kiểm tra null từng cell
            txtMaKe.Text = dgvKeSach.Rows[dong].Cells["MaKe"].Value?.ToString() ?? "";
            txtChatLieu.Text = dgvKeSach.Rows[dong].Cells["ChatLieu"].Value?.ToString() ?? "";
            txtSucChua.Text = dgvKeSach.Rows[dong].Cells["SucChua"].Value?.ToString() ?? "";
            txtLoaiSach.Text = dgvKeSach.Rows[dong].Cells["LoaiSach"].Value?.ToString() ?? "";
        }
    }
}
