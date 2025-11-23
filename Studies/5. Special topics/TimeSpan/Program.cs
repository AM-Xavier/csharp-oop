<<<<<<< HEAD
namespace TimeSpans {
=======
﻿using System;

namespace TimeSpan {
>>>>>>> 831fe77c03a176160aef870a889269ced55b2a7a
    internal class Program {
        static void Main(string[] args) {

            // TimeSpan represents a time interval.
<<<<<<< HEAD
            // Different than DateTime which represents a point in time.
=======
            // Different than DateTime, which represents a specific point in time,
>>>>>>> 831fe77c03a176160aef870a889269ced55b2a7a

            TimeSpan t1 = new TimeSpan(0, 1, 30); // 0 hours, 1 minute, 30 seconds
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks); // Ticks are the smallest unit of time in .NET (100 nanoseconds)

            // Constructors 

<<<<<<< HEAD
            TimeSpan t1 = new TimeSpan(); // Zero TimeSpan
=======
            TimeSpan t1 = new TimeSpan(); // Default constructor (0 ticks)
>>>>>>> 831fe77c03a176160aef870a889269ced55b2a7a
            TimeSpan t2 = new TimeSpan(900000000L); // Ticks
            TimeSpan t3 = new TimeSpan(2, 11, 21); // Hours, Minutes, Seconds
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21); // Days, Hours, Minutes, Seconds
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321); // Days, Hours, Minutes, Seconds, Milliseconds
<<<<<<< HEAD

=======
            
>>>>>>> 831fe77c03a176160aef870a889269ced55b2a7a
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            // From methods

            TimeSpan t1 = TimeSpan.FromDays(1.5); // 1.5 days
            TimeSpan t2 = TimeSpan.FromHours(1.5); // 1.5 hours
            TimeSpan t3 = TimeSpan.FromMinutes(1.5); // 1.5 minutes
            TimeSpan t4 = TimeSpan.FromSeconds(1.5); // 1.5 seconds
            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5); // 1.5 milliseconds
            TimeSpan t6 = TimeSpan.FromTicks(900000000L); // 900 million ticks

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
        }
    }
}
