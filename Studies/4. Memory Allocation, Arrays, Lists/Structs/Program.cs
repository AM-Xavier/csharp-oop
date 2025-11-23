namespace Structs {
    internal class Program {
        static void Main(string[] args) {
            // Structs are value types that don't require instantiation with 'new'
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            // But you can also instantiate them with 'new'
            p = new Point();
            Console.WriteLine(p);
        }
    }
}
