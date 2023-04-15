using System;

namespace MEMBROS_ESTATICOS {
    class Program {
        static void Main(string[] args) {

            //Console.Write("Entre o valor do raio: ");
            //double raio = Convert.ToDouble(Console.ReadLine());

            //double circ = Calculadora.Circunferencia(raio);
            //double vol = Calculadora.Volume(raio);

            //Console.WriteLine("Circunferência: " + circ.ToString("F2"));
            //Console.WriteLine("Volume: " + vol.ToString("F2"));
            //Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2"));




            // ---- Exercício ----
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = Convert.ToDouble(Console.ReadLine());
            double valor = ConversorDeMoeda.DolarParaReal(cotacao, quantidade);

            Console.Write("Valor a ser pago em reais = " + valor.ToString("F2"));

        }
    }
}