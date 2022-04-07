using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeelist
{
    internal class Teacher
    {
        public int tid;
        public string tname;
        public int salary;
        public string tdept;
        public string tdesignation;
        public string get_teacherInfo()
        {
            return tid + "\t" + tname + "\t" + salary + "\t" + tdept + "\t" + tdesignation;

        }

    }
}
