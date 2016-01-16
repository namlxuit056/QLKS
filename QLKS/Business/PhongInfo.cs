using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace QLKS
{
    class PhongInfo
    {
        private string m_MaPhong;
        public string MaPhong
        {
            get { return m_MaPhong; }
            set { m_MaPhong = value; }
        }

        private string m_MaLoaiPhong;
        public string MaLoaiPhong
        {
            get { return m_MaLoaiPhong; }
            set { m_MaLoaiPhong = value; }
        }

        private LoaiPhongInfo m_MaLoaiPhongML;
        public LoaiPhongInfo MaLoaiPhongML
        {
            get { return m_MaLoaiPhongML; }
            set { m_MaLoaiPhongML = value; }
        }

        private int m_TinhTrangPhong;
        public int TinhTrangPhong
        {
            get { return m_TinhTrangPhong; }
            set { m_TinhTrangPhong = value; }
        }

        private string m_GhiChu;
        public string GhiChu
        {
            get { return m_GhiChu; }
            set { m_GhiChu = value; }
        }

    }
}
