using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BankAccount {
    internal class System {
        public int AccountNumber { get; private set; }
        public string AccountHolder { get; private set; }
        public double Balance { get; private set; }

        public System(int accountNumber, string accountHoulder) {
            AccountNumber = accountNumber;
            AccountHolder = accountHoulder;
        }
        public System(int accountNumber, string accountHolder, double initialDeposit) : this(accountNumber, accountHolder) {
            Deposit(initialDeposit);
        }
        public void Deposit(double amount) {
            Balance += amount;
        }
        public void Withdraw(double amount) {
            Balance -= amount + 5.0;
        }

        public override string ToString() {
            return "Account "
                + AccountNumber
                + ", Holder: "
                + AccountHolder
                + ", Balance: $ "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}