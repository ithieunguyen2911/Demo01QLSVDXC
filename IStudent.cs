using System;
using System.Collections.Generic;
using System.Text;

namespace Demo01_QLSV_DXC
{
    public interface IStudent
    {
        
        void Insert();
        void Update(string stdCode);
        void Delete(string stdCode);
        void SelectAll();

        void SelectOne(string stdCode);

    }
}
