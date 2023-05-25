using Course.Entities;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook")); // true
            Console.WriteLine(set.Contains("Computer")); // false

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }






            //Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            //Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

            //Console.WriteLine(a.Equals(b)); // true
            //Console.WriteLine(a == b); // false
            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());






            //string a = "Maria";
            //string b = "Alex";

            //Console.WriteLine(a.Equals(b));

            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());
        }
    }
}