using System;
using System.Collections.Generic;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());

            if (numero >= 7.0)
            {
                Console.WriteLine("Aprovado! Mas não fez mais que sua obrigação!");
            }
            else
            {
                Console.WriteLine("Você está de recuperação! Vai estudar rapaz...");
            }
        }
    }
}
