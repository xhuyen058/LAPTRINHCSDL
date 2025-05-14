using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BaoCao_DAO
    {
        public static DataTable GetAll(string Thang,string Nam)
        {
            string sql = " SELECT MONTH(NgayMuon),YEAR(NgayMuon),TenDocGia,TenSach,TrangThai,a.MaPM";
            sql += " FROM PHIEUMUON a INNER JOIN CHITIETMUON b ON a.MaPM = b.MaPM";
            sql += " INNER JOIN DOCGIA c ON a.MaDocGia = c.MaDocGia ";
            sql += " INNER JOIN SACH d ON b.MaSach = d.MaSach  WHERE MONTH(NgayMuon) like '%"+Thang+ "%' AND YEAR(NgayMuon) LIKE N'%"+Nam+"%'";
            return DataAccess.ThucThiQuery(sql);
        }
        public static DataTable GetTop5()
        {
            string sql = " SELECT TOP 5 TenSach,sum(soluong) AS SL FROM CHITIETMUON a INNER JOIN SACH b ON a.MaSach = b.MaSach GROUP BY TenSach order by SL desc";
            return DataAccess.ThucThiQuery(sql);
        }

        public static DataTable DanhSachPhieuMuonQuaHan(string d)
        {
            string sql = "SELECT a.MaPM,a.NgayMuon,a.MaDocGia,b.TenDocGia,a.NguoiLapPhieuMuon,GhiChu FROM PHIEUMUON a INNER JOIN DOCGIA b ON a.MaDocGia = b.MaDocGia WHERE DATEDIFF(day, NgayMuon, '"+d+ "') > 7 AND MaPM IN (SELECT MaPM FROM CHITIETMUON WHERE TrangThai = N'Đang Mượn')";
            return DataAccess.ThucThiQuery(sql);
        }
        public static DataTable DanhSachCTPhieuMuonQuaHan(string MaPM)
        {
            string sql = "select a.MaPM,a.MaSach,b.TenSach,SoLuong,NgayTra,TrangThai,NguoiLapPhieuTra,TinhTrangSachKhiMuon,TinhTrangSachKhiTra FROM CHITIETMUON a INNER JOIN SACH b ON a.MaSach = b.MaSach WHERE MaPM = '" + MaPM + "'";
            return DataAccess.ThucThiQuery(sql);
        }
        public static DataTable ThongKeSachTheoLoai()
        {
            string sql = "SELECT TenLoai,COUNT(a.MaLoai) FROM SACH a INNER JOIN LoaiSach b ON a.MaLoai = b.MaLoai GROUP BY TenLoai";
            return DataAccess.ThucThiQuery(sql);
        }
    }
}
