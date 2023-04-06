using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            int a = 10;
            //int b = a++;
            int b = ++a;

            Console.WriteLine(a);
            //Console.WriteLine(b); // 10
            Console.WriteLine(b); // 11


            //int a = 10;
            //Console.WriteLine(a);

            //a += 2;
            //Console.WriteLine(a);

            //a *= 3;
            //Console.WriteLine(a);

            //string s = "ABC";
            //Console.WriteLine(s);

            //s += "DEF";
            //Console.WriteLine(s);

        }
    }
}