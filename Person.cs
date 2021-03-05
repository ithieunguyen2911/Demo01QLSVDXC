using System;
using System.Collections.Generic;
using System.Text;

namespace Demo01_QLSV_DXC
{
    public abstract class Person
    {
        //Declare Variable
        private string fullName;
        private DateTime dateOfBirth;
        private bool gender;
        private string address;

        //Constructor
        public Person()
        {

        }
        public Person(string FullName, DateTime DateOfBirth, bool Gender, string Address)
        {
            fullName = FullName;
            dateOfBirth = DateOfBirth;
            gender = Gender;
            address = Address;
        }

        //Getter & Setter
        public string FullName { get => fullName; set => fullName = value; }
        public string DateOfBirth { get => ConvertDateTimeToString(dateOfBirth); set => dateOfBirth = ConvertStringToDateTime(value); }
        public bool Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }

        // Chuyển kiểu dữ liệu từ String sang DateTime
        public DateTime ConvertStringToDateTime(string date)
        {
            string[] arrayDate = date.Split("/");
            int year = int.Parse(arrayDate[2]);
            int month = int.Parse(arrayDate[1]);
            int day = int.Parse(arrayDate[0]);

            DateTime ResultDate = new DateTime(year, month, day);
            return ResultDate;
        }

        // Chuyển kiểu dữ liệu từ DateTime sang String
        public string ConvertDateTimeToString(DateTime date)
        {
            int day = date.Day;
            int month = date.Month;
            int year = date.Year;

            string result = day.ToString() + "/" + month.ToString() + "/" + year.ToString();
            return result;
        }

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
