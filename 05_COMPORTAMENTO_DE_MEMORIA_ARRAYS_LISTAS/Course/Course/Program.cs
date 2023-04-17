using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            // out
            int b = 10;
            int triple;
            Calculator.Triple2(b, out triple);
            Console.WriteLine(triple);

            // ref
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);





            //int s1 = Calculator.Sum(2, 3);
            //int s2 = Calculator.Sum(2, 4, 3);
            //int result = Calculator.Sum(new int[] { 10, 20, 30, 40 });

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);





            //Console.Write("How many rooms will be rented? ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //Rooms[] rooms = new Rooms[10];

            //for (int i = 0; i < n; i++) {
            //    Console.WriteLine("\nRent #{0}", i + 1);
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Email: ");
            //    string email = Console.ReadLine();
            //    Console.Write("Room: ");
            //    int room = Convert.ToInt32(Console.ReadLine());
            //    rooms[room] = new Rooms { Name = name, Email = email, Room = room };
            //}

            //Console.WriteLine("\nBusy rooms:");
            //for (int i = 0; i < rooms.Length; ++i) {
            //    if (rooms[i] != null) {
            //        Console.WriteLine(rooms[i]);
            //    }
            //}





            //int n = Convert.ToInt32(Console.ReadLine());

            //Product[] vect = new Product[n];

            //for (int i = 0; i < n; i++) {
            //    string name = Console.ReadLine();
            //    double price = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    vect[i] = new Product { Name = name, Price = price };
            //}

            //double sum = 0.0;
            //for (int i = 0; i < n; i++) {
            //    sum += vect[i].Price;
            //}

            //double avg = sum / n;
            //Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));





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