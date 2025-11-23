namespace Params {
    internal class Program {
        static void Main(string[] args) {
            int s1 = Calculator.Sum(2, 4);
            int s2 = Calculator.Sum(5, 6);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
