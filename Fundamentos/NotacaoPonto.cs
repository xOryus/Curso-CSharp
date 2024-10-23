using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá".ToUpper().Insert(3, " World!").Replace("World", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);
            // Usa-se () no final para acessar métodos de extensão, e "Length" não precisa pois é um valor!

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
            // "?" Usado para navegação segura em objetos nullable.
        }
    }
}