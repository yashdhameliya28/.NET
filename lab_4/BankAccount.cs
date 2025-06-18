using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class BankAccount
    {
        int balance;
        string accountHolderName;

        public BankAccount(int balance, string accountHolderName)
        {
            this.balance = balance;
            this.accountHolderName = accountHolderName;
        }

        public void deposite(int balance)
        {
            this.balance += balance;
        }

        public void withdraw(int balance)
        {
            this.balance -= balance;
        }

        public void deposite(int balance, int checkNo)
        {
            this.balance += balance;
        }

        public void withdraw(int balance, int checkNo)
        {
            this.balance -= balance;
        }
    }
}
