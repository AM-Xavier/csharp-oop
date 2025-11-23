namespace Foreach {
    internal class Program {
        static void Main(string[] args) {
            // Foreach is a way to iterate over elements in a collection without needing to manage an index variable.
            // It works the same way as a for loop in python.

            string[] vect = new string[] { "Robert", "Alex", "Alicia" };

            for(int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("----------------");

            foreach(string obj in vect) {
                Console.WriteLine(obj);
            }
        }
    }
}
