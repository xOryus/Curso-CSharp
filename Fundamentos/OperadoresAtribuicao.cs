using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            // Atribuições simples
            var num1 = 7;
            num1 += 10; // num1 = num1 + 10
            num1 -= 3; // num1 = num1 - 5
            num1 *= 5; // num1 = num1 * 2
            num1 /= 2; // num1 = num1 / 3

            Console.WriteLine("Resultado: {0}", num1);

            int a = 1;
            int b = a;

            // Operador Unario:
            a++; // a = "a + 1" (valor é 2) - Incremento
            b--; // b = "b - 1" (valor é 1) - Decremento

            Console.WriteLine($"Valor de A: {a}, Valor de B: {b}");
        }
    }
}