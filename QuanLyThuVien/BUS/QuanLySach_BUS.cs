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
    public class QuanLySach_BUS
    {
        //Phương thức lấy toàn bộ sách trong csdl trả về bảng
        public static DataTable GetAll()
        {
            return QuanLySach_DAO.GetAll();
        }
        //Phương thức trả về bảng theo tìm kiếm
        public static DataTable GetSearch(SACH_DTO obj)
        {
            return QuanLySach_DAO.GetSearch(obj);
        }
        public static DataTable DanhSachLoaiSach()
        {
            return QuanLySach_DAO.DanhSachLoaiSach();
        }
        public static DataTable TimKiemSach(SACH_DTO obj)
        {
            return QuanLySach_DAO.TimKiemSach(obj);
        }
        //Phương thức thêm
        public static string Them(SACH_DTO obj)
        {
            return QuanLySach_DAO.Them(obj);
        }
        //Phương thức sửa 
        public static string Sua(SACH_DTO obj)
        {
            return QuanLySach_DAO.Sua(obj);
        }
        //Phương thức xóa
        public static string Xoa(SACH_DTO obj)
        {
            return QuanLySach_DAO.Xoa(obj);
        }
    }
}
