using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuMuon_DAO
    {
        public static DataTable GetAll()
        {
            string sql = "SELECT a.MaPM,a.NgayMuon,a.MaDocGia,b.TenDocGia,a.NguoiLapPhieuMuon,GhiChu FROM PHIEUMUON a INNER JOIN DOCGIA b ON a.MaDocGia = b.MaDocGia";
            return DataAccess.ThucThiQuery(sql);
        }
        public static DataTable GetPhieuMuonCanTra()
        {
            string sql = "SELECT a.MaPM,a.NgayMuon,a.MaDocGia,b.TenDocGia,a.NguoiLapPhieuMuon,GhiChu FROM PHIEUMUON a INNER JOIN DOCGIA b ON a.MaDocGia = b.MaDocGia WHERE MaPM IN (SELECT MaPM FROM CHITIETMUON WHERE TrangThai = N'Đang mượn')";
            return DataAccess.ThucThiQuery(sql);
        }
        public static DataTable XemPhieuMuon(string MaPM)
        {
            string sql = "SELECT a.MaPM,a.NgayMuon,a.MaDocGia,b.TenDocGia,a.NguoiLapPhieuMuon,GhiChu FROM PHIEUMUON a INNER JOIN DOCGIA b ON a.MaDocGia = b.MaDocGia WHERE a.MaPM = '"+ MaPM + "'";
            return DataAccess.ThucThiQuery(sql);
        }
        public static DataTable XemChiTietPhieuMuon(string MaPM)
        {
            string sql = "select a.MaPM,a.MaSach,b.TenSach,SoLuong,NgayTra,TrangThai,NguoiLapPhieuTra,TinhTrangSachKhiMuon,TinhTrangSachKhiTra FROM CHITIETMUON a INNER JOIN SACH b ON a.MaSach = b.MaSach WHERE MaPM = '" +MaPM + "'";
            return DataAccess.ThucThiQuery(sql);
        }
        //Phương thức thêm 
        public static string Them(PHIEUMUON_DTO obj)
        {
            string sql = "insert into PHIEUMUON(MaPM,NgayMuon,NguoiLapPhieuMuon,MaDocGia,GhiChu) values ('" + obj.MaPM + "','" + obj.NgayMuon + "',N'" + obj.NguoiLapPhieuMuon + "','" + obj.MaDocGia + "',N'"+obj.GhiChu + "')";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Phương thức sửa 
        public static string Sua(PHIEUMUON_DTO obj)
        {
            string sql = "update PHIEUMUON set NgayMuon='" + obj.NgayMuon + "',NguoiLapPhieuMuon=N'" + obj.NguoiLapPhieuMuon + "',MaDocGia = N'" + obj.MaDocGia + "',GhiChu = N'" + obj.GhiChu + "' where  MaPM=N'" + obj.MaPM + "'";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Phương thức xóa
        public static string Xoa(PHIEUMUON_DTO obj)
        {
            string sql = "DELETE CHITIETMUON WHERE MaPM = '" + obj.MaPM + "' DELETE PHIEUMUON WHERE MaPM = '" + obj.MaPM + "' ";
            return DataAccess.ThucThiNonQuery(sql);
        }
        public static string XoaPHIEUMUONKhongCoChiTiet()
        {
            string sql = "DELETE PHIEUMUON WHERE MaPM NOT IN (SELECT MaPM FROM CHITIETMUON) ";
            return DataAccess.ThucThiNonQuery(sql);
        }
    }
}
