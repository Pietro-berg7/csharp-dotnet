using Exercise1.Entities;
using System;
using System.Globalization;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = Convert.ToChar(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'c')
                {
                    products.Add(new Product(name, price));
                }
                else if (ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double fee = Convert.ToDouble(Console.ReadLine());

                    products.Add(new ImportedProduct(name, price, fee));
                }
                else if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = Convert.ToDateTime(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, date));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");

            foreach(Product product in products) {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}