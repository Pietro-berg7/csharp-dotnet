using System;
using System.Globalization;

namespace _03_CLASSES_ATRIBUTOS_METODOS_E_MEMBROS_ESTATICOS {
    class Program {
        static void Main(string[] args) {

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture)); 
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("Maior área: X");
            } else {
                Console.WriteLine("Maior área: Y");
            }

        }
    }
}
