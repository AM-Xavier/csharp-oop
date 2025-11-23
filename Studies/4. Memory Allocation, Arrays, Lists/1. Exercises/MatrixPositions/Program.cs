namespace MatrixPositions {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Enter the number of rows and columns: ");
            string[] sizes = Console.ReadLine().Split(' ');

            int r = int.Parse(sizes[0]);
            int c = int.Parse(sizes[1]);

            int[,] matrix = new int[r, c];

            for(int i = 0; i < r; i++) {
                Console.Write("Line " + i + ": ");
                string[] values = Console.ReadLine().Split(' ');

                for(int j = 0; j < c; j++) {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine();

            Console.Write("Enter the number you want to locate: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < r; i++) {
                for(int j = 0; j < c; j++) {
                    if(matrix[i, j] == n) {
                        Console.WriteLine("Position " + i + ", " + j + ":");
                        if(j > 0) {
                            Console.WriteLine("Left: " + matrix[i, j - 1]);
                        }
                        if(j < c - 1) {
                            Console.WriteLine("Right: " + matrix[i, j + 1]);
                        }
                        if(i > 0) {
                            Console.WriteLine("Up: " + matrix[i - 1, j]);
                        }
                        if(i < r - 1) {
                            Console.WriteLine("Down: " + matrix[i + 1, j]);
                        }
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine("Created matrix:");

            for(int i = 0; i < r; i++) {
                for(int j = 0; j < c; j++) {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
