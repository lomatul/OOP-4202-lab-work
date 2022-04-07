using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management
{
    internal class medi
    {

        public string name;
        public int qty;
        public int price;
        public int amount;
        public string get_medi()
        {
            return name + "\t" + qty + "\t" + price;
        }
       

    }
}
