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
    public class PhieuNhap_BUS
    {
        //Phương thức trả về bảng
        public static DataTable GetAll()
        {
            return PhieuNhap_DAO.GetAll();
        }
        public static DataTable DanhSachNCC()
        {
            return PhieuNhap_DAO.DanhSachNCC();
        }
        //Phương thức thêm
        public static string Them(PHIEUNHAP_DTO obj)
        {
            return PhieuNhap_DAO.Them(obj);
        }
        //Phương thức sửa 
        public static string Sua(PHIEUNHAP_DTO obj)
        {
            return PhieuNhap_DAO.Sua(obj);
        }
        //Phương thức xóa
        public static string Xoa(PHIEUNHAP_DTO obj)
        {
            return PhieuNhap_DAO.Xoa(obj);
        }
        public static string XoaPhieuNhapKhongCoChiTiet()
        {
            return PhieuNhap_DAO.XoaPhieuNhapKhongCoChiTiet();
        }
    }
}
