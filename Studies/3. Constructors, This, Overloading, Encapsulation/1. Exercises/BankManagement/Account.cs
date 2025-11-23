using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BankManagement
{
    internal class Account
    {
        public string AccountHolder { get; private set; }
        public int AccountNumber { get; private set; }
        public double Balance { get; private set; }

        public Account(string accountHolder, int accountNumber)
        {
            AccountHolder = accountHolder;
            AccountNumber = accountNumber;
        }

        public Account(string accountHolder, int accountNumber, double balance) : this(accountHolder, accountNumber)
        {
            Balance = balance;
        }


        public void Deposit (double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public override string ToString()
        {
            return "Account: " +
                   AccountNumber +
                   " | Holder: " +
                   AccountHolder +
                   " | Balance: " +
                   Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
