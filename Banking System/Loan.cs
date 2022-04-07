using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class Loan : Account
    {
        public string lid;
        public int balance;
        public static int loannum=0;
     



        public  int Withdraw_balance()
        {
           this.balance =balance  -this.amount;
            return balance;
        }
        public  int deposite_balance()
        {
            this.balance = balance + this.amount;
            return balance;
        }
        public void loan_id()
        {
            loannum++;
            this.lid = Convert.ToString(loannum) + "400";


        }
        public string show_info()
        {
            return name + "\t" + lid + "\t" + type + "\t" ;

        }



    }
}
