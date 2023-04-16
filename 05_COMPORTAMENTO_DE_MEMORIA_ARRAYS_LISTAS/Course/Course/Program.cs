using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            //Nullable<double> x = null;
            //double? x = null;
            //double? y = 10.0;

            //Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(y.GetValueOrDefault());

            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(y.HasValue);

            //if (x.HasValue) {
            //    Console.WriteLine(x.Value);
            //}
            //else {
            //    Console.WriteLine("X id null");
            //}

            //if (y.HasValue) {
            //    Console.WriteLine(y.Value);
            //}
            //else {
            //    Console.WriteLine("Y id null");
            //}

            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}