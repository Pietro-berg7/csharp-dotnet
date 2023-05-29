using Exercise.Entities;
using System;
using System.Globalization;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double value = Convert.ToDouble(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }
                }

                var emails = list.Where(e => e.Salary > value).OrderBy(e => e.Email).Select(e => e.Email);
                Console.WriteLine("Email of people whose salary is more than 2000.00:");

                foreach (string emp in emails)
                {
                    Console.WriteLine(emp);
                }

                var sum = list.Where(p => p.Name[0] == 'M').Sum(e => e.Salary);
                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}