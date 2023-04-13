using System;
using System.Globalization;

namespace SEGUNDO_PROBLEMA {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

        }
    }
}