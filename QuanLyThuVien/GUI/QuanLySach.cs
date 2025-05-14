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

//tìm kiếm không phân biệt chữ hoa, chữ thường, không bắt buộc phải nhập hết tất cả các ô tìm kiếm --> hỗ trợ đơn & đa tìm kiếm
namespace GUI
{
    public partial class QuanLySach : Form //using System.Windows.Forms;
    {
        public QuanLySach()
        {
            InitializeComponent();
        }

        //Obj: là đối tượng chứa dữ liệu của một cuốn sách
        private SACH_DTO Obj = new SACH_DTO();

        void Load_Obj()
        {
            //Lấy dữ liệu từ các điều khiển trên form và gán vào Obj
            Obj.MaSach = txtMaSach.Text;
            Obj.TenSach = txtTenSach.Text;
            Obj.MaKe = cboMaKe.SelectedValue.ToString();
            Obj.NhaXuatBan = txtNhaXuatBan.Text;
            Obj.NamXuatBan = txtNamXuatBan.Text;
            Obj.TacGia = txtTacGia.Text;
            Obj.MaLoai = cboMaLoai.SelectedValue.ToString();
        }

        //Hàm ẩn hiện các txt, cmb
        void Enlable(bool a)
        {
            txtMaSach.ReadOnly = !a;//lúc hiển thị chỉ cho phép đọc không thể sửa
            txtTenSach.ReadOnly = !a;
            cboMaKe.Enabled = a;
            cboMaLoai .Enabled = a;
            txtNhaXuatBan.Enabled = a;
            txtNamXuatBan.Enabled = a;
            txtTacGia.Enabled = a;
            btnLuu.Enabled = a;
            btnKhongLuu.Enabled = a;
        }
        //Hàm hiển thị
        public void hienthi()
        {
            txtTenSachSearch.Text = "";
            Enlable(false);

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //Gọi BUS để lấy danh sách sách từ database, gán vào dgvSach (DataGridView).
            dgvSach.DataSource = QuanLySach_BUS.GetAll();
            //Thiết lập tên cột hiển thị-->có thể chỉnh trong edit
            dgvSach.Columns[0].HeaderText = "Mã sách";
            dgvSach.Columns[1].HeaderText = "Tên sách";
            dgvSach.Columns[2].HeaderText = "Mã kệ";
            dgvSach.Columns[3].HeaderText = "Nhà xuất bản";
            dgvSach.Columns[4].HeaderText = "Năm xuất bản";
            dgvSach.Columns[5].HeaderText = "Tác giả";
            dgvSach.Columns[6].HeaderText = "Mã loại sách";
            dgvSach.Columns[7].HeaderText = "Tên loại sách";
        }
        private void CboKeSach()
        {
            DataTable dataTable = new DataTable();
            cboMaKe.Items.Clear();
            ////Gọi BUS để lấy danh sách sách từ database, gán vào comboxKeSach
            dataTable = QuanLyKeSach_BUS.GetAll();
            cboMaKe.DataSource = dataTable;
            cboMaKe.DisplayMember = "LoaiSach";//show theo "LoaiSach"
            cboMaKe.ValueMember = "MaKe";//lấy giá trị lại là "MaKe"
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Enlable(true);
            btnSua.Enabled = false;//không cho phép sửa
            btnXoa.Enabled = false;//...............xóa
            txtMaSach.Text = ""; //xóa trắng các ô nhập liệu
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtNhaXuatBan.Text = "";
            txtNamXuatBan.Text = "";
            txtMaSach.Focus(); //tự động đưa con trỏ vào ô MaSach để nhập mà không cần dùng chuột
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Enlable(true);
            btnThem.Enabled = false; //không cho phép thêm
            btnXoa.Enabled = false;  //............... xóa
            txtMaSach.ReadOnly = true; //cho phép sửa mã sách
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn xóa sách này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Load_Obj();
                //Gọi hàm BUS.Xoa() để xóa sách. 
                if (QuanLySach_BUS.Xoa(Obj) == "Success")
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Không được bỏ trống mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSach.Focus();
                return;
            }
            
            if (txtTenSach.Text == "")
            {
                MessageBox.Show("Không được bỏ trống tên sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSach.Focus();
                return;
            }
            
            if (txtNamXuatBan.Text == "") //kiểm tra xem nếu nxb còn trống thì gán "0" vào
                txtNamXuatBan.Text = "0"; //đảm bảo quá trình lưu không bị lỗi.
            
            if (btnThem.Enabled == true)
            {
                Load_Obj(); // Lấy dữ liệu từ giao diện đưa vào đối tượng Obj
                string ketQua = QuanLySach_BUS.Them(Obj); // Gọi tầng BUS để thêm sách
                if (ketQua != "Success")
                {
                    MessageBox.Show("Đã tồn tại sách này, vui lòng tạo bằng mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Không làm gì nữa nếu thêm thất bại
                }
                hienthi(); // Thêm thành công thì cập nhật lại giao diện
                return; // Kết thúc xử lý
            }

            if (btnSua.Enabled == true)
            {
                Load_Obj(); // Lấy dữ liệu từ giao diện
                string ketQua = QuanLySach_BUS.Sua(Obj); // Gọi BUS để sửa thông tin
                if (ketQua != "Success")
                {
                    MessageBox.Show(ketQua, "Lỗi");
                }
                hienthi(); // Dù có lỗi hay không, vẫn cập nhật lại danh sách
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SACH_DTO obj = new SACH_DTO(); //Tạo đối tượng SACH_DTO chứa các giá trị nhập.
            obj.TenSach = txtTenSachSearch.Text;
            obj.TacGia = txtTacGiaSearch.Text;
            obj.MaLoai = txtTenLoaiSearch.Text;
            //Gửi đối tượng này vào hàm GetSearch() thuộc tầng BUS để tìm kiếm.
            //Hiển thị kết quả vào DataGridView
            dgvSach.DataSource = QuanLySach_BUS.GetSearch(obj);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            cboDanhSachLoai();
            CboKeSach();
            hienthi();
        }
        private void cboDanhSachLoai()
        {
            //Lấy danh sách loại sách từ tầng BUS, trả về dạng DataTable.
            DataTable dt = QuanLySach_BUS.DanhSachLoaiSach();
            cboMaLoai.DataSource = dt;
            cboMaLoai.DisplayMember = "TenLoai"; //hiển thị là "TenLoai"
            cboMaLoai.ValueMember = "MaLoai"; //lấy giá trị lại là "MaLoai"
        }

        //Khi người dùng chọn một dòng trong DataGridView
        //Lấy dữ liệu từ dòng đó
        //Hiển thị vào các ô nhập liệu tương ứng (textbox & combobox)
        private void dgvSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;//RowEnter là sự kiện xảy ra khi con trỏ bước vào dòng mới (chứ không phải click chọn).
            txtMaSach.Text = dgvSach.Rows[dong].Cells[0].Value.ToString();
            txtTenSach.Text = dgvSach.Rows[dong].Cells[1].Value.ToString();
            cboMaKe.SelectedValue = dgvSach.Rows[dong].Cells[2].Value.ToString();
            txtNhaXuatBan.Text = dgvSach.Rows[dong].Cells[3].Value.ToString();
            txtNamXuatBan.Text = dgvSach.Rows[dong].Cells[4].Value.ToString();
            txtTacGia.Text = dgvSach.Rows[dong].Cells[5].Value.ToString();
            cboMaLoai.SelectedValue = dgvSach.Rows[dong].Cells[6].Value.ToString();
        }

        //Giới hạn người dùng chỉ được nhập số vào ô
        //Các ký tự không phải số (0-9) hoặc không phải phím điều khiển (như Backspace, Delete...) đều bị chặn lại.
        private void txtNamXuatBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

    }
}
