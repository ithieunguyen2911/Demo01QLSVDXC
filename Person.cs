using System;
using System.Collections.Generic;
using System.Text;

namespace Demo01_QLSV_DXC
{
    public class Person
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
            this.FullName = FullName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
        }

        //Getter & Setter
        public string FullName { get => fullName; set => fullName = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public bool Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }

        //ToString() : purpose to print infomation.
        public override string ToString()
        {
            return "Ho va Ten : " + FullName + " Ngay sinh : " + DateOfBirth + " Gioi tinh : " + Gender + " Dia Chi : " + Address;
        }
    }
}
