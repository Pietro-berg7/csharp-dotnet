using Exercise.Entities;
using Exercise.Entities.Enums;
using System;
using System.Globalization;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = Convert.ToInt32(Console.ReadLine());

            Order order = new Order
            {
                Moment = DateTime.Now,
                Status = status,
                Client = client,
            };

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string pName = Console.ReadLine();
                Console.Write("Product price: ");
                double pPrice = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int pQtd = Convert.ToInt32(Console.ReadLine());

                Product product = new Product(pName, pPrice);
                OrderItem item = new OrderItem(pQtd, pPrice, product);
                order.AddItem(item);
            }

            Console.WriteLine("\nORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}