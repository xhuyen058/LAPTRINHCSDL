using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PHIEUMUON_DTO
    {
        private string _maPM;
        private string _ngayMuon;
        private string _nguoiLapPhieuMuon;
        private string _maDocGia;
        private string _ghiChu;
        public string MaPM
        {
            get { return _maPM; }
            set { _maPM = value; }
        }
        public string NgayMuon
        {
            get { return _ngayMuon; }
            set { _ngayMuon = value; }
        }
       
        public string NguoiLapPhieuMuon
        {
            get { return _nguoiLapPhieuMuon; }
            set { _nguoiLapPhieuMuon = value; }
        }
        
        public string MaDocGia
        {
            get { return _maDocGia; }
            set { _maDocGia = value; }
        }
        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
    }
}
