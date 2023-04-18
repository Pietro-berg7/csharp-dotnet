using System;

namespace Matrizes {
    class Program {
        static void Main(string[] args) {

            Double[,] mat = new Double[2, 3];

            Console.WriteLine(mat.Length);
            
            Console.WriteLine(mat.Rank);

            Console.WriteLine(mat.GetLength(0));

            Console.WriteLine(mat.GetLength(1));


        }
    }
}