using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management
{
    internal class book
    {
        public int bookid;
        public string bookname;
        public string author;
        public string publisher;
        public int quantity;


        public string book_history()
        {
            return bookid + "\t" + bookname  ;
        }

      

    }
}
