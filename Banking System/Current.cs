using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class Current: Account
    {
        public int minbalance = 500;
        public int minamount = 0;
        public int maxtransactionamount = 100000;
        public string cid;
        public int balance;
        public static int curnum = 0 ;


        public  int Withdraw_balance()
        {
            this.balance = balance - this.amount;
            return balance;
        }
        public  int deposite_balance()
        {
           this. balance = balance + this.amount;
            return balance;
        }
        public void cur_id()
        {
            curnum++;
            this.cid = Convert.ToString(curnum) + "300";

        }
        public string show_info()
        {
            return name + "\t" + cid + "\t" + type + "\t" ;

        }

    }
}
