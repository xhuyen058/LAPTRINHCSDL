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
    public class ChiTietNhap_BUS
    {
        //Phương thức trả về bảng
        public static DataTable GetAll(CHITIETNHAP_DTO obj)
        {
            return ChiTietNhap_DAO.GetAll(obj);
        }
        //Phương thức thêm
        public static string Them(CHITIETNHAP_DTO obj)
        {
            return ChiTietNhap_DAO.Them(obj);
        }
        public static string Sua(CHITIETNHAP_DTO obj)
        {
            return ChiTietNhap_DAO.Sua(obj);
        }
        //Phương thức xóa
        public static string Xoa(CHITIETNHAP_DTO obj)
        {
            return ChiTietNhap_DAO.Xoa(obj);
        }
    }
}
