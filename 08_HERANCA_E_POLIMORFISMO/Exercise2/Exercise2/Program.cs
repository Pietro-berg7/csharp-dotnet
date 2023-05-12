using Exercise2.Entities;
using System;
using System.Globalization;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = Convert.ToChar(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double expend = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, income, expend));
                }
                else if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = Convert.ToInt32(Console.ReadLine());

                    list.Add(new Company(name, income, employees));
                }
            }

            double total = 0.0;
            Console.WriteLine("\nTAXES PAID:");

            foreach (TaxPayer payer in list)
            {
                Console.WriteLine(payer.Name + ": $ " + payer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                total += payer.Tax();
            }

            Console.Write("\nTOTAL TAXES: $ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}