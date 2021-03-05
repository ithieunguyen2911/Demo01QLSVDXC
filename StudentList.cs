using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace Demo01_QLSV_DXC
{
    public class StudentList:IStudent
    {
         //ArrayList list = new ArrayList();
        private List<Student> studentList = new List<Student>() { 
            new Student("SV01", "Nguyen Huu Hieu", DateTimeIO.ConvertStringToDateTime("29/11/1994"), true, "TpHCM", 9.5),
            new Student("SV02", "Nguyen Huu Hoa", DateTimeIO.ConvertStringToDateTime("26/10/1994"), true, "Ha Noi", 7.5),
            new Student("SV04", "Nguyen Thao Ngan", DateTimeIO.ConvertStringToDateTime("02/02/1994"), false, "Hai Phong", 8.0),
            new Student("SV03", "Nguyen Bao An",DateTimeIO.ConvertStringToDateTime("01/01/1994"), false, "TpHCM", 4.5)
        };

        public void Delete(string stdCode)
        {
            string s = stdCode.ToUpper();
            for (int i = 0; i<studentList.Count;)
            {
                if (s == studentList[i].StdCode)
                {
                    studentList.RemoveAt(i);
                    Console.WriteLine("Ban da xoa thanh cong!");

                    SelectAll();
                    break;
                }
                else
                {
                    i++;
                    if (i == studentList.Count)
                    {
                        Console.WriteLine("Sinh vien ban muon xoa khong co!");
                    }
                }
            }
        }

        public void Insert()
        {
            do
            {
                Student st = new Student();
                st.EnterStudentInfo();
                studentList.Add(st);
                Console.WriteLine("Them moi thanh cong!");

                Console.WriteLine("Ban co muon them sinh vien nua khong? (y/n)");
                string addNew = Console.ReadLine();
                if (addNew.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            } while (true);
        }

        public void Update(string stdCode)
        {
            
            var result = studentList.Where(std => std.StdCode.Trim().ToUpper() == stdCode.Trim().ToUpper()).Single();
            result.ShowInfo();
            
            result.FullName = Console.ReadLine();
            result.DateOfBirth = DateTimeIO.ConvertStringToDateTime(Console.ReadLine());
            result.Gender = bool.Parse(Console.ReadLine());
            result.Address = Console.ReadLine();
            result.StdGrades = double.Parse(Console.ReadLine());

            //studentList.Add(result);
            Console.WriteLine("Cap nhat sinh vien thanh cong!");
            SelectAll();
        }

        public void SelectOne(string stdCode)
        {
            string s = stdCode.ToUpper();
            for(int i = 0; i < studentList.Count; )
            {
                if(s == studentList[i].StdCode)
                {
                    studentList[i].ShowInfo();
                    break;
                }
                else
                {
                    i++;
                    if (i == studentList.Count)
                    {
                        Console.WriteLine("Sinh vien ban muon tim khong co!");
                    }
                }
            }
        }


        public void SelectAll()
        {
            foreach (Student st in studentList)
            {
                st.ShowInfo();
            }

            //Cú pháp lambda
            //studentList.ForEach(item => { item.ShowInfo(); });
            //studentList.ForEach(item => item.ShowInfo());
        }

        //Điểm khác biệt là StudentComparer không truyền đối tượng Student vào Generic 
        //public class StudentComparer : IComparer
        //Chỉ sắp xếp theo một tiêu chí
        public void SelectAllSortByCode()
        {
            //studentList.Sort();

            ArrayList listSort = new ArrayList(studentList);

            listSort.Sort(new StudentComparer());

            foreach (Student item in listSort)
            {
                item.ShowInfo();
            }
        }

        //Điểm khác biệt là StudentComparer không truyền đối tượng Student vào Generic 
        //public class StudentComparerMultiple : IComparer<Student>
        //Sắp xếp theo nhiều tieu chí khác nhau.
        public void SortMultiple()
        {
            studentList.Sort(new StudentComparerMultiple());
        }

        //Sử dụng LinQ để tìm một đối tượng Student theo tên
        public void FindByFullName(string FullName)
        {

            var result = studentList.Where(item => item.FullName.Trim().ToUpper() == FullName.Trim().ToUpper()).FirstOrDefault();
            result.ShowInfo();
        }
    }
}
