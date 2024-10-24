using System;
using System.Collections.Generic;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "OLÁ"; // A string "OLÁ" pode ser vista como ['O', 'L', 'Á']
            foreach (var letra in palavra) // O foreach começa aqui
            {
                Console.WriteLine(letra); // Para cada 'letra' em "palavra", imprime a letra.
            }

            // Exemplo de uso com uma lista de strings:
            var alunos = new string[] { "Alice", "Bob", "Carol" }; // Uma lista de strings
            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}