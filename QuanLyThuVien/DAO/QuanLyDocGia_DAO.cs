using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//PHI KẾT NỐI
namespace DAO
{
    public class QuanLyDocGia_DAO
    {
        //Phương thức lấy danh sách dữ liệu của database
        public static DataTable GetAll()
        {
            string sql = "select MaDocGia,LoaiDocGia,TenDocGia,a.MaKhoa,TenKhoa,Lop,GioiTinh,NgaySinh,DiaChi,SDT FROM DOCGIA a INNER JOIN Khoa b ON a.MaKhoa = b.MaKhoa";
            return DataAccess.ThucThiQuery(sql);
        }
        //Phương thức tìm kiếm
        public static DataTable GetSearch(DOCGIA_DTO obj)
        {
            //sử dụng điều kiện LIKE để tìm những tên chứa chuỗi được nhập (%tên%) -> nhập "Anh" sẽ khớp với "Anh Nhi", "Anh Dũng"
            string sql = "select MaDocGia,LoaiDocGia,TenDocGia,a.MaKhoa,TenKhoa,Lop,GioiTinh,NgaySinh,DiaChi,SDT FROM DOCGIA a INNER JOIN Khoa b ON a.MaKhoa = b.MaKhoa WHERE TenDocGia LIKE N'%" + obj.TenDocGia + "%'";
            return DataAccess.ThucThiQuery(sql);
        }
        //Form TimKiemDocGia->Tìm kiếm nâng cao_lọc dữ liệu theo nhiều tiêu chí->tất cả đều dùng LIKE để hỗ trợ tìm gần đúng
        public static DataTable TimKiemDocGia(DOCGIA_DTO obj)
        {
            string sql = "select MaDocGia,LoaiDocGia,TenDocGia,a.MaKhoa,TenKhoa,Lop,GioiTinh,NgaySinh,DiaChi,SDT FROM DOCGIA a INNER JOIN Khoa b ON a.MaKhoa = b.MaKhoa WHERE MaDocGia LIKE N'%" + obj.MaDocGia + "%' AND TenDocGia LIKE N'%" + obj.TenDocGia + "%' AND GioiTinh LIKE N'%" + obj.GioiTinh + "%' AND DiaChi LIKE N'%" + obj.DiaChi + "%' AND SDT LIKE N'%" + obj.SDT.ToString() + "%'";
            return DataAccess.ThucThiQuery(sql);
        }
        //Lấy toàn bộ dữ liệu trong bảng Khoa -> hiển thị lên combobox
        public static DataTable DanhSachKhoa()
        {
            string sql = "select * FROM Khoa";
            return DataAccess.ThucThiQuery(sql);
        }
        //Phương thức thêm 
        public static string Them(DOCGIA_DTO obj)
        {
            string sql = "insert into DOCGIA values (N'" + obj.MaDocGia + "',N'"+obj.LoaiDocGia + "',N'" + obj.TenDocGia + "','"+obj.MaKhoa+"',N'"+obj.Lop + "',N'" + obj.GioiTinh + "','" + obj.NgaySinh + "',N'"+ obj.DiaChi + "',N'"+ obj.SDT + "')";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Phương thức sửa 
        public static string Sua(DOCGIA_DTO obj)
        {
            string sql = "update DOCGIA set TenDocGia=N'" + obj.TenDocGia + "',GioiTinh = N'" + obj.GioiTinh + "',NgaySinh = '"+ obj.NgaySinh + "',DiaChi = '"+obj.DiaChi + "',SDT = '"+obj.SDT + "',LoaiDocGia = N'"+obj.LoaiDocGia + "',MaKhoa = '"+obj.MaKhoa + "',Lop = '"+obj.Lop + "' where  MaDocGia=N'" + obj.MaDocGia + "'";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Phương thức xóa
        public static string Xoa(DOCGIA_DTO obj)
        {
            string sql = string.Format("DELETE DOCGIA WHERE MaDocGia = N'{0}'", obj.MaDocGia);
            return DataAccess.ThucThiNonQuery(sql);
        }
    }
}
