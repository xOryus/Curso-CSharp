using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Gabriel";
            Console.WriteLine("Meu nome é: " + nome);
            // nome = 123; (Já foi definida como string, não pode ser alterada para um número)

            var idade = 22;
            Console.WriteLine("Minha idade é: " + idade + " anos");
            
            // Declarando uma variável e inicializando em dois comandos
            int a;
            a = 3;

            // Declarando e inicializando uma variável no mesmo comando
            int b = 2;
            Console.WriteLine("Resultado de A + B: " + (a + b));

        }
    }

}