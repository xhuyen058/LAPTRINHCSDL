using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuanLySach_DAO
    {
        //lấy tất cả danh sách
        public static DataTable GetAll()
        {
            //Truy vấn kết hợp bảng SACH với bảng LoaiSach để lấy thêm tên loại sách (TenLoai
            string sql = "select a.*,b.TenLoai FROM SACH a INNER JOIN LoaiSach b ON a.MaLoai = b.MaLoai";
            return DataAccess.ThucThiQuery(sql);
        }
        //Tìm kiếm
        public static DataTable GetSearch(SACH_DTO obj)
        {
            //Dùng LIKE để cho phép tìm kiếm một phần nội dung.
            string sql = "select a.*,b.TenLoai FROM SACH a INNER JOIN LoaiSach b ON a.MaLoai = b.MaLoai WHERE TenSach LIKE N'%" + obj.TenSach + "%' AND TenLoai LIKE N'%"+obj.MaLoai+"%' AND TacGia LIKE N'%"+obj.TacGia+"%'";
            return DataAccess.ThucThiQuery(sql);
        }
        //Mở rộng tìm kiếm nhiều trường hơn
        public static DataTable TimKiemSach(SACH_DTO obj)
        {
            string sql = "select * FROM SACH WHERE MaSach LIKE N'%" + obj.MaSach + "%' AND TenSach LIKE N'%"+ obj.TenSach + "%' AND MaKe LIKE N'%"+ obj.MaKe + "%' AND NhaXuatBan LIKE N'%"+ obj.NhaXuatBan + "%' AND NamXuatBan LIKE N'%"+ obj.NamXuatBan.ToString() + "%' AND TacGia LIKE N'%"+ obj.TacGia + "%'";
            return DataAccess.ThucThiQuery(sql);
        }
        //Lấy danh sách loại sách
        public static DataTable DanhSachLoaiSach()
        {
            string sql = "select * FROM LoaiSach";
            return DataAccess.ThucThiQuery(sql);
        }
        //Phương thức thêm 
        public static string Them(SACH_DTO obj)
        {
            string sql = "insert into SACH values (N'" + obj.MaSach + "',N'" + obj.TenSach + "',N'" + obj.MaKe + "',N'" + obj.NhaXuatBan + "'," + obj.NamXuatBan + ",N'" + obj.TacGia + "','"+obj.MaLoai+"')";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Phương thức sửa 
        public static string Sua(SACH_DTO obj)
        {
            string sql = "update SACH set TenSach=N'" + obj.TenSach + "',MaKe = N'" + obj.MaKe + "',NhaXuatBan = N'" + obj.NhaXuatBan + "',NamXuatBan = " + obj.NamXuatBan + ",TacGia = N'" + obj.TacGia + "',MaLoai = '"+obj.MaLoai+"' where  MaSACH=N'" + obj.MaSach + "'";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Phương thức xóa
        public static string Xoa(SACH_DTO obj)
        {
            string sql = string.Format("DELETE SACH WHERE MaSACH = N'{0}'", obj.MaSach);
            return DataAccess.ThucThiNonQuery(sql);
        }
    }
}
