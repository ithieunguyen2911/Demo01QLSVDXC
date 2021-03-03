using System;
using System.Collections;

namespace Demo01_QLSV_DXC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Todo: Thêm danh sách đối tượng vào ArrayList Person
            Console.WriteLine("Chuong trinh QLSV bang C#:");
            ArrayList personList = new ArrayList();
            personList.Add(new Person("Nguyen Huu Hieu", "29/11/1994", true, "TpHCM"));
            personList.Add(new Person("Nguyen Huu Hoa", "28/11/1994", true, "Ha Noi"));
            personList.Add(new Person("Nguyen Bao Ngan", "28/02/1994", false, "Hai Phong"));



            //Todo: In thông tin đối tượng
           /* Console.WriteLine("Thong Tin Cua Sinh Vien Khi Chua Sap Xep La : ");
            foreach (Person p in personList)
            {
                Console.WriteLine(p.ToString());
                
            }*/

            //Todo: Sắp xếp theo Sort() có sẵn
            
            Console.WriteLine("Thong Tin Cua Sinh Vien Sau Khi Sap Xep La : ");
            personList.Sort(new SortFullName());
            foreach (Person p in personList)
            {
                Console.WriteLine(p.ToString());

            }
            //Todo: Sắp xếp theo Sort(IComparer comparer) tự định nghĩa.

            
        }
        
        /*
             * Vì có thể 2 object truyền vào không phải Person khi đó ta không thể so sánh được.
             * Trường hợp này tốt nhất ta nên ném ra lỗi để lập trình viên sửa chữa.
             * Chi tiết về exception sẽ được trình bày ở những bài học sau.
             */
        public class SortFullName : IComparer
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
                {   /*
                     * Vì có thể 2 object truyền vào không phải Person khi đó ta không thể so sánh được.
                     * Trường hợp này tốt nhất ta nên ném ra lỗi để lập trình viên sửa chữa.
                     * Chi tiết về exception sẽ được trình bày ở những bài học sau.
                     */
                    /*if (p1.Age > p2.Age)
                    {
                        return 1;
                    }else if (p1.Age == p2.Age)
                    {
                        return 0;
                    }
                    else{
                        return -1;
                    }*/
                    return String.Compare(p1.FullName, p2.FullName);
                }
            }
        }
    }
}
