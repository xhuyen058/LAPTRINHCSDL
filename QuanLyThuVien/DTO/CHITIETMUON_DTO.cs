using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CHITIETMUON_DTO
    {
        private string _maPM;
        private string _maSach;
        private int _soLuong;
        private string _ngayTra;
        private string _trangThai;
        private string _nguoiLapPhieuTra;
        private string _tinhTrangSachKhiMuon;
        private string _tinhTrangSachKhiTra;

        public string MaPM
        {
            get { return _maPM; }
            set { _maPM = value; }
        }
        public string MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }
        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        public string NgayTra
        {
            get { return _ngayTra; }
            set { _ngayTra = value; }
        }

        public string TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }


        public string NguoiLapPhieuTra
        {
            get { return _nguoiLapPhieuTra; }
            set { _nguoiLapPhieuTra = value; }
        }
        public string TinhTrangSachKhiMuon
        {
            get { return _tinhTrangSachKhiMuon; }
            set { _tinhTrangSachKhiMuon = value; }
        }
        public string TinhTrangSachKhiTra
        {
            get { return _tinhTrangSachKhiTra; }
            set { _tinhTrangSachKhiTra = value; }
        }
    }
}
