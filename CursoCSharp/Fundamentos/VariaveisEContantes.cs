
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEContantes {
        public static void Executar() {
            //area da circunferencia 

            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 4;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            //tipo internos

            bool estaChovendo = true;
            Console.WriteLine("Está choventdo" + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario" + salario);

            int menorValorInt = int.MinValue; //Mais usado dos internos
            Console.WriteLine("Menor int" + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População brasileira " + populacaoBrasileira);

            long menorValor = long.MinValue;
            Console.WriteLine("Menor long " + menorValor);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Computador " + precoComputador);

            double valorDeMercadaDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor Apple " + valorDeMercadaDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entra as estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine(letra);

            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine(texto);

        }
    }
}