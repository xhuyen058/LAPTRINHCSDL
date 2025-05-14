using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuNhap_DAO
    {
        public static DataTable GetAll()
        {
            string sql = "select * FROM PHIEUNHAP";
            return DataAccess.ThucThiQuery(sql);
        }
        public static DataTable DanhSachNCC()
        {
            string sql = "select * FROM NhaCungCap";
            return DataAccess.ThucThiQuery(sql);
        }
        //Phương thức thêm 
        public static string Them(PHIEUNHAP_DTO obj)
        {
            string sql = "insert into PHIEUNHAP values ('" + obj.MaPN + "','" + obj.NgayLap + "',N'" + obj.GhiChu + "','"+ obj.NguoiLap + "')";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Phương thức sửa 
        public static string Sua(PHIEUNHAP_DTO obj)
        {
            string sql = "update PHIEUNHAP set NgayLap='" + obj.NgayLap + "',GhiChu = N'" + obj.GhiChu + "',NguoiLap = '"+ obj.NguoiLap + "' where  MaPN=N'" + obj.MaPN + "'";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Phương thức xóa
        public static string Xoa(PHIEUNHAP_DTO obj)
        {
            string sql = "DELETE CHITIETNHAP WHERE MaPN = '" + obj.MaPN+"' DELETE PHIEUNHAP WHERE MaPN = '" + obj.MaPN+"' ";
            return DataAccess.ThucThiNonQuery(sql);
        }
        public static string XoaPhieuNhapKhongCoChiTiet()
        {
            string sql = "DELETE PHIEUNHAP WHERE MaPN NOT IN (SELECT MaPN FROM CHITIETNHAP) ";
            return DataAccess.ThucThiNonQuery(sql);
        }
    }
}
