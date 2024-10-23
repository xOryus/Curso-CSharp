using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            const double PI = 3.14;

            // Área de circunferencia
            double raio = 4.5;
            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine("Área é: " + area);

            // Tipos Internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: " + salario);
        
            int menorValorInt = int.MinValue;   // Mais usado dos inteiros!
            Console.WriteLine("Menor Valor: " + menorValorInt); 

            uint populacaoBrasileira = 200_600_000;
            Console.WriteLine("População Brasileira: " + populacaoBrasileira);
        
            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Valor long: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial: " + populacaoMundial.ToString("N0"));
            //.ToString("N0") para formatar o número com separadores de grupo

            float precoComputador = 1299.99f;
            Console.WriteLine("Preco PC: " + precoComputador);

            double valorDeMercadoApple = 1_000_000_000.00;  // Mais usados dos tipos reais
            Console.WriteLine("Valor de Mercado Apple: " + valorDeMercadoApple.ToString("N0"));

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Preco Notebook: " + distanciaEntreEstrelas.ToString("N2"));

        }
    }
}