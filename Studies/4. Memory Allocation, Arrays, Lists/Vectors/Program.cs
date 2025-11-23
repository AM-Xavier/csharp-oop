using System.Globalization;

namespace Vectors {
    internal class Program {
        static void Main(string[] args) {
            // Vectors are used to store multiple values in a single variable, in a single dimension.
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for(int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for(int i = 0; i < n; i++) {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("Average Height = " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
