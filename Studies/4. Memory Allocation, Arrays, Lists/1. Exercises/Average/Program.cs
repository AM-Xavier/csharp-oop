using Average;
using System.Globalization;

namespace Vectors2 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Enter the amount of products: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Product[] vect = new Product[x];

            for(int i = 0; i < x; i++) {
                Console.Write("Enter product name: ");
                string name = Console.ReadLine();

                Console.Write("Enter product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine();

                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for(int i = 0; i < x; i++) {
                sum += vect[i].Price;
            }

            double avg = sum / x;
            Console.WriteLine("Average Price: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
