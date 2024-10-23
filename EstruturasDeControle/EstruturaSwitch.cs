using System;

namespace CursoCSharp.EstruturasDeControle;
public class EstruturaSwitch
{
    public static void Executar()
    {
        Console.Write("Avalie meu atendimento de 1 a 5: ");
        if (int.TryParse(Console.ReadLine(), out int nota))
        {

            var avaliacao = nota switch
            {
                0 => "Péssimo!",
                1 or 2 => "Ruim",
                3 => "Regular",
                4 => "Bom",
                5 => "Ótimo",
                _ => "Nota inválida!"
            };

            Console.WriteLine(avaliacao);
        }

        else
        {
            Console.WriteLine("Entrada inválida! Por favor, insira um número.");
        }

    }
}
