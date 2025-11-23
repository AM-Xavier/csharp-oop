using System;
using System.Globalization;

namespace DateTime {
    internal class Program {
        static void Main(string[] args) {

            // DateTime structure represents dates and times in .NET.

            DateTime d1 = DateTime.Now; // Current date and time
            Console.WriteLine(d1); 
            Console.WriteLine(d1.Ticks); // Number of ticks (100-nanosecond intervals) since January 1, 0001

            // Constructors

            DateTime d1 = new DateTime(2000, 8, 15); // Year, Month, Day
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58); // Year, Month, Day, Hour, Minute, Second
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275); // Year, Month, Day, Hour, Minute, Second, Millisecond
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            // Properties

            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.UtcNow; // Current date and time in Coordinated Universal Time (UTC)
            DateTime d3 = DateTime.Today; // Current date with time component set to 00:00:00
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            // Accessing individual components

            DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d3 = DateTime.Parse("15/08/2000");
            DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            // Parsing with specific formats

            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d1);
            Console.WriteLine(d2);

        }
    }
}
