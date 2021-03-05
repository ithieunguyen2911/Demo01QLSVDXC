using System;
using System.Collections.Generic;
using System.Text;

namespace Demo01_QLSV_DXC
{
    public class Student : Person
    {
        private string stdCode;
        private double stdGrades;

        

        public Student() 
        {

        }

        public Student(string StdCode,string FullName, DateTime DateOfBirth,bool Gender,string Address, double StdGrades) : base (FullName, DateOfBirth, Gender, Address)
        {
            this.StdCode = StdCode;
            this.StdGrades = StdGrades;
        }
        //Getter & Setter
        public double StdGrades { get => stdGrades; set => stdGrades = value; }
        public string StdCode { get => stdCode; set => stdCode = value; }
        
        //Nhập thông tin sinh viên
        public void EnterStudentInfo()
        {
            try
            {
                Console.WriteLine("Nhap ma sinh vien:");
                stdCode = Input().ToUpper();

                Console.WriteLine("Nhap ho va ten:");
                FullName = Input();


                Console.WriteLine("Nhap ngay sinh:");
                DateOfBirth = DateTimeIO.ConvertStringToDateTime(Input());

                Console.WriteLine("Nhap gioi tinh:");
                //Gender = bool.Parse(Input());
                //Sử dụng toán tử điều kiện để gán giá trị true | false cho Gender có kiểu dữ liệu boolean.
                Gender = bool.Parse(Input().ToUpperInvariant() == "NAM" ? "true" : Input().ToUpperInvariant() == "NU" ? "false" : "Invalid");

                Console.WriteLine("Nhap dia chi:");
                Address = Input();

                Console.WriteLine("Nhap diem:");
                double Grades = double.Parse(Console.ReadLine());
                stdGrades = checkGrades(Grades);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi :" + ex.Message);
            }
            
            

        }

        //Xuất thông tin của sinh viên đó
        public override void ShowInfo()
        {
            Console.Write("Ma sinh vien: {0} - ", stdCode);
            base.ShowInfo();
            Console.WriteLine(" - Diem: {0} ", stdGrades);
        }

        public string Input()
        {
            string s = Console.ReadLine().Trim();
            if (s == "")
                throw new Exception("Gia tri nhap vao khong duoc de trong");

            return s;
        }

        public double checkGrades(double Grades)
        { 
            do
            {
                if (Grades > 10 || Grades < 0)
                {
                    Console.WriteLine("Gia tri nhap vao : diem >= 0 và diem <= 10 ");
                    Grades = double.Parse(Console.ReadLine());
                }
                else
                {
                    return Grades;
                }
            } while (true);
        }
    }
}
