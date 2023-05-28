using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int code = Convert.ToInt32(Console.ReadLine());
                courseA.Add(code);
            }

            Console.Write("How many students for course B? ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int code = Convert.ToInt32(Console.ReadLine());
                courseB.Add(code);
            }

            Console.Write("How many students for course C? ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int code = Convert.ToInt32(Console.ReadLine());
                courseC.Add(code);
            }

            HashSet<int> all = new HashSet<int>(courseA);

            all.UnionWith(courseB);
            all.UnionWith(courseC);

            Console.WriteLine("Total students: " + all.Count);
        }
    }
}