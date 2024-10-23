using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            Console.Write("Digite sua Nota: ");
            string entradaNota = Console.ReadLine();
            bool notaValida = double.TryParse(entradaNota, out double nota);

            if (!notaValida)
            {
                Console.WriteLine("Nota inválida! Por favor, digite um valor numérico.");
                return; // Saída antecipada em caso de erro
            }

            Console.Write("Você tem bom comportamento? (S/N): ");
            string entradaComportamento = Console.ReadLine().ToUpper();

            bool bomComportamento = entradaComportamento == "S";

            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de Honra!");
            }
            else
            {
                Console.WriteLine("Você foi Reprovado.");
            }
        }
    }
}

