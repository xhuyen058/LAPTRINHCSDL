using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietMuon_DAO
    {
        public static DataTable GetAll(CHITIETMUON_DTO obj)
        {
            string sql = "select a.MaPM,a.MaSach,b.TenSach,SoLuong,NgayTra,TrangThai,NguoiLapPhieuTra,TinhTrangSachKhiMuon,TinhTrangSachKhiTra FROM CHITIETMUON a INNER JOIN SACH b ON a.MaSach = b.MaSach WHERE MaPM = '" + obj.MaPM + "'";
            return DataAccess.ThucThiQuery(sql);
        }
        //Phương thức thêm 
        public static string Them(CHITIETMUON_DTO obj)
        {
            string sql = "insert into CHITIETMUON values ('" + obj.MaPM + "','" + obj.MaSach + "'," + obj.SoLuong + ",NULL,N'Đang Mượn',NULL,N'"+obj.TinhTrangSachKhiMuon+"',NULL)";
            return DataAccess.ThucThiNonQuery(sql);
        }
        public static string Sua(CHITIETMUON_DTO obj)
        {
            string sql = "update CHITIETMUON set SoLuong=" + obj.SoLuong + " where  MaSach=N'" + obj.MaSach + "' AND MaPM = '" + obj.MaPM + "'";
            return DataAccess.ThucThiNonQuery(sql);
        }
        //Phương thức xóa
        public static string Xoa(CHITIETMUON_DTO obj)
        {
            string sql = "DELETE CHITIETMUON WHERE MaPM = '" + obj.MaPM + "' AND MaSach = '" + obj.MaSach + "'";
            return DataAccess.ThucThiNonQuery(sql);
        }
        public static string TraSach(CHITIETMUON_DTO obj)
        {
            string sql = "update CHITIETMUON set NgayTra = '"+obj.NgayTra+ "',TrangThai = N'"+obj.TrangThai+ "',NguoiLapPhieuTra = '"+obj.NguoiLapPhieuTra + "',TinhTrangSachKhiTra = N'"+obj.TinhTrangSachKhiTra+"'  where  MaPM=N'" + obj.MaPM + "' AND MaSach = '"+obj.MaSach+"'";
            return DataAccess.ThucThiNonQuery(sql);
        }
    }
}
