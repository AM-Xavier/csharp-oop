using System.Globalization;
using System.Security.AccessControl;

namespace TernaryConditional {
    internal class Program {
        static void Main(string[] args) {

            // Ternary conditional operator is a concise way to perform conditional assignments.
            // It takes three operands: a condition, a value if the condition is true, and a value if the condition is false.
            // The syntax is: condition ? value_if_true : value_if_false;

            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double discount = (price > 100.0) ? price * 0.5 : price * 0.25;

            Console.WriteLine(discount);
        }
    }
}
