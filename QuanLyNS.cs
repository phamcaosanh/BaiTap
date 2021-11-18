using System;
using System.Collections.Generic;
using System.Text;

namespace quan_ly_nhan_su
{
    class QuanLyNS
    {
        private List<nhanvien> Listnhanvien = null;
        private List<khachhang> Listkhachhang = null;
        public QuanLyNS()
        {
            Listnhanvien = new List<nhanvien>();
            Listkhachhang = new List<khachhang>();
        }


        public int SoLuongNhanVien()
        {
            int Count = 0;
            if (Listnhanvien != null)
            {
                Count = Listnhanvien.Count;
            }
            return Count;
        }
        public int SoLuongkhachhang()
        {
            int Count = 0;
            if (Listkhachhang != null)
            {
                Count = Listkhachhang.Count;
            }
            return Count;
        }
        //Hàm thêm nhân viên
        public void ThemNV()
        {
            nhanvien nv = new nhanvien();
            Console.Write("Nhap Ma Nhan Vien : ");
            nv.manv = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap Ten Nhan Vien : ");
            nv.tennv = Console.ReadLine();

            Console.Write("Nhap Gioi Tinh Nhan Vien : ");
            nv.gioitinh = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap Bang Cap Nhan Vien : ");
            nv.bangcap = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap Ngay Sinh Nhan Vien : ");
            nv.ngaysinh = Convert.ToString(Console.ReadLine());

            Listnhanvien.Add(nv);
        }
        // Hàm nhập Thêm khách hàng
        public void ThemKH()
        {
            khachhang kh = new khachhang();
            Console.Write("Nhap Ma Khach Hang : ");
            kh.makh = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap ten Khach Hang : ");
            kh.tenkh = Console.ReadLine();

            Console.Write("Nhap Gioi Tinh Khach Hang : ");
            kh.gioitinh = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap Ngay Sinh Khach Hang : ");
            kh.ngaysinh = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap Loai Khach Hang : ");
            kh.loaikh = Convert.ToString(Console.ReadLine());

            Listkhachhang.Add(kh);
        }
        //Hàm hiển thị ra danh sách nhan viên
        public void DanhSachNV(List<nhanvien> nhanViens)
        {
            // Hiển thị tiêu đề vs cột
            Console.WriteLine("{0,-5} {1, -20} {2, -7} {3, 7} {4, 7} ", "MaNV", "TenNV", "GioiTinh", "BangCap", "NgaySinh");
            //Hiển thị danh sách nhân viên
            if (Listnhanvien != null && Listnhanvien.Count > 0)
            {
                foreach (nhanvien nv in Listnhanvien)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -7} {3, 7} {4, 7}", nv.manv, nv.tennv, nv.gioitinh, nv.bangcap, nv.ngaysinh);

                }
            Console.WriteLine();
            }

        }



        //Hàm hiển thị danh sách khách hàng
        public void DanhsachKH(List<khachhang> khachHangs)
        {
            //Hiển thị tiêu đề vs cột
            Console.WriteLine("{0,-5} {1, -20} {2, -7} {3, 7} {4, 7} ", "MaKH", "TenKH", "GioiTinh", "NgaySinh", "LoaiKH");
            //Hiển thị danh sách khách hàng
            if (Listkhachhang != null && Listkhachhang.Count > 0)
            {
                foreach (khachhang kh in Listkhachhang)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -7} {3, 7} {4, 7}", kh.makh, kh.tenkh, kh.gioitinh, kh.ngaysinh, kh.loaikh);
                }
                Console.WriteLine();
            }
        }
        // Hàm trả về danh sách nhân viên hiện tại
        public List<nhanvien> getListnhanvien()
        {
            return Listnhanvien;
        }
        //ham trả về danh sách khách hàng hiện tại
        public List<khachhang> getListkhachhang()
        {
            return Listkhachhang;
        }
    }
}
