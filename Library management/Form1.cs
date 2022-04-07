using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        List<User> users= new List<User>();
        List<book> books = new List<book>();



        private void button_adduser_Click(object sender, EventArgs e)
        {

         int userid = Convert.ToInt32(textBox_userid.Text);
         string name = textBox_name.Text;
         string address = textBox_address.Text;

            User dummy_users = new User ();
            dummy_users.address = address;
            dummy_users.name = name;
            dummy_users.userid = userid;

            users.Add(dummy_users);

            MessageBox.Show("THE INFORMATION ADDED");
    }

        private void button_addbook_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(textBox_bookid.Text);
            string bookname = textBox_bookname.Text;
            string author = textBox_author.Text;
            string publisher = textBox_publisher.Text;
            int quantity = Convert.ToInt32(textBox_quantity.Text);

            if (quantity<0)
            {
                MessageBox.Show("quantity can not be negative");
                return;
            }

            book dummy_books = new book();
            dummy_books.author = author;
            dummy_books.bookname = bookname;
            dummy_books.bookid = bookid;
            dummy_books.publisher = publisher;
            dummy_books.quantity = quantity; 

            books.Add(dummy_books);

            MessageBox.Show("THE INFORMATION ADDED");
        }

        public bool userExists(int uid)
        {
            foreach (User user in users)
            {
                if (user.userid == uid)
                {
                    return true;
                }
            }
            return false;
        }

        public bool bookExists(int bookid)
        {
            foreach (book books in books)
            {
                if (books.bookid == bookid)
                {
                    return true;
                }
            }

            return false;
        }
        private void button_showuser_Click(object sender, EventArgs e)
        {
            User dummy = new User();
            bool flag = false;
            foreach (User user in users)

            {
                if (user.userid == Convert.ToInt32(textBox_userid.Text))
                {
                    flag = true;
                    dummy = user;
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("User not found");
            }

            listBox_history.Items.Clear();

            for (int i=0; i< dummy.books.Count; i++)//20
            {
                int book_id = dummy.books[i];//
                for (int j=0; j<books.Count; j++ )
                {
                    if (books[j].bookid == book_id)
                    {
                        listBox_history.Items.Add(books[j].book_history());
                    }
                }
            }
        }

      
        private void button_borrow_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(textBox_uid.Text);
            int bookid = Convert.ToInt32(textBox_bid.Text);

            if ( bookExists(bookid) && userExists(userid))
            {
                foreach( book books in books)
                {
                    if(books.bookid == bookid)
                    {
                        if (books.quantity < 1)
                        {
                            MessageBox.Show("Not enough item in stock.");
                            break;
                        }
                        books.quantity -= 1;

                        foreach (User users in users)
                        {
                            if (users.userid == userid) 
                            {
                                users.books.Add(bookid);
                                MessageBox.Show("book has been added to the user");
                            }
                        }
                        break;
                    }
                }

            }
          else
            {
                MessageBox.Show("Invalid Input");
            }

        }

        private void button_showbook_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(textBox_bookid.Text);

            bool flag = false;

            foreach(book books in books)
            {
                if(books.bookid == bookid)
                {
                    flag = true;

                    label_showid.Text= Convert.ToString(books.bookid);   
                    label_showname.Text = books.bookname;
                    label_showauthor.Text = books.author;
                    label_showpublisher.Text = books.publisher;
                    label_showquantity.Text = Convert.ToString(books.quantity);
                }
                else
                {
                    MessageBox.Show("ID not found");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
