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
    public class ChiTietMuon_BUS
    {
        //Phương thức trả về bảng
        public static DataTable GetAll(CHITIETMUON_DTO obj)
        {
            return ChiTietMuon_DAO.GetAll(obj);
        }
        //Phương thức thêm
        public static string Them(CHITIETMUON_DTO obj)
        {
            return ChiTietMuon_DAO.Them(obj);
        }
        public static string Sua(CHITIETMUON_DTO obj)
        {
            return ChiTietMuon_DAO.Sua(obj);
        }
        //Phương thức xóa
        public static string Xoa(CHITIETMUON_DTO obj)
        {
            return ChiTietMuon_DAO.Xoa(obj);
        }
        public static string TraSach(CHITIETMUON_DTO obj)
        {
            return ChiTietMuon_DAO.TraSach(obj);
        }
    }
}
