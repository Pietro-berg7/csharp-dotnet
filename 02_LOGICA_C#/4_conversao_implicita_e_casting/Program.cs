using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);

            //double a;
            //float b;

            //a = 5.1;
            //b = (float)a;
            //Console.WriteLine(b);

            //double a;
            //int b;

            //a = 5.1;
            //b = (int)a;
            //Console.WriteLine(b);

            int a = 5;
            int b = 2;

            double result = (double) a / b;

            Console.WriteLine(result);
        }
    }
}