using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SACH_DTO
    {
        private string _maSach;
        private string _tenSach;
        private string _maKe;
        private string _nhaXuatBan;
        private string _namXuatBan;
        private string _tacGia;
        private string _maLoai;
        public string MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }
        public string TenSach
        {
            get { return _tenSach; }
            set { _tenSach = value; }
        }
        public string MaKe
        {
            get { return _maKe; }
            set { _maKe = value; }
        }
        public string NhaXuatBan
        {
            get { return _nhaXuatBan; }
            set { _nhaXuatBan = value; }
        }
        public string NamXuatBan
        {
            get { return _namXuatBan; }
            set { _namXuatBan = value; }
        }
        public string TacGia
        {
            get { return _tacGia; }
            set { _tacGia = value; }
        }
        public string MaLoai
        {
            get { return _maLoai; }
            set { _maLoai = value; }
        }
    }
}
