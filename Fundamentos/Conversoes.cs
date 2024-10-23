using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            // Conversão Implicita
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine("Convertido: {0}", quebrado);

            // Conversão Explicita
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota Truncada: {0}", notaTruncada);

            Console.Write("Digite sua idade: ");
            string IdadeString = Console.ReadLine();
            int IdadeInteiro = int.Parse(IdadeString);
            Console.WriteLine("Sua idade é: {0}", IdadeInteiro);

            IdadeInteiro = Convert.ToInt32(IdadeString);
            Console.WriteLine("Resultado: {0}", IdadeInteiro);

            Console.Write("Digite um número: ");
            bool conversao = int.TryParse(Console.ReadLine(), out int numero);
            if (conversao) {
                Console.WriteLine("Número convertido: {0}", numero);}
            else {
                Console.WriteLine("Não foi possível converter o valor para um número inteiro.");}
            
        }
    }
}