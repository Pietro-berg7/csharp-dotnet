using System;
using System.Globalization;

namespace SEGUNDO_PROBLEMA {
    class Program {
        static void Main(string[] args) {

            //Produto p = new Produto();

            //Console.WriteLine("Entre os dados do produto:");
            //Console.Write("Nome: ");
            //p.Nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //p.Preco = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //p.Quantidade = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p);

            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            //int qte = Convert.ToInt32(Console.ReadLine());
            //p.AdicionarProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);

            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser removido do estoque: ");
            //qte = Convert.ToInt32(Console.ReadLine());
            //p.RemoverProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);




            // ---- Exercício 1 ----
            //Retangulo r = new Retangulo();

            //Console.WriteLine("Entre a largura e altura do retângulo:");
            //r.Largura = Convert.ToDouble(Console.ReadLine());
            //r.Altura = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("\nAREA = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("PERIMETRO = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));




            // ---- Exercício 2 ----
            //Funcionario f = new Funcionario();

            //Console.Write("Nome: ");
            //f.Nome = Console.ReadLine();
            //Console.Write("Salário bruto: ");
            //f.SalarioBruto = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Imposto: ");
            //f.Imposto = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("\nFuncionário: " + f);

            //Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            //f.AumentarSalario(Convert.ToDouble(Console.ReadLine()));

            //Console.WriteLine("Dados atualizados: " + f);




            // ---- Exercício 3 ----
            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = Convert.ToDouble(Console.ReadLine());
            a.Nota2 = Convert.ToDouble(Console.ReadLine());
            a.Nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(a);

        }
    }
}