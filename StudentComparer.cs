using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Demo01_QLSV_DXC
{
    public class StudentComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            /*
              * Vì có thể 2 object truyền vào không phải Student khi đó ta không thể so sánh được.
              * Trường hợp này tốt nhất ta nên ép kiểu đối tượng truyền vào về Student
           */
            Student st1 = x as Student;
            Student st2 = (Student)y;
            
            //Vì có thể 2 object truyền vào null khi đó ta không thể so sánh được.
            if(st1 == null || st2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
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
                return String.Compare(st1.StdCode, st2.StdCode);
            }

        }
    }
}
