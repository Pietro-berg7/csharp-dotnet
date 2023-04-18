using System;

namespace Matrizes {
    class Program {
        static void Main(string[] args) {

            int n = Convert.ToInt32(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) {
                    mat[i, j] = Convert.ToInt32(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }

            int count = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        count++;
                    }
                }
            }

            Console.WriteLine("\nNegative numbers: " + count);



            //double[,] mat = new double[2, 3];

            //Console.WriteLine(mat.Length);

            //Console.WriteLine(mat.Rank);

            //Console.WriteLine(mat.GetLength(0));

            //Console.WriteLine(mat.GetLength(1));

        }
    }
}