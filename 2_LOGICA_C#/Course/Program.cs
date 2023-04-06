using System;
using System.Globalization;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"Produtos: \n" +
                $"{produto1}, cujo preço é $ {preco1:F2}\n" +
                $"{produto2}, cujo preço é $ {preco2:F2}\n");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}\n");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}\n" +
                $"Arredondado (três casas decimais): {medida:F3}\n" +
                "Separador decimal invariant culture: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));



            //char genero = 'M';
            //int idade = 32;
            //double saldo = 10.35784;
            //string nome = "Betotle";

            //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            //Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            //Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");




            //Console.Write("Bom dia!");
            //Console.WriteLine("Boa tarde!");
            //Console.WriteLine("Boa noite!");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine(genero);
            //Console.WriteLine(idade);
            //Console.WriteLine(saldo);
            //Console.WriteLine(nome);
            //Console.WriteLine(saldo.ToString("F2"));
            //Console.WriteLine(saldo.ToString("F4"));
            //Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}