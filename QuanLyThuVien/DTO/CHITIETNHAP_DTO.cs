using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CHITIETNHAP_DTO
    {
        private string _maPN;
        private string _maSach;
        private string _maNCC;
        private int _soLuong;
        public string MaPN
        {
            get { return _maPN; }
            set { _maPN = value; }
        }
        public string MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }
        public string MaNCC
        {
            get { return _maNCC; }
            set { _maNCC = value; }
        }
        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
    }
}
