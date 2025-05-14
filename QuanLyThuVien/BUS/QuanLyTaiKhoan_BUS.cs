using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class QuanLyTaiKhoan_BUS
    {

        public static bool DangNhap(NGUOIDUNG_DTO obj)
        {
            return QuanLyTaiKhoan_DAO.DangNhap(obj);
        }
        public static DataTable DoiMatKhau(NGUOIDUNG_DTO obj)
        {
            return QuanLyTaiKhoan_DAO.DoiMatKhau(obj);
        }
        public static DataTable MaQuyen(NGUOIDUNG_DTO obj)
        {
            return QuanLyTaiKhoan_DAO.MaQuyen(obj);
        }
        //Phương thức trả về bảng
        public static DataTable GetAll()
        {
            return QuanLyTaiKhoan_DAO.GetAll();
        }
        //Phương thức trả về bảng theo tìm kiếm
        public static DataTable GetSearch(NGUOIDUNG_DTO obj)
        {
            return QuanLyTaiKhoan_DAO.GetSearch(obj);
        }
        //Phương thức thêm
        public static string Them(NGUOIDUNG_DTO obj)
        {
            return QuanLyTaiKhoan_DAO.Them(obj);
        }
        //Phương thức sửa 
        public static string Sua(NGUOIDUNG_DTO obj)
        {
            return QuanLyTaiKhoan_DAO.Sua(obj);
        }
        //Phương thức xóa
        public static string Xoa(NGUOIDUNG_DTO obj)
        {
            return QuanLyTaiKhoan_DAO.Xoa(obj);
        }
    }
}
