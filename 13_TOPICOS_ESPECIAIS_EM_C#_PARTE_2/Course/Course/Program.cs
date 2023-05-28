using Course.Extensions;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));

            DateTime dt = new DateTime(2023, 05, 27, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}