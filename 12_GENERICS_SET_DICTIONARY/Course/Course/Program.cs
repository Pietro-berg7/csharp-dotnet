using Course.Entities;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.00));
            a.Add(new Product("Notebook", 1200.00));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.00);
            Console.WriteLine(a.Contains(prod));

            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p));

            //HashSet<string> set = new HashSet<string>();

            //set.Add("Maria");
            //set.Add("Alex");

            //Console.WriteLine(set.Contains("Maria"));






            //SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            //SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //// union
            //SortedSet<int> c = new SortedSet<int>(a);
            //c.UnionWith(b);
            //PrintCollection(c);

            //// intersection
            //SortedSet<int> d = new SortedSet<int>(a);
            //d.IntersectWith(b);
            //PrintCollection(d);

            //// diference
            //SortedSet<int> e = new SortedSet<int>(a);
            //e.ExceptWith(b);
            //PrintCollection(e);






            //HashSet<string> set = new HashSet<string>();

            //set.Add("TV");
            //set.Add("Notebook");
            //set.Add("Tablet");

            //Console.WriteLine(set.Contains("Notebook")); // true
            //Console.WriteLine(set.Contains("Computer")); // false

            //foreach (string p in set)
            //{
            //    Console.WriteLine(p);
            //}






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

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();
        }
    }
}