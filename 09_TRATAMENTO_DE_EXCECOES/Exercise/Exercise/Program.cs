using Exercise.Entities;
using Exercise.Entities.Exceptions;
using System;
using System.Globalization;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = Convert.ToDouble(Console.ReadLine());

                Account account = new Account(number, holder, initialBalance, withdrawLimit);

                Console.Write("\nEnter amount for withdraw: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                account.Withdraw(amount);

                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}