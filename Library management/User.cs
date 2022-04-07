using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management
{
    internal class User
    {
        public int userid;
        public string name;
        public string address;

        public List<int> books = new List<int>();

       
        public void addbook(int bookid)
        {
            books.Add(bookid);
        }
        

        

    }
}
