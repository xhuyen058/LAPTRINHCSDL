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
    public class PhieuMuon_BUS
    {
        //Phương thức trả về bảng
        public static DataTable GetAll()
        {
            return PhieuMuon_DAO.GetAll();
        }
        public static DataTable GetPhieuMuonCanTra()
        {
            return PhieuMuon_DAO.GetPhieuMuonCanTra();
        }
        public static DataTable XemPhieuMuon(string MaPM)
        {
            return PhieuMuon_DAO.XemPhieuMuon(MaPM);
        }
        public static DataTable XemChiTietPhieuMuon(string MaPM)
        {
            return PhieuMuon_DAO.XemChiTietPhieuMuon(MaPM);
        }
        //Phương thức thêm
        public static string Them(PHIEUMUON_DTO obj)
        {
            return PhieuMuon_DAO.Them(obj);
        }
        
        //Phương thức sửa 
        public static string Sua(PHIEUMUON_DTO obj)
        {
            return PhieuMuon_DAO.Sua(obj);
        }
        //Phương thức xóa
        public static string Xoa(PHIEUMUON_DTO obj)
        {
            return PhieuMuon_DAO.Xoa(obj);
        }
        public static string XoaPhieuMuonKhongCoChiTiet()
        {
            return PhieuMuon_DAO.XoaPHIEUMUONKhongCoChiTiet();
        }
    }
}
