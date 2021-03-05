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
            Console.WriteLine("Nhap ma sinh vien:");
            stdCode = Console.ReadLine();
           
            Console.WriteLine("Nhap ho va ten:");
            FullName = Console.ReadLine();
            
            Console.WriteLine("Nhap ngay sinh:");
            DateOfBirth = DateTimeIO.ConvertStringToDateTime(Console.ReadLine());
            
            Console.WriteLine("Nhap gioi tinh:");
            Gender = bool.Parse(Console.ReadLine());
            
            Console.WriteLine("Nhap dia chi:");
            Address = Console.ReadLine();

            Console.WriteLine("Nhap diem:");
            stdGrades = double.Parse(Console.ReadLine());
        }

        //Xuất thông tin của sinh viên đó
        public override void ShowInfo()
        {
            Console.Write("Ma sinh vien: {0} - ", stdCode);
            base.ShowInfo();
            Console.WriteLine(" - Diem: {0} ", stdGrades);
        }
    }
}
