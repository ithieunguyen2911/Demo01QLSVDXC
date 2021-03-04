using System;
using System.Collections.Generic;
using System.Text;

namespace Demo01_QLSV_DXC
{
    public abstract class Person
    {
        //Declare Variable
        private string fullName;
        private string dateOfBirth;
        private bool gender;
        private string address;

        //Constructor
        public Person()
        {

        }
        public Person(string FullName, string DateOfBirth, bool Gender, string Address)
        {
            fullName = FullName;
            dateOfBirth = DateOfBirth;
            gender = Gender;
            address = Address;
        }

        //Getter & Setter
        public string FullName { get => fullName; set => fullName = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public bool Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }

        //FillInfo() : purpose to enter person information
        /* public void FillInfo()
         {
             Console.WriteLine("----------------------------------------------------------------------------");
             Console.Write("Ho Ten : ");
             fullName = Console.ReadLine();
             Console.Write("Ngay Sinh : ");
             dateOfBirth = Console.ReadLine();
             Console.Write("Gioi Tinh : ");
             gender = bool.Parse(Console.ReadLine());
             Console.Write("Dia Chi : ");
             address = Console.ReadLine();

             Console.WriteLine("----------------------------------------------------------------------------");
         }*/

        //ToString() : purpose to print infomation.
        /*public override string ToString()
        {
            return "Ho va Ten : " + FullName + " Ngay sinh : " + DateOfBirth + " Gioi tinh : " + Gender + " Dia Chi : " + Address;
        } */

        //Check Gender 
        public string CheckGender()
        {
            if (gender == true)
            {
                return "Nam";
            }
            else
            {
                return "Nu";
            }
        }

        //Show Info
        public virtual void ShowInfo()
        {
            Console.Write("Ho va Ten: {0} - Ngay sinh: {1} - Gioi Tinh: {2} - Dia Chi: {3}", fullName, dateOfBirth, CheckGender(), address);
        }
    }
}
