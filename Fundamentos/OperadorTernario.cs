using System;
using System.Collections.Generic;

namespace CursoCSharp.Fundamentos;

class OperadorTernario
{
    public static void Executar()
    {
        bool bomComportamento = true;
        Console.Write("Sua Nota: ");
            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                bool temNotaAlta = nota >= 9;
                var resultado = temNotaAlta && bomComportamento ? "Você foi Aprovado" : "Você foi Reprovado";
                Console.WriteLine(resultado);
            }
            else {
                Console.WriteLine("Valor inválido, digite novamente!");
            }
    }
}
