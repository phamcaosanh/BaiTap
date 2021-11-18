using System;

namespace quan_ly_nhan_su
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyNS quanLyNS = new QuanLyNS();


            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY NHAN VIEN ");
                Console.WriteLine("-------------------------MENU--------------------------");
                Console.WriteLine("--  1. Them nhan vien ( nhap : ae)                   --");
                Console.WriteLine("--  2. Them khach hang ( nhap : ac)                  --");
                Console.WriteLine("--  3. Hien thi danh sach nhan vien ( nhap : dae )   --");
                Console.WriteLine("--  4. Hien thi danh sach khach hang ( nhap : dac)   --");
                Console.WriteLine("--  5. Hien thi loai khach hang (nhap : cs )         --");
                Console.WriteLine("--  0. Thoat (nhap : out)                            --");
                Console.WriteLine("-------------------------------------------------------");
                Console.Write("Nhap tuy chon: ");
                string key = Convert.ToString(Console.ReadLine());

                switch (key)
                {
                    case "ae":
                        Console.WriteLine("\nThem nhan vien");
                        quanLyNS.ThemNV();
                        Console.WriteLine("\nThem Thanh Cong !!!");
                        break;
                    case "ac":
                        Console.WriteLine("\nThem khach hang");
                        quanLyNS.ThemKH();
                        Console.WriteLine("\nThem Thanh Cong !!!");
                        break;
                    case "dae":
                        if (quanLyNS.SoLuongNhanVien() > 0)
                        {
                            Console.WriteLine("\nHien thi danh sach nhan vien");
                            quanLyNS.DanhSachNV(quanLyNS.getListnhanvien());
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sach nhan vien rong!");
                        }
                        break;
                    case "dac":
                        if (quanLyNS.SoLuongkhachhang() > 0)
                        {
                            Console.WriteLine("\nHien Thi danh sach nhan vien");
                            quanLyNS.DanhsachKH(quanLyNS.getListkhachhang());
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sach khach hang rong!");
                        }
                        break;
                    case "cs":
                        Console.WriteLine("Hien thi Thong ke loai khach hang");
                        quanLyNS.thongke(quanLyNS.getListkhachhang());
                        break;
                    case "out":
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                    return;
                    default:
                        Console.WriteLine("\nKhong co chuc nang nay!");
                        Console.WriteLine("\nHay chon chuc nang trong MENU.");
                        break;
                }

            }
        }
    }
}
