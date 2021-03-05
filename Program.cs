using System;
using System.Collections;

namespace Demo01_QLSV_DXC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Todo: Thêm danh sách đối tượng vào ArrayList Person
            /* Console.WriteLine("Chuong trinh QLSV bang C#:");
             ArrayList studentList = new ArrayList();
             studentList.Add(new Student("SV01","Nguyen Huu Hieu", "29/11/1994", true, "TpHCM",9.5));*/

            //Student std = new Student("SV01", "Nguyen Huu Hieu", "29/11/1994", true, "TpHCM", 9.5);
            //std.ShowInfo();

            Console.WriteLine("Chuong Trinh Quan Ly Thong Tin Sinh Vien");
            Console.WriteLine("\t 1. Hien thi danh sach sinh vien");
            Console.WriteLine("\t 2. Them sinh vien");
            Console.WriteLine("\t 3. Sua sinh vien");
            Console.WriteLine("\t 4. Xoa sinh vien");
            Console.WriteLine("\t 5. Sap xep danh sach sinh vien theo MASV");
            Console.WriteLine("\t 6. Tim kiem sinh vien theo MASV");
            Console.WriteLine("\t 7. Tim kiem sinh vien theo Ho va Ten");

            Console.WriteLine("\t 9. Thoat khoi chuong trinh");

            //bool checkMenu = true;

            StudentList std = new StudentList();
            do
            {
                Console.WriteLine("Nhap vao chuc nang ban muon:");
                string choice = Console.ReadLine().Trim();

                if (choice == "1")
                {
                    std.SelectAll();
                }else if (choice == "2")
                {
                    std.Insert();
                }else if(choice == "3")
                {
                    Console.WriteLine("Nhap vao ma sinh vien ban muon sua:");
                    string code = Console.ReadLine();
                    std.Update(code);
                }else if(choice == "4")
                {
                    Console.WriteLine("Nhap vao ma sinh vien ban muon xoa:");
                    string code = Console.ReadLine();
                    std.Delete(code);
                }else if(choice == "5")
                {               
                    std.SelectAllSortByCode();
                }else if(choice == "6")
                {
                    Console.WriteLine("Nhap vao ma sinh vien ban muon tim kiem:");
                    string code = Console.ReadLine();
                    std.SelectOne(code);
                }else if(choice == "7")
                {
                    Console.WriteLine("Nhap vao tên sinh vien ban muon tim kiem:");
                    string name = Console.ReadLine();
                    std.FindByFullName(name);
                }
                else
                {
                    if(choice == "9")
                    {
                        Console.WriteLine("Ban co chac muon thoat khoi chuong trinh khong? (y/n)");
                        string addNew = Console.ReadLine().Trim();
                        if (addNew.Equals("y", StringComparison.OrdinalIgnoreCase))
                        {
                            //checkMenu = false;
                            break;
                        }
                    }
                }

               
            } while (true);

        }
        
      

    }
}
