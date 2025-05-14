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
    public class QuanLyKeSach_BUS
    {
        //Phương thức trả về bảng
        public static DataTable GetAll()
        {
            return QuanLyKeSach_DAO.GetAll();
        }
        //Phương thức trả về bảng theo tìm kiếm
        public static DataTable GetSearch(KESACH_DTO obj)
        {
            return QuanLyKeSach_DAO.GetSearch(obj);
        }
        //Phương thức thêm
        public static string Them(KESACH_DTO obj)
        {
            return QuanLyKeSach_DAO.Them(obj);
        }
        //Phương thức sửa 
        public static string Sua(KESACH_DTO obj)
        {
            return QuanLyKeSach_DAO.Sua(obj);
        }
        //Phương thức xóa
        public static string Xoa(KESACH_DTO obj)
        {
            return QuanLyKeSach_DAO.Xoa(obj);
        }
    }
}
