using System;
using System.Collections.Generic;
using System.Text;

namespace Demo01_QLSV_DXC
{
    public class DateTimeIO
    {
        // Chuyển kiểu dữ liệu từ String sang DateTime
        public static DateTime ConvertStringToDateTime(string date)
        {

            string[] arrayDate = date.Split("/");
            if (arrayDate == null)
                throw new Exception("Gia tri cua ngay nhap vao khong duoc de rong");
            int year = int.Parse(arrayDate[2]);
            int month = int.Parse(arrayDate[1]);
            int day = int.Parse(arrayDate[0]);

            DateTime ResultDate = new DateTime(year, month, day);
            return ResultDate;
        }

        // Chuyển kiểu dữ liệu từ DateTime sang String
        public static string ConvertDateTimeToString(DateTime date)
        {
            int day = date.Day;
            int month = date.Month;
            int year = date.Year;

            string result = day.ToString() + "/" + month.ToString() + "/" + year.ToString();
            return result;
        }
    }
}
