using System;
using System.Collections.Generic;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.Write("Digite a nota do Aluno: ");

            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Quadro de Honra! Parabéns.");
            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("Aluno Aprovado!");
            }
            else if (nota >= 5.0)
            {
                Console.WriteLine("Aluno em Recuperação!");
            }
            else
            {
                Console.WriteLine("Te vejo na próxima..");
            }

            Console.WriteLine("Fim!!");
        }
    }
}