using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeelist
{
    internal class Class1
    {
        public int studentid;
        public string studentname;
        public int studentsemester;
        public string studentdept;


        public string get_studentInfo()
        {
            return  studentid + "\t" + studentname + "\t" + studentsemester + "\t" + studentdept;
           
        }
    }
}
