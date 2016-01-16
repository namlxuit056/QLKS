using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;


namespace QLKS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
          
        }
        
        private void bntDangNhap_Click(object sender, RoutedEventArgs e)
        {
            Sign frm = new Sign();
            frm.Show();
            
        }

        private void bntDoiMatKhau_Click(object sender, RoutedEventArgs e)
        {
            Doimatkhau frm = new Doimatkhau();
            frm.Show();
        }

        private void bntNguoiDung_Click(object sender, RoutedEventArgs e)
        {
            Nguoidung frm = new Nguoidung();
            frm.Show();
        }

        private void bntKhachhang_Click(object sender, RoutedEventArgs e)
        {
            Khachhang frm = new Khachhang();
            frm.Show();
        }

        private void bntDichvu_Click(object sender, RoutedEventArgs e)
        {
            Dichvu frm = new Dichvu();
            frm.Show();
        }

        private void bntPhong_Click(object sender, RoutedEventArgs e)
        {
            Phong frm = new Phong();
            frm.Show();
        }

        private void bntPhieuDangki_Click(object sender, RoutedEventArgs e)
        {
            Phieudangki frm = new Phieudangki();
            frm.Show();
        }

        private void bntNhanPhong_Click(object sender, RoutedEventArgs e)
        {
            NhanPhong frm = new NhanPhong();
            frm.Show();
        }

        private void bntTraphong_Click(object sender, RoutedEventArgs e)
        {
            Traphong frm = new Traphong();
            frm.Show();
        }

        private void btnThietbi_Click(object sender, RoutedEventArgs e)
        {
            Thietbi frm = new Thietbi();
            frm.Show();
        }

        private void bntLoaiphong_Click(object sender, RoutedEventArgs e)
        {
            Loaiphong frm = new Loaiphong();
            frm.Show();
        }

        private void bntLoaidichvu_Click(object sender, RoutedEventArgs e)
        {
            Loaidichvuxaml frm = new Loaidichvuxaml();
            frm.Show();
        }

        private void bntDanhsachhoadon_Click(object sender, RoutedEventArgs e)
        {
            Doanhsachhoadon frm = new Doanhsachhoadon();
            frm.Show();
        }

    }
}
