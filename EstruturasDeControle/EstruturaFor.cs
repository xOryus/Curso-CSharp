using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            // Exemplo de loop for com scopo de variável
            for (int i = 1; i < 10; i++) // Incrementa i de 1 em 1 até 9
            {
                Console.WriteLine($"O valor de i é {i}");
            }

            double soma = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++)
            {
                Console.Write($"Informe a nota do aluno {i}: ");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);
                soma += notaAtual;
            }

            double media = tamanhoTurma > 0 ? soma / tamanhoTurma : 0;
            Console.WriteLine($"A média da turma é {media}");
        }
    }
}