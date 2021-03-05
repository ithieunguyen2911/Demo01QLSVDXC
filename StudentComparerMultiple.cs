using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Demo01_QLSV_DXC
{
    public class StudentComparerMultiple : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            int result = x.StdCode.CompareTo(y.StdCode);

            if (result == 0)
            {
                result = x.FullName.CompareTo(y.FullName);

            }
            if (result == 0)
            {
                result = x.DateOfBirth.CompareTo(y.DateOfBirth);

            }

            return result;
        }
    }
}
