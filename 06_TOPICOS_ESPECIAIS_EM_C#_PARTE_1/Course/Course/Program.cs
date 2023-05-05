using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            double preco = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;

            desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);





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