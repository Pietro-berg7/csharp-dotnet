using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEMBROS_ESTATICOS {
    internal class ConversorDeMoeda {

        public static double IOF = 6.0;

        public static double DolarParaReal(double cotacao, double quantidade) {
            double total = cotacao * quantidade;
            return total += total * IOF / 100;
        }

    }
}
