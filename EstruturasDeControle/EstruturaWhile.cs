using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle

{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new();

            int numeroSecreto = random.Next(1, 16);
            int tentativasRestantes = 5;

            while (tentativasRestantes > 0)
            {
                Console.Write("Insira seu palpite (entre 1 e 15): ");
                string entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out palpite) || palpite < 1 || palpite > 15)
                {
                    Console.Write("Por favor, insira um número inteiro entre 1 e 15.");
                    continue; // Sai do loop caso o palpite seja inválido!
                }

                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    var consoleAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Parabéns! Você acertou em {0} tentativas.", 5 - tentativasRestantes);
                    Console.BackgroundColor = consoleAnterior;
                    return; //Finaliza a execução quando o número secreto for acertado!
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("O número secreto é menor. Tentativas restantes: {0}", tentativasRestantes);
                }
                else
                {
                    Console.WriteLine("O número secreto é maior. Tentativas restantes: {0}", tentativasRestantes);
                }

            }

            Console.WriteLine("Você esgotou as tentativas! O número secreto era {0}.", numeroSecreto);
        }
    }
}