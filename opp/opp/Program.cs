using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            quanlysv quanlysv = new quanlysv();
            while (true) {
                Console.WriteLine("\nCHUONG TRINH QUAN LY SINH VIEN");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("  1. Them sinh vien.                               ");
                Console.WriteLine("  2. Cap nhat thong tin sinh vien boi ID.          ");
                Console.WriteLine("  3. Xoa sinh vien boi ID.                         ");
                Console.WriteLine("  4. Tim kiem sinh vien theo ten.                  ");
                Console.WriteLine("  5. Sap xep sinh vien theo diem trung binh.       ");
                Console.WriteLine("  6. Sap xep sinh vien theo ten.                   ");
                Console.WriteLine("  7. Sap xep sinh vien theo ID.                    ");
                Console.WriteLine("  0. Thoat                                         ");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int x=int.Parse(Console.ReadLine());
                switch (x)
                {
                 case 1:
                        Console.WriteLine("Them sv:");
                        quanlysv.addsv();
                        break;
                 case 2:
                        Console.WriteLine("update sv");
                        Console.Write("Nhap id: ");
                        int y = int.Parse(Console.ReadLine());
                        quanlysv.updatesv(y);
                        break;
                 case 3:
                        Console.WriteLine("xoa sv");
                        Console.Write("Nhap id: ");
                        int z = int.Parse(Console.ReadLine());
                        quanlysv.deletedsv(z);
                        break;
                  case 4:
                        Console.WriteLine("tim kiem theo ten");
                        Console.Write("Nhap ten: ");
                        string e = Console.ReadLine();
                        List<sinhvien> search = quanlysv.FindByname(e);
                        quanlysv.ShowSinhVien(search);
                       // Console.WriteLine(quanlysv.showdssv(search)); 
                        
                        
                        break;
                  case 5:
                        Console.WriteLine("Sap xep theo diem tb");
                        quanlysv.sapxepdtb();
                        quanlysv.ShowSinhVien(quanlysv.getsv());
                        break;
                  case 6:
                        Console.WriteLine("Sap xep theo ten");
                        quanlysv.sapxepten();
                        quanlysv.ShowSinhVien(quanlysv.getsv());
                        break;
                    case 7:
                        Console.WriteLine("Sap xep theo id");
                        quanlysv.sapxepid();
                        quanlysv.ShowSinhVien(quanlysv.getsv());
                        break;
                   case 0:
                        Console.WriteLine("Ban da thoat chong trinh");
                        break;
                    default:
                        Console.WriteLine("Nhap sai moi ban nhap lai");
                        break;

                }
            }

        }
    }
}
