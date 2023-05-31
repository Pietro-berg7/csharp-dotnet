using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}
