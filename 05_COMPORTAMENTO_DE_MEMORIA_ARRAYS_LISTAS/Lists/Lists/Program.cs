using System;
using System.Globalization;

namespace Lists {
    class Program {
        static void Main(string[] args) {

            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Employee #{0}:", i + 1);

                Console.Write("Id: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee (id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int findId = Convert.ToInt32(Console.ReadLine());

            Employee exists = list.Find(x => x.Id == findId);

            if (exists != null) {
                Console.Write("Enter the percentage: ");
                double percentage = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                exists.increaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exists!");
            }

            Console.WriteLine("\nUpdated list of employees:");
            foreach(Employee emp in list) {
                Console.WriteLine(emp);
            }





            //List<string> list = new List<string>();

            //list.Add("Maria");
            //list.Add("Alex");
            //list.Add("Bob");
            //list.Add("Ana");
            //list.Insert(2, "Marco");

            //foreach (string obj in list) {
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine("List count: " + list.Count);

            //string s1 = list.Find(x => x[0] == 'A');
            //Console.WriteLine("First 'A': " + s1);

            //string s2 = list.FindLast(x => x[0] == 'A');
            //Console.WriteLine("Last 'A': " + s2);

            //int pos1 = list.FindIndex(x => x[0] == 'A');
            //Console.WriteLine("First position 'A': " + pos1);

            //int pos2 = list.FindLastIndex(x => x[0] == 'A');
            //Console.WriteLine("Last position 'A': " + pos2);

            //List<string> list2 = list.FindAll(x => x.Length == 5);
            //Console.WriteLine("-------------------------------");
            //foreach (string obj in list2) {
            //    Console.WriteLine(obj);
            //}

            //list.Remove("Alex");
            ////list.RemoveAt(3);
            ////list.RemoveRange(2, 2);
            //Console.WriteLine("-------------------------------");
            //foreach (string obj in list) {
            //    Console.WriteLine(obj);
            //}

            //list.RemoveAll(x => x[0] == 'M');
            //Console.WriteLine("-------------------------------");
            //foreach (string obj in list) {
            //    Console.WriteLine(obj);
            //}

        }
    }
}