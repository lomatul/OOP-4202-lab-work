using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laundry_management_prac
{
    internal class user
    {
        public string name;
        public int user_id;
        public string address;

        public static int order_id = 0;

        public List<order> orderid = new List<order>();



        public static int Order_Id()
        {
            order_id = order_id + 1;
            return order_id;
        }

      
    }
}
