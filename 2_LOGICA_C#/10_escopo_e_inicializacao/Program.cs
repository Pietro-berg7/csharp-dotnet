﻿using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            double preco = double.Parse(Console.ReadLine());
            //double desconto;
            double desconto = 0.0;

            if (preco > 100.0) {
                //double desconto = preco * 0.1;
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
        }
    }
}