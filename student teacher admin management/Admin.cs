using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeelist
{
    internal class Admin
    {
        public int aid;
        public string aname;
        public int asalary;
        public string adesignation;
        public string get_adminInfo()
        {
            return aid + "\t" + aname + "\t" + adesignation + "\t" + asalary;
        }
    }
}
