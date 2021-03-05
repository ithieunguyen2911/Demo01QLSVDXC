﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Demo01_QLSV_DXC
{
    public class DateTimeIO
    {
        public static DateTime ConvertStringToDateTime(string date)
        {
            string[] arrayDate = date.Split("/");
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
