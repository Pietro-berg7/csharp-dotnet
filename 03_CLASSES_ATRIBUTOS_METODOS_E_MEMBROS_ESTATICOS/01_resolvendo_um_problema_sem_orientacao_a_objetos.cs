using System;
using System.Globalization;

namespace CLASSES_ATRIBUTOS_METODOS_E_MEMBROS_ESTATICOS {
    class resolvendo_um_problema_sem_orientacao_a_objetos {
        static void Main(string[] args) {

            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X:");
            xA = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            yA = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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
