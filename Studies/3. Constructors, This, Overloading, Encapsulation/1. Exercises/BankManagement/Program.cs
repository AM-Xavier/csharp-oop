using System.Globalization;

namespace BankManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account;

            Console.Write("Enter your account number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Do you wish to make an initial deposit? (y/n): ");
            char answer = char.Parse(Console.ReadLine());

            if (answer == 'y' || answer == 'Y')
            {
                Console.Write("Enter initial deposit amount: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new Account(name, number, initialDeposit);
            } else
            {
                account = new Account(name, number);
            }
            Console.WriteLine();
            Console.WriteLine("Account Info:");
            Console.WriteLine(account);
            Console.WriteLine();

            Console.Write("Enter an amount to deposit: ");
            double amount = double.Parse(Console.ReadLine());
            account.Deposit(amount);
            Console.WriteLine("Account Info:");
            Console.WriteLine(account);
            Console.WriteLine();

            Console.Write("Enter an amount to withdraw: ");
            amount = double.Parse(Console.ReadLine());
            account.Withdraw(amount);
            Console.WriteLine("Account Info:");
            Console.WriteLine(account);
            Console.WriteLine();
        }
    }
}
