namespace Matrices {
    internal class Program {
        static void Main(string[] args) {

            // Matrices are multi-dimensional arrays that need to be defined with commas to separate the dimensions

            double[,] matrix = new double[2, 3];

            // They have three main methods to get information about them, Length, Rank and GetLength(dimension)
            // Length returns the total number of elements in the matrix
            // Rank returns the number of dimensions in the matrix
            // GetLength(dimension) returns the number of elements in the specified dimension (0-based index)

            Console.WriteLine(matrix.Length);
            Console.WriteLine(matrix.Rank);
            Console.WriteLine(matrix.GetLength(0));

        }
    }
}
