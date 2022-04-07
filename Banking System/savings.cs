using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class savings: Account
    {
        public int minbalance = 0;
        public int minamount = 50000;
        public int transactionlimit = 5;
        public int charge = 15;
        public string sid;
       
       
        public static int savnumber=0;

       


        public  int Withdraw_balance(int amount)
        {
            balance = balance - amount ;
            return balance;
        }
        public  int deposite_balance(int amount)
        {
            balance = balance + amount;
            return balance;
        }

        public void sav_id()
        {
            savnumber++;
            this.sid = Convert.ToString(savnumber) + "314";

         }
        public string show_info()
        {
            return name + "\t" + sid + "\t" + type + "\t" ;

        }

    }
}
