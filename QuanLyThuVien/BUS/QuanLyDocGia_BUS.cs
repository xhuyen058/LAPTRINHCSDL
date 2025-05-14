using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuanLyDocGia_BUS
    {
        //Phương thức lấy tất cả dữ liệu bảng
        public static DataTable GetAll()
        {
            return QuanLyDocGia_DAO.GetAll();
        }
        //Phương thức trả về bảng theo tìm kiếm
        public static DataTable GetSearch(DOCGIA_DTO obj)
        {
            return QuanLyDocGia_DAO.GetSearch(obj);
        }
        //
        public static DataTable DanhSachKhoa()
        {
            return QuanLyDocGia_DAO.DanhSachKhoa();
        }
        //form TimKiemDocGia
        public static DataTable TimKiemDocGia(DOCGIA_DTO obj)
        {
            return QuanLyDocGia_DAO.TimKiemDocGia(obj);
        }
        //Phương thức thêm
        public static string Them(DOCGIA_DTO obj)
        {
            return QuanLyDocGia_DAO.Them(obj);
        }
        //Phương thức sửa 
        public static string Sua(DOCGIA_DTO obj)
        {
            return QuanLyDocGia_DAO.Sua(obj);
        }
        //Phương thức xóa
        public static string Xoa(DOCGIA_DTO obj)
        {
            return QuanLyDocGia_DAO.Xoa(obj);
        }
    }
}
