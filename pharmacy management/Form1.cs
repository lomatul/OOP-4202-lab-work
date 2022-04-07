using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_management
{
    public partial class Form1 : Form
    {
        int Revenue=0;
        public Form1()
        {
            InitializeComponent();
        }
        List<medi> medicine = new List<medi>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_addmedi_Click(object sender, EventArgs e)
        {
             string name = textBox_mediname.Text;

            int qty = Convert.ToInt32(textBox_qty.Text);
        
            int price = Convert.ToInt32(textBox_price.Text);

            medi dummy_medicine = new medi();
            dummy_medicine.name = name;
            dummy_medicine.qty = qty;
            dummy_medicine.price = price;
           

            medicine.Add(dummy_medicine);

            MessageBox.Show("Mdicine Added");

        }
        
        private void button_showmedi_Click(object sender, EventArgs e)
        {
            listBox_medi.Items.Clear();
            listBox_medi.Items.Add(" Name " + "\t" + "Quantity" + "\t" + "Price");

            foreach ( medi medi_cine in medicine)
            {
                listBox_medi.Items.Add(medi_cine.get_medi());
            }

        }

        private void button_sellmedi_Click(object sender, EventArgs e)
        {
            string name = textBox_sellname.Text;
            int qty = Convert.ToInt32(textBox_sellqty.Text);
            //comboBox_name.item.add(medicine.name)

            foreach (medi medicine in medicine)
            {
                if (medicine.name == name) 
                {
                    medicine.qty -= Convert.ToInt32(textBox_sellqty.Text);
                    Revenue += medicine.price * (Convert.ToInt32(textBox_sellqty.Text));
                    MessageBox.Show("The medicine has been sold to the user");
                }
            }
           
        }

        private void button_showstock_Click(object sender, EventArgs e)
        {
             int amount = Convert.ToInt32(textBox_amount.Text);
             string name = textBox_sellname.Text;
             int qty = Convert.ToInt32(textBox_sellqty.Text);
             int price = Convert.ToInt32(textBox_price.Text);
            //comboBox_name.item.add(medicine.name)

            /* for (int i=0; i<medicine.Count; i++)
             {
                 if (name == medicine[i].name);
                 {
                     amount += medicine[i].price;
                     listBox_balance.Items.Add(amount);
                     break;
                 }
             } */
            listBox_balance.Items.Add(" Name " + "\t" + "Quantity" + "\t" + "Price" + "\t" + "Total Balance");

            amount += Revenue;

            foreach (medi medi_cine in medicine)
            {
                listBox_balance.Items.Add(name + "\t" + qty + "\t" + price + "\t" + amount);
            }
          





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void listBox_medi_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_medi.Items.Add("Name " + " Qty");
        }

        private void listBox_balance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
