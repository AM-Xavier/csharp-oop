namespace TimeSpanOperations {
    internal class Program {
        static void Main(string[] args) {

            TimeSpan t1 = TimeSpan.MaxValue; // Represents the largest possible value of TimeSpan
            TimeSpan t2 = TimeSpan.MinValue; // Represents the smallest possible value of TimeSpan
            TimeSpan t3 = TimeSpan.Zero;     // Represents a TimeSpan with a value of zero

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            // Properties

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days); // Total days represented by the TimeSpan
            Console.WriteLine("Hours: " + t.Hours); // Hours component of the TimeSpan
            Console.WriteLine("Minutes: " + t.Minutes); // Minutes component of the TimeSpan
            Console.WriteLine("Milliseconds: " + t.Milliseconds); // Milliseconds component of the TimeSpan
            Console.WriteLine("Seconds: " + t.Seconds); // Seconds component of the TimeSpan
            Console.WriteLine("Ticks: " + t.Ticks); // Total ticks represented by the TimeSpan
            Console.WriteLine("TotalDays: " + t.TotalDays); // Total days represented by the TimeSpan as a double
            Console.WriteLine("TotalHours: " + t.TotalHours); // Total hours represented by the TimeSpan as a double
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes); // Total minutes represented by the TimeSpan as a double
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds); // Total seconds represented by the TimeSpan as a double
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds); // Total milliseconds represented by the TimeSpan as a double

            // Operations

            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t1.Add(t2); // Adds two TimeSpan objects
            TimeSpan dif = t1.Subtract(t2); // Subtracts one TimeSpan from another
            TimeSpan mult = t2.Multiply(2.0); // Multiplies a TimeSpan by a scalar value
            TimeSpan div = t2.Divide(2.0); // Divides a TimeSpan by a scalar value

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}
