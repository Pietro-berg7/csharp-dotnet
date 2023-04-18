using System;

namespace Matrizes {
    class Program {
        static void Main(string[] args) {

            string[] values = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(values[0]);
            int m = Convert.ToInt32(values[1]);

            int[,] mat = new int[n, m];

            for (int i = 0; i < n; i++) {
                string[] line = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++) {
                    mat[i, j] = Convert.ToInt32(line[j]);
                }
            }

            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    if (mat[i, j] == number) {
                        Console.WriteLine("Position {0},{1}:", i, j);

                        if (j - 1 >= 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (j + 1 < m) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i - 1 >= 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (i + 1 < n) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }






            //int n = Convert.ToInt32(Console.ReadLine());

            //int[,] mat = new int[n, n];

            //for (int i = 0; i < n; i++) {

            //    string[] values = Console.ReadLine().Split(' ');

            //    for (int j = 0; j < n; j++) {
            //        mat[i, j] = Convert.ToInt32(values[j]);
            //    }
            //}

            //Console.WriteLine("Main diagonal:");
            //for (int i = 0; i < n; i++) {
            //    Console.Write(mat[i, i] + " ");
            //}

            //int count = 0;
            //for (int i = 0; i < n; i++) {
            //    for (int j = 0; j < n; j++) {
            //        if (mat[i, j] < 0) {
            //            count++;
            //        }
            //    }
            //}

            //Console.WriteLine("\nNegative numbers: " + count);






            //double[,] mat = new double[2, 3];

            //Console.WriteLine(mat.Length);

            //Console.WriteLine(mat.Rank);

            //Console.WriteLine(mat.GetLength(0));

            //Console.WriteLine(mat.GetLength(1));

        }
    }
}