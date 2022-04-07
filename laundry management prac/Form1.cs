using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laundry_management_prac
{
    public partial class Form1 : Form
    {
        List<user> users = new List<user>();
        List<laundry> laundries = new List<laundry>();
        List<order> orders = new List<order>();
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public int id;
        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string address = textBox_address.Text;
            int userid = Convert.ToInt32(textBox_userid.Text);
            int orderid;

            user dummy_user = new user();
            dummy_user.address = address;
            dummy_user.name = name;
            dummy_user.user_id = userid;
            

            users.Add(dummy_user);
            
            MessageBox.Show("Added");


        }
        public int orderid=0;
        public int shirt_price;
        public int pant_price;
        public int bedsheet_price;
        public int suits_price; 
        public int total;
        public bool f = false;
        private void button2_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(textBox_user_id.Text);
            int shirt = Convert.ToInt32(textBox_shirt.Text);
            int pant = Convert.ToInt32(textBox_pant.Text);
            int suit = Convert.ToInt32(textBox_suit.Text);
            int bedsheets = Convert.ToInt32(textBox_bedsheet.Text);
            
        //int bedsheet_price;
        // int suit_price;
        
            foreach (user user in users)
            {
                if (userid==user.user_id)
                {
                    f = true;
                    if (comboBox_shirt.Text == "wash")
                    {
                        shirt_price = shirt * 7;

                    }

                    if (comboBox_shirt.Text == "iron")
                    {
                        shirt_price = shirt * 3;

                    }
                    if (comboBox_shirt.Text == "both")
                    {
                        shirt_price = shirt * 28;
                    }


                    if (comboBox_pant.Text == "wash")
                    {
                        pant_price = pant * 7;

                    }

                    if (comboBox_pant.Text == "iron")
                    {
                        pant_price = pant * 3;
                    }
                    if (comboBox_pant.Text == "both")
                    {
                        pant_price = pant * 28;
                    }
                    if (comboBox_bedsheet.Text == "wash")
                    {
                        bedsheet_price = bedsheets * 7;

                    }

                    if (comboBox_bedsheet.Text == "iron")
                    {
                        bedsheet_price = bedsheets * 3;
                    }
                    if (comboBox_bedsheet.Text == "both")
                    {
                        bedsheet_price = bedsheets * 28;
                    }
                    if (comboBox_suit.Text == "wash")
                    {
                        suits_price = suit * 7;

                    }

                    if (comboBox_suit.Text == "iron")
                    {
                        suits_price = suit * 3;
                    }
                    if (comboBox_suit.Text == "both")
                    {
                        suits_price = suit * 28;
                    }
                    total = shirt_price + pant_price + bedsheet_price + suits_price;

                    laundry dummy_laundry = new laundry();

                    dummy_laundry.bedsheets = bedsheets;
                    dummy_laundry.pants = pant;
                    dummy_laundry.shirt = shirt;
                    dummy_laundry.suits = suit;
                    dummy_laundry.id = userid;
                    dummy_laundry.pant_price = pant_price;
                    dummy_laundry.shirt_price = shirt_price;
                    dummy_laundry.suit_price = suits_price;
                    dummy_laundry.bedsheet_price = bedsheet_price;

                    orderid = orderid + 1;

                    //laundries.Add(dummy_laundry);
                    order o = new order();
                    o.orderid = orderid;
                    o.laun = dummy_laundry;
                    orders.Add(o);



                   

                    //orderid = user.Order_Id();

                    MessageBox.Show("Order ADded");
                    MessageBox.Show("order id is " + Convert.ToString(orderid));

                }

                if (f== false)
                {
                    MessageBox.Show("Id Not Found");
                }
            }

      
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            int orderid = Convert.ToInt32(textBox_order.Text);
            string status = comboBox_status.Text;
            label_balnce.Text = Convert.ToString(total);

            order dummy_order = new order();
            dummy_order.orderid = orderid;
            dummy_order.status = status;
            orders.Add(dummy_order);

            MessageBox.Show("ordered");
           



        }

        private void button4_Click(object sender, EventArgs e)
        {
            int order_id = Convert.ToInt32(textBox_order_id.Text);
            bool found = false;
            foreach( order dummy in orders)

            {

                if (order_id == dummy.orderid)
                {
                    found = true;
                     status.Text = dummy.status;
                    label_amount.Text = Convert.ToString( total);

                    listBox_order.Items.Add($"shirt\t{dummy.laun.shirt}\t{comboBox_shirt.Text}\t{dummy.laun.shirt_price}" );
                    listBox_order.Items.Add($"pant\t{dummy.laun.pants}\t {comboBox_pant.Text}\t{dummy.laun.pant_price}" );
                    listBox_order.Items.Add($"suit\t{dummy.laun.suits}\t {comboBox_suit.Text}\t{dummy.laun.suit_price}" );
                    listBox_order.Items.Add($"bedsheet  \t{dummy.laun.bedsheets}\t {comboBox_bedsheet.Text}\t{dummy.laun.bedsheet_price}");


                    break;
                }
                
            }

            if(found == false)
            {
                MessageBox.Show("ID Not Found");
            }
        }
    }
}
