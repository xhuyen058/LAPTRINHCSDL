using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class QuanLyTaiKhoan_DAO
    {
        public static bool DangNhap(NGUOIDUNG_DTO obj)
        {
            string sql = "select * from NGUOIDUNG where TaiKhoan='"+obj.TaiKhoan+"' and MatKhau='"+obj.MatKhau+"'";
            if (DataAccess.ExcuteReader_bool(sql) == true)
                return true;
            else
                return false;
        }
        public static DataTable MaQuyen(NGUOIDUNG_DTO obj)
        {
            string sql = "SELECT MaQuyen FROM NGUOIDUNG WHERE TaiKhoan = '" + obj.TaiKhoan+ "'";
            return DataAccess.ThucThiQuery(sql);
        }
        public static DataTable DoiMatKhau(NGUOIDUNG_DTO obj)
        {
            string sql = "UPDATE NGUOIDUNG SET MatKhau = '"+obj.MatKhau+"' WHERE TaiKhoan = '" + obj.TaiKhoan + "'";
            return DataAccess.ThucThiQuery(sql);
        }
        public static DataTable GetAll()
        {
            string sql = "select * FROM NGUOIDUNG";
            return DataAccess.ThucThiQuery(sql);
        }
        public static DataTable GetSearch(NGUOIDUNG_DTO obj)
        {
            string sql = "select * FROM NGUOIDUNG WHERE TaiKhoan LIKE '%"+obj.TaiKhoan+"%'";
            return DataAccess.ThucThiQuery(sql);
        }
        //Phương thức thêm 
        public static string Them(NGUOIDUNG_DTO obj)
        {
            string sql = "insert into NGUOIDUNG values (N'" + obj.TaiKhoan + "',N'" + obj.MatKhau + "',N'" + obj.MaQuyen + "')";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Phương thức sửa 
        public static string Sua(NGUOIDUNG_DTO obj)
        {
            string sql = "update NGUOIDUNG set MatKhau=N'" + obj.MatKhau + "',MaQuyen=N'" + obj.MaQuyen + "' where  TaiKhoan=N'" + obj.TaiKhoan + "'";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Phương thức xóa
        public static string Xoa(NGUOIDUNG_DTO obj)
        {
            string sql = string.Format("DELETE NGUOIDUNG WHERE TaiKhoan = N'{0}'", obj.TaiKhoan);
            return DataAccess.ThucThiNonQuery(sql);
        }
    }
}

