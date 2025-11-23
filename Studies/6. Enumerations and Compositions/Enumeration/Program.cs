using Enumeration.Entities;
using Enumeration.Entities.Enums;

namespace Enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enumerations are special type used to specify in a literal manner a set of related constants.
            // By default, the underlying type of the enumeration elements is int.
            // Key-word: enum
            // enum is a value type

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // Converting to string or to enum

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // It has to have the right name, otherwise it will result in an error
            Console.WriteLine(os);
        }
    }
}
