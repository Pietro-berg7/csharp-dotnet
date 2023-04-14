using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEMBROS_ESTATICOS {
    internal class Calculadora {

        public static double Pi = 3.14;

        public static double Circunferencia(double raio) {
            return 2.0 * Pi * raio;
        }

        public static double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }


    }
}
