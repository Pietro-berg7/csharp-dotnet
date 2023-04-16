using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            // ---- Estrutura condicional - Encadeamentos ----

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if (hora >= 12 && hora < 18) {
                Console.WriteLine("Boa tarde!");
            }
            else {
                Console.WriteLine("Boa noite!");
            }




            // ---- Estrutura condicional composta ----

            //Console.WriteLine("Entre com um número inteiro:");
            //int x = int.Parse(Console.ReadLine());

            //if (x % 2 == 0) {
            //    Console.WriteLine("Par!");
            //} else {
            //    Console.WriteLine("Ímpar!");
            //}




            // ---- Estrutura condicional simples ----

            //int x = 10;

            //Console.WriteLine("Bom dia!");

            //if (x > 5) {
            //    Console.WriteLine("Boa tarde!");
            //}

            //Console.WriteLine("Boa noite!");

        }
    }
}