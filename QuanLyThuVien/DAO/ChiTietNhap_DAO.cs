using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietNhap_DAO
    {
        public static DataTable GetAll(CHITIETNHAP_DTO obj)
        {
            string sql = "select MaPN,a.MaSach,b.TenSach,a.MaNCC,c.TenNCC,SoLuong FROM CHITIETNHAP a INNER JOIN SACH b ON a.MaSach = b.MaSach INNER JOIN NhaCungCap c ON a.MaNCC = c.MaNCC WHERE MaPN = '" + obj.MaPN+"'";
            return DataAccess.ThucThiQuery(sql);
        }
        //Phương thức thêm 
        public static string Them(CHITIETNHAP_DTO obj)
        {
            string sql = "insert into CHITIETNHAP values ('" + obj.MaPN + "','" + obj.MaSach + "','"+obj.MaNCC+"'," + obj.SoLuong + ")";
            return DataAccess.ThucThiNonQuery(sql);
        }
        public static string Sua(CHITIETNHAP_DTO obj)
        {
            string sql = "update CHITIETNHAP set SoLuong=" + obj.SoLuong + ", MaNCC = '"+obj.MaNCC+"' where  MaPN=N'" + obj.MaPN + "' AND MaSach = '"+obj.MaSach+"'";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Phương thức xóa
        public static string Xoa(CHITIETNHAP_DTO obj)
        {
            string sql = "DELETE CHITIETNHAP WHERE MaPN = '"+obj.MaPN+ "' AND MaSach = '"+obj.MaSach+"'";
            return DataAccess.ThucThiNonQuery(sql);
        }
    }
}
