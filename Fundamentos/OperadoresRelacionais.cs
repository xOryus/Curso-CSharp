using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            Console.Write("Sua Nota: ");
            double notaDeCorte = 7.0;
            if (double.TryParse(Console.ReadLine(), out double nota)){
            }
            else {
                Console.WriteLine("Valor inválido, digite novamente!");
            }

            Console.WriteLine("Nota Invalida? {0}", nota > 10.0);  // Verifica se a nota é maior que 10
            Console.WriteLine("Nota Invalida? {0}", nota < 10.0);   // Verifica se a nota é menor que 10
            Console.WriteLine("Nota Perfeita? {0}", nota == 10.0);   // Verifica se a nota é igual a 10
            Console.WriteLine("Tem como Melhorar? {0}", nota != 10);   // Verifica se a nota é diferente de 10
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);   // Verifica se a nota é maior ou igual a 7
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);    // Verifica se a nota é menor que 7
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);   // Verifica se a nota é menor ou igual a 3
        }
    }
}