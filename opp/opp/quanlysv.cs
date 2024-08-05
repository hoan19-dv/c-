using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp
{
    internal class quanlysv
    {
        private List<sinhvien> dssinhvien=null;
        public quanlysv() { 
            dssinhvien = new List<sinhvien>();
        }

        private int idsv() {
            int id = 1;
            if (dssinhvien!=null&&dssinhvien.Count>0)
            {
                id = dssinhvien[0].id;
                foreach (sinhvien sv in dssinhvien)
                {
                    if (id<sv.id)
                    {
                        id = sv.id;
                    }
                }
                id++;
            }
            return id;
        }

        public void addsv() {
            sinhvien sv = new sinhvien();
            sv.id= idsv();
            Console.Write("Nhap ten sv:");
            sv.name=Console.ReadLine();
            Console.Write("Nhap gioi tinh sv:");
            sv.sex = Console.ReadLine();
            Console.Write("Nhap tuoi sv:");
            sv.age = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem toan:");
            sv.toan=double.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly:");
            sv.ly = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa:");
            sv.hoa = double.Parse(Console.ReadLine());
            Console.Write("Them sv thanh cong!");
            dssinhvien.Add(sv);
            diemtb(sv);
            Console.WriteLine(sv.id);
           
        }


        public List<sinhvien> getsv() { 
            return dssinhvien; 
        }


        public void ShowSinhVien(List<sinhvien> listSV)
        {
            // hien thi tieu de cot
            Console.WriteLine(
                 "{0, -5} {1, -5} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 5}",
          "ID", "Name", "Sex", "Age", "Toan", "Ly", "Hoa","Diemtb");
            // hien thi danh sach sinh vien
            if (listSV != null && listSV.Count > 0)
            {
                foreach (sinhvien sv in listSV)
                {
                    Console.WriteLine("{0, -5} {1, -5} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 5}",
                                      sv.id, sv.name, sv.sex, sv.age, sv.toan, sv.ly, sv.hoa ,sv.diemtb);
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay sv");
            }
            Console.WriteLine();
        }

        public void updatesv(int id) { 
         sinhvien sv=FindByID(id);
            if (sv != null)
            {
                Console.Write("Nhap ten sv:");
                string name = Console.ReadLine();
                if (name!=null&& name.Length>0)
                {
                    sv.name = name;
                }
                Console.Write("Nhap gioi tinh sv:");
                string sex = Console.ReadLine();
                if (sex != null && sex.Length > 0)
                {
                    sv.sex = sex;
                }
                Console.Write("Nhap tuoi sv:");
                string tuoi = Console.ReadLine();
                if (tuoi != null && tuoi.Length > 0)
                {
                    sv.age = int.Parse(tuoi);
                }
                Console.Write("Nhap diem toan:");
                string toan = Console.ReadLine();
                if (toan != null && toan.Length > 0)
                {
                    sv.toan = int.Parse(toan);
                }
                Console.Write("Nhap diem ly:");
                string ly = Console.ReadLine();
                if (ly != null && ly.Length > 0)
                {
                    sv.ly = int.Parse(ly);
                }
                Console.Write("Nhap diem hoa:");
                string hoa = Console.ReadLine();
                if (hoa != null && hoa.Length > 0)
                {
                    sv.hoa = int.Parse(hoa);
                }
            }
            else
            {
                Console.WriteLine("Sinh vien khon ton tai");
            }
        }

        public void deletedsv(int ID)
        {
            sinhvien sv= FindByID(ID);
            if (dssinhvien!=null&&dssinhvien.Count>0)
            {
                dssinhvien.Remove(sv);
                Console.WriteLine("Xoa sv thanh cong");
            }
            else
            {
                Console.WriteLine("Sinh vien khon ton tai");
            }
        }

        public  List<sinhvien> FindByname(string name)
        {
            List<sinhvien> searchname= new List<sinhvien>();
            if (name!=null)
            {
                foreach (sinhvien sv  in dssinhvien)
                {
                    if (name==sv.name)
                    {
                        searchname.Add(sv); 
                    }
                }
                
            }
            return searchname;
        }


         public void diemtb(sinhvien sv)
        {
            sv.diemtb = (sv.toan + sv.ly + sv.hoa) / 3;          
        }


        public void  sapxepdtb()
        {
          dssinhvien.Sort((sv1, sv2) => sv1.diemtb.CompareTo(sv2.diemtb));

        }

        public void sapxepten()
        {
            dssinhvien.Sort((sv1, sv2) => sv1.name.CompareTo(sv2.name));

        }

        public void sapxepid()
        {
            dssinhvien.Sort((sv1, sv2) => sv1.id.CompareTo(sv2.id));

        }





        public sinhvien FindByID(int ID)
        {
            sinhvien searchResult = null;
            if (dssinhvien != null && dssinhvien.Count > 0)
            {
                foreach (sinhvien sv in dssinhvien)
                {
                    if (sv.id == ID)
                    {
                        searchResult = sv;
                    }
                }
            }
            return searchResult;
        }
    }
}
