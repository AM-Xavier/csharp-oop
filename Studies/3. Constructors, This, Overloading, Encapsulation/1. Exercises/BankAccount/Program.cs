using System.ComponentModel;
using System.Globalization;

namespace BankAccount {
    internal class Program {
        static void Main(string[] args) {
            System system;

            Console.Write("Enter account number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter account holder: ");
            string accountHolder = Console.ReadLine();
            Console.Write("Will there be an initial deposit? (y/n) ");
            char response = char.Parse(Console.ReadLine());
            if (response == 'y' || response == 'Y') {
                Console.Write("Enter initial deposit value: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                system = new System(accountNumber, accountHolder, initialDeposit);
            }
            else { 
                system = new System(accountNumber, accountHolder);
            }
            
            Console.WriteLine();
            Console.WriteLine("Account info:");
            Console.WriteLine(system);

            Console.Write("Enter deposit amount: ");
            double amount = int.Parse(Console.ReadLine());
            system.Deposit(amount);
            Console.WriteLine("Update account info:");
            Console.WriteLine(system);

            Console.Write("Enter deposit withdrawal: ");
            amount = int.Parse(Console.ReadLine());
            system.Withdraw(amount);
            Console.WriteLine("Update account info:");
            Console.WriteLine(system);

        }
    }
}
