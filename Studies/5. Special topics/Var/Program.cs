namespace Var {
    internal class Program {
        static void Main(string[] args) {

            // Var is a keyword that allows the compiler to infer the type of a variable at compile time based on the assigned value

            var x = 10;
            var y = 20.0;
            var z = "Mary";

            // The only problem is that you can't change the type of the variable after its declaration
            int b = z; // This will cause a compile-time error

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(b);
        }
    }
}
