namespace Nullable {
    internal class Program {
        static void Main(string[] args) {

            // Nullable types allow value types to represent null values,
            // it can be written in two ways:

            Nullable<double> a = null;
            double? b = null;
            double? c = 15.0;

            Console.WriteLine(a.GetValueOrDefault());
            Console.WriteLine(c.GetValueOrDefault());

            if(b.HasValue) {
                Console.WriteLine(b.Value);
            }
            else {
                Console.WriteLine("b is null.");
            }

            if(c.HasValue) {
                Console.WriteLine(c.Value);
            }
            else {
                Console.WriteLine("c is null.");
            }

            // The null-coalescing operator (??) provides a default value if the nullable type is null

            double x = a ?? 5;
            double y = c ?? 5;

            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
