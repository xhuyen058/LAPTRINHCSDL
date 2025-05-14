using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KESACH_DTO
    {
        private string _maKe;
        private string _chatLieu;
        private int _sucChua;
        private string _loaiSach;
        public string MaKe
        {
            get { return _maKe; }
            set { _maKe = value; }
        }
        public string ChatLieu
        {
            get { return _chatLieu; }
            set { _chatLieu = value; }
        }
        public int SucChua
        {
            get { return _sucChua; }
            set { _sucChua = value; }
        }
        public string LoaiSach
        {
            get { return _loaiSach; }
            set { _loaiSach = value; }
        }
    }
}
