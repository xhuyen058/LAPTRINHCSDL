using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NGUOIDUNG_DTO
    {
        private string _taiKhoan;
        private string _matKhau;
        private string _maQuyen;
        public string TaiKhoan
        {
            get { return _taiKhoan; }
            set { _taiKhoan = value; }
        }
        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }
        public string MaQuyen
        {
            get { return _maQuyen; }
            set { _maQuyen = value; }
        }

    }
}
