using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuanLyKeSach_DAO
    {
        //Lấy danh sách dữ liệu của database
        public static DataTable GetAll()
        {
            string sql = "select * FROM KESACH";
            return DataAccess.ThucThiQuery(sql);
        }
        //Phương thức tìm kiếm -> dùng LIKE để hỗ trợ tìm gần đúng
        public static DataTable GetSearch(KESACH_DTO obj)
        {
            string sql = "select * FROM KESACH WHERE MaKe LIKE '%" + obj.MaKe + "%'";
            return DataAccess.ThucThiQuery(sql);
        }
        //Phương thức thêm 
        public static string Them(KESACH_DTO obj)
        {
            string sql = "insert into KESACH values (N'" + obj.MaKe + "',N'" + obj.ChatLieu + "'," + obj.SucChua + ",N'"+ obj.LoaiSach + "')";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Phương thức sửa 
        public static string Sua(KESACH_DTO obj)
        {
            string sql = "update KESACH set ChatLieu=N'" + obj.ChatLieu + "',SucChua=" + obj.SucChua + ",LoaiSach = N'"+obj.LoaiSach + "' where  MaKe=N'" + obj.MaKe + "'";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Phương thức xóa
        public static string Xoa(KESACH_DTO obj)
        {
            string sql = string.Format("DELETE KESACH WHERE MaKe = N'{0}'", obj.MaKe);
            return DataAccess.ThucThiNonQuery(sql);
        }
    }
}
