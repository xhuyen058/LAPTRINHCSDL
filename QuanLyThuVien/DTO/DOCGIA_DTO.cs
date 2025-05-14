using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DOCGIA_DTO
    {
        private string _maDocGia;
        private string _loaiDocGia;
        private string _tenDocGia;
        private string _maKhoa;
        private string _lop;
        private string _gioiTinh;
        private string _ngaySinh;
        private string _diaChi;
        private string _sDT;
        public string MaDocGia
        {
            get { return _maDocGia; }
            set { _maDocGia = value; }
        }
        public string LoaiDocGia
        {
            get { return _loaiDocGia; }
            set { _loaiDocGia = value; }
        }
        public string TenDocGia
        {
            get { return _tenDocGia; }
            set { _tenDocGia = value; }
        }
        public string MaKhoa
        {
            get { return _maKhoa; }
            set { _maKhoa = value; }
        }
        public string Lop
        {
            get { return _lop; }
            set { _lop = value; }
        }
        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }
        public string NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }
        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        public string SDT
        {
            get { return _sDT; }
            set { _sDT = value; }
        }
    }
}
