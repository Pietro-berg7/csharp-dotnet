using System;

namespace MEMBROS_ESTATICOS {
    class Program {

        static double Pi = 3.14;

        static void Main(string[] args) {

            Console.Write("Entre o valor do raio: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double circ = Circunferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + vol.ToString("F2"));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2"));

        }

        static double Circunferencia(double raio) {
            return 2.0 * Pi * raio;
        }

        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }

    }
}