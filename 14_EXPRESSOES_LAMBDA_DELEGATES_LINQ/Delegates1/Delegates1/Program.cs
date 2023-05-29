using Delegates1.Services;
using System;

namespace Delegates1
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            BinaryNumericOperation op = CalculationService.Sum;

            //double result = op.Invoke(a, b);
            double result = op(a, b);

            Console.WriteLine(result);
        }
    }
}