using System;
using System.Globalization;

namespace Exercise {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char depositoInicial = Convert.ToChar(Console.ReadLine());

            if (depositoInicial == 's') {
                Console.Write("Entre o valor de depósito inicial: ");
                double valor = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, valor);
            }
            else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para depósito: ");
            double deposito = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para saque: ");
            double saque = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);


        }
    }
}