using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // Arredondamento com 1 casa decimal
            Console.WriteLine(valor.ToString("C")); // Mostrar como monetário
            Console.WriteLine(valor.ToString("P")); // Mostrar como percentual
            Console.WriteLine(valor.ToString("#.##")); // Formatação customizada

            CultureInfo culturaBrasil = new CultureInfo("pt-BR"); // Para formatar valores em português
            Console.WriteLine(valor.ToString("C2", culturaBrasil)); // Mostrar como monetário (sem simbolo)

            int inteiro = 1400;
            Console.WriteLine(inteiro.ToString("D10")); // Mostrar como número inteiro com 10 dígitos
        }
    }
}