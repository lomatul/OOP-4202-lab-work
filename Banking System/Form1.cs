using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class amountexception : Exception
        {
            public amountexception(string Message) : base(Message)
            {

            }
        }

        List<Account> ACCOUNT = new List<Account>();
        List<savings> SAVINGS = new List<savings>();
        List<Current> CURRENT = new List<Current>();
        List<Loan> LOAN = new List<Loan>();
        int bal = 0;

        private void button_add_account_Click(object sender, EventArgs e)
        {

            string mail = textBox_mail.Text;
            string name = textBox_name.Text;
            int  phone = Convert.ToInt32(textBox_phone.Text);
            string address = textBox_address.Text;
            string password = textBox_phone.Text;
            int balance = Convert.ToInt32(textBox_Balance.Text);
            string type;

            string sid;
            string cid;
            string lid;

            if (radioButton_T_savings.Checked)
            {

                if (balance < 500000)
                {
                    MessageBox.Show("Minimum Number to Create Account in 500000");
                }

                else
                {
                    type = "Savings";



                    savings dummy_acc = new savings();

                    dummy_acc.name = name;
                    dummy_acc.address = address;
                    dummy_acc.phone = phone;
                    dummy_acc.mail = mail;
                    dummy_acc.type = type;
                    dummy_acc.balance = balance;

                    dummy_acc.sav_id();



                    SAVINGS.Add(dummy_acc);

                    MessageBox.Show("Account Created");


                    MessageBox.Show("your id is" + dummy_acc.sid);

                }

            }
            else if (radioButton_T_Current.Checked)
            {
                type = "Current";
               
                Current dummy_curacc = new Current();

                dummy_curacc.name = name;
                dummy_curacc.address = address;
                dummy_curacc.phone = phone;
                dummy_curacc.mail = mail;
                dummy_curacc.type = type;
                dummy_curacc.balance = balance;

                dummy_curacc.cur_id();
            
                            
                CURRENT.Add(dummy_curacc);


                MessageBox.Show("Account Created");

               

                MessageBox.Show("Your ID is " + dummy_curacc.cid);
               
            }
            else if (radioButton_T_loan.Checked)
            {
                type = "Loan";
            

                Loan dummy_loanacc = new Loan();

                dummy_loanacc.name = name;
                dummy_loanacc.address = address;
                dummy_loanacc.phone = phone;
                dummy_loanacc.mail = mail;
                dummy_loanacc.type = type;
                dummy_loanacc.balance = balance;


                dummy_loanacc.loan_id();
               
                           
                LOAN.Add(dummy_loanacc);


                MessageBox.Show("Account Created");

               

                MessageBox.Show("Your ID is " + dummy_loanacc.lid);
                                                
            }

            else

            {


                MessageBox.Show("Enter Type");

            }


          
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(textBox_amount.Text);
            int  id = Convert.ToInt32(textBox_id.Text);
            bool f = false;
            bool g = false;
            if (amount < 0)

            {
                g = true;



                try
                {
                    if (g == true)
                    {
                        throw new amountexception("Amount Can't be Negative");
                    }

                }
                catch (amountexception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

            else
            {

                foreach (savings acc in SAVINGS)
                {
                    if (acc.sid == Convert.ToString(id))
                    {
                        f = true;

                        bal = acc.deposite_balance(amount);
                       // MessageBox.Show(Convert.ToString(acc.deposite_balance()));

                    }
                    else
                    {
                        foreach (Current curacc in CURRENT)

                        {
                            if (curacc.cid == Convert.ToString(id))
                            {
                                f = true;
                                bal = curacc.deposite_balance() + amount;
                            }
                            else
                            {
                                foreach (Loan loanacc in LOAN)
                                {
                                    if (loanacc.lid == Convert.ToString(id))
                                    {
                                        f = true;
                                        if (f == false)
                                        {
                                            MessageBox.Show("ID not Found");
                                        }
                                        else
                                        {
                                            bal = loanacc.deposite_balance() + amount;
                                        }
                                    }
                                  
                                }
                            }
                        }
                    }
                }

                 


                if (bal < 0)
                                    {
                                        f = true;

                                            try
                                            {
                                                if (f == true)
                                                {
                                                    throw new amountexception("Balance Can't be Negative");
                                                }

                                            }
                                            catch (amountexception ex)
                                            {
                                                MessageBox.Show(ex.Message);

                                            }
                                    }
                            else
                                {

                                        MessageBox.Show("Amount Deposited");

                                        MessageBox.Show("Your Balance is" + bal);
                                    }
            }

        }

        private void button_showdetails_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_id.Text);
            //int  accountid = Convert.ToInt32(textBox_account_id.Text);
            bool k = false;

          //  listBox_show.Items.Clear();

            foreach (savings acc in SAVINGS)
            {
                if (acc.sid == Convert.ToString(id))
                {
                    k = true;

                    listBox_show.Items.Add(acc.show_info() + bal);

                }
                else
                {
                    foreach (Current curacc in CURRENT)

                    {
                        if (curacc.cid == Convert.ToString(id))
                        {
                            k = true;
                            listBox_show.Items.Add(curacc.show_info() + bal);
                        }
                        else
                        {
                            foreach (Loan loanacc in LOAN)
                            {
                                if (loanacc.lid == Convert.ToString(id))
                                {
                                    k = true;
                                    listBox_show.Items.Add(loanacc.show_info() + bal);
                                }
                                else
                                {
                                    MessageBox.Show("ID not Found");
                                }
                            }
                        }
                    }
                }



            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(textBox_amount.Text);
            int id = Convert.ToInt32(textBox_id.Text);

            bool f = false;
            bool g = false;

           
            if (amount < 0)

            {
                g = true;



                try
                {
                    if (g == true)
                    {
                        throw new amountexception("Amount Can't be Negative");
                    }

                }
                catch (amountexception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }

            else
            {
                foreach (savings acc in SAVINGS)
                {
                    if (acc.sid == Convert.ToString(id))
                    {
                        f = true;

                        bal = acc.balance - amount -15;

                    }
                    else
                    {
                        foreach (Current curacc in CURRENT)

                        {


                            if (curacc.cid == Convert.ToString(id))
                            {

                                if (bal < 500)
                                {
                                    MessageBox.Show("Not Suffient Balance");

                                }
                                else
                                {
                                    f = true;
                                    bal = curacc.balance - amount;
                                }
                            }
                            else
                            {
                                foreach (Loan loanacc in LOAN)
                                {
                                    if (loanacc.lid == Convert.ToString(id))
                                    {
                                        f = true;
                                        bal = loanacc.balance - amount;
                                    }
                                    else
                                    {
                                        MessageBox.Show("ID not Found");
                                    }
                                }
                            
                            }
                        }
                    }
                }


                if (bal < 0)
                {
                    f = true;

                        try
                        {
                            if (f == true)
                            {
                                throw new amountexception("Balance Can't be Negative");
                            }

                        }
                        catch (amountexception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                }
                else
                {

                        MessageBox.Show("Amount Withdrawed");
                        MessageBox.Show("Your Balance is" + bal);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
