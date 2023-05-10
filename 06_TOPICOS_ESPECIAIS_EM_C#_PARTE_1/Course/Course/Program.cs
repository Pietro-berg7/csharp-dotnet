using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            TimeSpan t1 = TimeSpan.FromDays(1.5);
            TimeSpan t2 = TimeSpan.FromHours(1.5);
            TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

            //TimeSpan t1 = new TimeSpan();
            //TimeSpan t2 = new TimeSpan(900000000L);
            //TimeSpan t3 = new TimeSpan(2, 11, 21);
            //TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            //TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);






            //DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);

            //DateTime d1 = DateTime.Parse("2000-08-15");
            //DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");

            //DateTime d3 = DateTime.Parse("08/15/2000");
            //DateTime d4 = DateTime.Parse("08/15/2000 13:05:58");

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);

            //DateTime d1 = new DateTime(2018, 11, 25);
            //DateTime d2 = new DateTime(2018, 11, 25, 20,45, 3);
            //DateTime d3 = new DateTime(2018, 11, 25, 20,45, 3, 500);

            //DateTime d4 = DateTime.Now;
            //DateTime d5 = DateTime.Today;
            //DateTime d6 = DateTime.UtcNow;

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);
            //Console.WriteLine(d5);
            //Console.WriteLine(d6);






            //string original = "abcde FGHIJ ABC abc DEFG     ";

            //string s1 = original.ToUpper();
            //string s2 = original.ToLower();
            //string s3 = original.Trim();

            //int n1 = original.IndexOf("bc");
            //int n2 = original.LastIndexOf("bc");

            //string s4 = original.Substring(3);
            //string s5 = original.Substring(3, 5);

            //string s6 = original.Replace('a', 'x');
            //string s7 = original.Replace("abc", "xy");

            //bool b1 = String.IsNullOrEmpty(original);
            //bool b2 = String.IsNullOrWhiteSpace(original);

            //Console.WriteLine("Original: -" + original + "-");
            //Console.WriteLine("ToUpper: -" + s1 + "-");
            //Console.WriteLine("ToLower: -" + s2 + "-");
            //Console.WriteLine("Trim: -" + s3 + "-");
            //Console.WriteLine("IndexOf('bc'): " + n1);
            //Console.WriteLine("LastIndexOf('bc'): " + n2);
            //Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            //Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            //Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            //Console.WriteLine("IsNullOrEmpty: " + b1);
            //Console.WriteLine("IsNullOrWhiteSpace: " + b2);






            //double preco = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double desconto;

            //desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            //Console.WriteLine(desconto);






            //int x = Convert.ToInt32(Console.ReadLine());
            //string day;

            //switch (x)
            //{
            //    case 1:
            //        day = "Sunday";
            //        break;
            //    case 2:
            //        day = "Monday";
            //        break;
            //    case 3:
            //        day = "Tuesday";
            //        break;
            //    case 4:
            //        day = "Wednesday";
            //        break;
            //    case 5:
            //        day = "Thursday";
            //        break;
            //    case 6:
            //        day = "Friday";
            //        break;
            //    case 7:
            //        day = "Saturday";
            //        break;
            //    default:
            //        day = "Invalid value";
            //        break;
            //}

            //Console.WriteLine("Day: " + day);






            //var x = 10;
            //var y = 20.0;
            //var z = "Betotle";

            //int w = z; // error

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

        }
    }
}