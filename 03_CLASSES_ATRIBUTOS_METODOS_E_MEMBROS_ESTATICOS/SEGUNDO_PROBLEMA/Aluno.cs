using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEGUNDO_PROBLEMA {
    internal class Aluno {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }

        public string Resultado() {
            if (NotaFinal() >= 60.0) {
                return "\nAPROVADO";
            }
            else {
                double pontos = 60.0 - NotaFinal();
                return "\nREPROVADO\nFALTARAM "
                    + pontos.ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS";
            }
        }

        public override string ToString() {
            return "NOTA FINAL = "
                + NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                + Resultado();
        }

    }
}
