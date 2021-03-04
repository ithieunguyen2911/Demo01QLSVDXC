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

            Console.WriteLine("\t 9. Thoat khoi chuong trinh");

            //bool checkMenu = true;

            StudentList std = new StudentList();
            do
            {
                Console.WriteLine("Nhap vao chuc nang ban muon:");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    std.SelectAll();
                }else if (choice == "2")
                {
                    std.Insert();
                }else if(choice == "3")
                {
                    std.Update();
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
                }
                else
                {
                    if(choice == "9")
                    {
                        Console.WriteLine("Ban co chac muon thoat khoi chuong trinh khong? (y/n)");
                        string addNew = Console.ReadLine();
                        if (addNew.Equals("y", StringComparison.OrdinalIgnoreCase))
                        {
                            //checkMenu = false;
                            break;
                        }
                    }
                }

               
            } while (true);

          
            //std.SelectAllSortByCode();
            //std.Delete("SV03"); //Ở đây ta sẽ viết lệnh cho người dùng nhập vào mã

            






























            //Todo: In thông tin đối tượng
            /*Console.WriteLine("Thong Tin Cua Sinh Vien Khi Chua Sap Xep La : ");
            foreach (Person p in personList)
            {
                Console.WriteLine(p.ToString());

            }*/

            //Todo: Sắp xếp theo Sort() có sẵn nó chỉ sắp xếp theo những đối tượng đơn giản có 1 thuộc tính,


            //Todo: Sắp xếp theo Sort(IComparer comparer) tự định nghĩa.
            /*Console.WriteLine("Thong Tin Cua Sinh Vien Sau Khi Sap Xep La : ");
            personList.Sort(new SortFullName());
            foreach (Person p in personList)
            {
                Console.WriteLine(p.ToString());

            }*/

        }
        
      
       /* public class SortFullName : IComparer
        {
            public int Compare(object x, object y)
            {
                Person p1 = x as Person;
                Person p2 = (Person) y ;

                if(p1 ==  null || p2 == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {   
                    
                    return String.Compare(p1.FullName, p2.FullName);
                }
            }
        }*/
    }
}
