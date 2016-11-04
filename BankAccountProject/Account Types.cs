using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    public abstract class Account_Types  
    {
        //Fields
        public int accountBalance;
        protected double withdrawal;
        protected double transfer;
        protected double transactions;
       
        public int get accountBalance()
        {
            return accountBalance;
        }









    }
}
