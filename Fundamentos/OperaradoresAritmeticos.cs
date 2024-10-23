using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var precoComDesconto = total - (total * desconto); // Operador prioriza a multiplicação antes da divisão!
            Console.WriteLine("Preço com Desconto: " + precoComDesconto);

            // IMC
            double peso = 91.2;
            double altura = 1.81;
            double imc = peso / Math.Pow(altura, 2); // Elevando ao quadrado
            Console.WriteLine($"IMC: {imc:F2}");

            // Número Par/Ímpar
            int par = 24;
            int impar = 25;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}