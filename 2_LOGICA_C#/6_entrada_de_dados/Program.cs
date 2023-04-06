using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int rooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');

            string lastName = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2]);

            Console.WriteLine();
            Console.WriteLine(fullName);
            Console.WriteLine(rooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));




            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //string[] vet = Console.ReadLine().Split(' ');
            //string nome = vet[0];
            //char sexo = char.Parse(vet[1]);
            //int idade = int.Parse(vet[2]);
            //double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            //Console.WriteLine("\nVocê digitou: ");
            //Console.WriteLine(n1);
            //Console.WriteLine(ch);
            //Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));




            //    string frase = Console.ReadLine();
            //    string x = Console.ReadLine();
            //    string y = Console.ReadLine();
            //    string z = Console.ReadLine();

            //    string[] v = Console.ReadLine().Split(' ');
            //    string a = v[0];
            //    string b = v[1];
            //    string c = v[2];


            //    Console.WriteLine("Você digitou: ");
            //    Console.WriteLine(frase);
            //    Console.WriteLine(x);
            //    Console.WriteLine(y);
            //    Console.WriteLine(z);
            //    Console.WriteLine(a);
            //    Console.WriteLine(b);
            //    Console.WriteLine(c);
        }
    }
}