﻿using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV 4K";
            // p.Preco = 100.0;

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

        }
    }
}
