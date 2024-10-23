using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 8500.00;

            Console.WriteLine($"O meu {nome} é da marca {marca} e custa {preco:C}");
            Console.WriteLine($"1 + 1 =  {1 + 1}!");  // Utilizando interpolação para calcular expressões!
        }
    }
}