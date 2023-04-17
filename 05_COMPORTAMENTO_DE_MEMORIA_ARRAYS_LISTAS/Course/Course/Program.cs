using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            int n = Convert.ToInt32(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));





            //int n = Convert.ToInt32(Console.ReadLine());

            //double[] vect = new double[n];

            //for (int i = 0; i < n; i++) {
            //    vect[i] = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}

            //double sum = 0.00;
            //for (int i = 0;i < n; i++) {
            //    sum += vect[i];
            //}

            //double avg = sum / n;

            //Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));





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

            //double? x = null;
            //double? y = 10;

            //double a = x ?? 5;
            //double b = y ?? 5;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

        }
    }
}