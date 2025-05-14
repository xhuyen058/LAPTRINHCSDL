using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PHIEUNHAP_DTO
    {
        private string _maPN;
        private string _ngayLap;
        private string _ghiChu;
        private string _nguoiLap;
        public string MaPN
        {
            get { return _maPN; }
            set { _maPN = value; }
        }
        public string NgayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = value; }
        }
        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        public string NguoiLap
        {
            get { return _nguoiLap; }
            set { _nguoiLap = value; }
        }
    }
}
