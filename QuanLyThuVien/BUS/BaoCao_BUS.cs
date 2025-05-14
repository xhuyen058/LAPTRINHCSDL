using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BaoCao_BUS
    {
        public static DataTable GetAll(string Thang,string Nam)
        {
            return BaoCao_DAO.GetAll(Thang, Nam);
        }
        public static DataTable GetTop5()
        {
            return BaoCao_DAO.GetTop5();
        }
        public static DataTable DanhSachPhieuMuonQuaHan(string d)
        {
            return BaoCao_DAO.DanhSachPhieuMuonQuaHan(d);
        }
        public static DataTable DanhSachCTPhieuMuonQuaHan(string MaPM)
        {
            return BaoCao_DAO.DanhSachCTPhieuMuonQuaHan(MaPM);
        }
        public static DataTable ThongKeSachTheoLoai()
        {
            return BaoCao_DAO.ThongKeSachTheoLoai();
        }
    }
}
