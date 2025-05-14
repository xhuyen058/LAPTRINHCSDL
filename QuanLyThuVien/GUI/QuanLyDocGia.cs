using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QuanLyDocGia : Form
    {
        public QuanLyDocGia()
        {
            InitializeComponent();
        }
        //Obj là đối tượng độc giả, dùng để chứa dữ liệu nhập vào để thêm/sửa.
        private DOCGIA_DTO Obj = new DOCGIA_DTO();
        //Nạp dữ liệu từ giao diện vào đối tượng Obj
        void Load_Obj()
        {
            //Gán giá trị từ các textbox/comboBox vào Obj để xử lý
            Obj.MaDocGia = txtMaDocGia.Text;
            Obj.LoaiDocGia = cboLoaiDocGia.Text;
            Obj.TenDocGia = txtTenDocGia.Text;
            Obj.MaKhoa = cboMaKhoa.SelectedValue.ToString();
            Obj.GioiTinh = cboGioiTinh.Text;
            Obj.Lop = txtLop.Text;
            Obj.NgaySinh = dtNgaySinh.Value.ToString("yyyyMMdd");
            Obj.DiaChi = txtDiaChi.Text;
            Obj.SDT = txtSDT.Text;    
        }
        //Hàm ẩn hiện các txt, cmb
        void Enlable(bool a)
        {
            txtMaDocGia.ReadOnly = !a;  //chỉ cho phép đọc
            txtTenDocGia.ReadOnly = !a; //chỉ cho phép đọc
            cboMaKhoa.Enabled = a;
            cboLoaiDocGia.Enabled = a;
            txtLop.ReadOnly = !a;       //chỉ cho phép đọc
            cboGioiTinh.Enabled = a;
            dtNgaySinh.Enabled = a;
            txtDiaChi.Enabled = a;
            txtSDT.Enabled = a;
            btnLuu.Enabled = a;
            btnKhongLuu.Enabled = a;
        }
        //Hàm hiển thị
        public void hienthi()
        {
            txtSearch.Text = ""; //Reset ô tìm kiếm về rỗng
            Enlable(false);      //Tắt quyền chỉnh sửa các ô nhập liệu
            //Đảm bảo sau khi hiển thị danh sách thì người dùng có thể sử dụng các nút Thêm, Sửa, Xóa.
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //Gọi hàm GetAll() trong tầng BUS(Business Layer), để lấy toàn bộ danh sách độc giả từ database.
            dgvDocGia.DataSource = QuanLyDocGia_BUS.GetAll();
            //Các tiêu đề này có thể chỉnh trong edit
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
        //sự kiện load nạp dữ liệu 1 lần duy nhất khi form được mở lên
        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            cboDanhSachKhoa();
            cboMaLoaiDocGia();
            CboGioiTinh();
            hienthi();
        }

        private void CboGioiTinh()
        {
            //dữ liệu tĩnh, ít thay đổi
            DataTable dataTable = new DataTable(); //Tạo một bảng dữ liệu trống để làm datasource (nguồn dữ liệu)
            cboGioiTinh.Items.Clear();
            dataTable.Columns.Add("GioiTinh", typeof(string)); //thêm cột giới tính
            dataTable.Rows.Add("Nam"); //dòng dữ liệu thứ nhất
            dataTable.Rows.Add("Nữ");  //dòng dữ liệu thứ hai
            cboGioiTinh.DataSource = dataTable; //Gán bảng làm nguồn dữ liệu cho ComboBox
            cboGioiTinh.DisplayMember = "GioiTinh"; //cột hiển thị
            cboGioiTinh.ValueMember = "GioiTinh";   //cột giá trị
        }
        private void cboMaLoaiDocGia()
        {
            //dữ liệu tĩnh, ít thay đổi
            DataTable dataTable = new DataTable(); //Tạo một bảng dữ liệu trống để làm datasource (nguồn dữ liệu)
            cboLoaiDocGia.Items.Clear();
            dataTable.Columns.Add("LoaiDocGia", typeof(string)); //thêm cột loại đọc giả
            dataTable.Rows.Add("Sinh viên");  //dòng dữ liệu thứ nhất
            dataTable.Rows.Add("Giảng viên"); //dòng dữ liệu thứ hai
            cboLoaiDocGia.DataSource = dataTable; //Gán bảng làm nguồn dữ liệu cho ComboBox
            cboLoaiDocGia.DisplayMember = "LoaiDocGia"; //cột hiển thị
            cboLoaiDocGia.ValueMember = "LoaiDocGia";   //cột giá trị
        }
        
        private void cboDanhSachKhoa()
        {
            //DL được lưu trong CSDL SQL Server -> Số lượng khoa có thể thay đổi, thêm mới -> cần gọi đến tầng BUS → DAL → DB để lấy dữ liệu thực tế
            DataTable dt = QuanLyDocGia_BUS.DanhSachKhoa();
            cboMaKhoa.DataSource = dt; //Gán bảng dữ liệu làm nguồn cho ComboBox
            cboMaKhoa.DisplayMember = "TenKhoa"; //cột hiển thị
            cboMaKhoa.ValueMember = "MaKhoa";    //cột giá trị
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            Enlable(true);
            //Vô hiệu hóa các nút (Sửa, Xóa)
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //Xóa trắng các ô nhập liệu
            txtMaDocGia.Text = "";
            txtTenDocGia.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtLop.Text = "";
            //Đưa con trỏ vào ô Mã độc giả để nhập ngay
            txtMaDocGia.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Enlable(true);
            //Vô hiệu hóa các nút (Thêm, Xóa)
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            //cho phép sửa "MaDocGia"
            txtMaDocGia.ReadOnly = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn xóa độc giả này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Load_Obj();
                if (QuanLyDocGia_BUS.Xoa(Obj) == "Success")
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
            if (txtMaDocGia.Text == "") //Nếu chưa nhập mã độc giả
            {
                //Hiển thị thông báo lỗi.
                MessageBox.Show("Không được bỏ trống mã độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //Đưa con trỏ trở lại ô txtMaDocGia
                txtMaDocGia.Focus();
                //Không tiếp tục thực hiện lưu (return).
                return;
            }

            if (txtTenDocGia.Text == "")
            {
                MessageBox.Show("Không được bỏ trống tên độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDocGia.Focus();
                return;
            }

            if (btnThem.Enabled == true) //khi người dùng đang thêm mới độc giả
            {
                Load_Obj(); // Gọi hàm gán dữ liệu từ các ô nhập vào biến Obj (đối tượng độc giả)
                string ketQua = QuanLyDocGia_BUS.Them(Obj); //Gửi dữ liệu đến tầng BUS để xử lý lưu xuống cơ sở dữ liệu
                if (ketQua != "Success") //Nếu không thành công (mã đã tồn tại), hiển thị thông báo lỗ
                {
                    MessageBox.Show("Đã tồn tại độc giả này, vui lòng tạo bằng mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //Không tiếp tục thực hiện
                }
                hienthi(); //Nếu thành công, gọi lại hàm hienthi() để cập nhật giao diện
                return; //Không tiếp tục thực hiện
            }

            if (btnSua.Enabled == true)
            {
                Load_Obj();
                string ketQua = QuanLyDocGia_BUS.Sua(Obj);
                if (ketQua != "Success")
                {
                    MessageBox.Show(ketQua, "Lỗi");
                }
                hienthi();
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //Tạo một đối tượng mới thuộc lớp đại diện cho dữ liệu độc giả (DTO)
            DOCGIA_DTO obj = new DOCGIA_DTO();
            //Gán giá trị người dùng nhập vào ô txtSearch vào thuộc tính TenDocGia của đối tượng obj
            obj.TenDocGia = txtSearch.Text;
            //Gọi hàm GetSearch() trong tầng BUS (Business Logic), truyền obj vào làm điều kiện tìm kiếm
            dgvDocGia.DataSource = QuanLyDocGia_BUS.GetSearch(obj);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Hàm này được gọi khi người dùng chọn một hàng trong DataGridView có tên dgvDocGia.
        //Nó có nhiệm vụ lấy thông tin của hàng đó và hiển thị lên các TextBox, ComboBox và DateTimePicker tương ứng trên giao diện.
        private void dgvDocGia_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaDocGia.Text = dgvDocGia.Rows[dong].Cells[0].Value.ToString();
            cboLoaiDocGia.Text = dgvDocGia.Rows[dong].Cells[1].Value.ToString();
            txtTenDocGia.Text = dgvDocGia.Rows[dong].Cells[2].Value.ToString();
            cboMaKhoa.SelectedValue = dgvDocGia.Rows[dong].Cells[3].Value.ToString();
            txtLop.Text = dgvDocGia.Rows[dong].Cells[5].Value.ToString();
            cboGioiTinh.Text = dgvDocGia.Rows[dong].Cells[6].Value.ToString();
            dtNgaySinh.Text = dgvDocGia.Rows[dong].Cells[7].Value.ToString();
            txtDiaChi.Text = dgvDocGia.Rows[dong].Cells[8].Value.ToString();
            txtSDT.Text = dgvDocGia.Rows[dong].Cells[9].Value.ToString();
        }
    }
}
