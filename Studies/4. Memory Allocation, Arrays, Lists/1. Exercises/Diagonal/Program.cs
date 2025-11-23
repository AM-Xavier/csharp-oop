namespace Diagonal {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Diagonals: ");
            int d = int.Parse(Console.ReadLine());

            int[,] matrix = new int[d, d];

            for(int i = 0; i < d; i++) {
                Console.Write("Line " + i + ": ");
                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < d; j++) {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Main Diagonal:");

            for(int i = 0; i < d; i++) {
                Console.Write(matrix[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;

            for(int i = 0; i < d; i++) {
                for(int j = 0; j < d; j++) {
                    if(matrix[i, j] < 0) {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative numbers: " + count);
            Console.WriteLine();

            Console.WriteLine("Matrix: ");

            for(int i = 0; i < d; i++) {
                for(int j = 0; j < d; j++) {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
