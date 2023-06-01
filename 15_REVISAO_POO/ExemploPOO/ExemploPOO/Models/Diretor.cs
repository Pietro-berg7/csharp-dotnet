using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    internal class Diretor : Professor  // erro se professor for sealed
    {
        public override void Apresentar() // erro se Apresentar for sealed
        {
            Console.WriteLine("Diretor");
        }
    }
}
