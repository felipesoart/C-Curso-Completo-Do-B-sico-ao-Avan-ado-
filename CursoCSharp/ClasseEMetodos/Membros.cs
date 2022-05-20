
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            //  Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");
            sicrano.ApresentarNoConsole();
            sicrano.Zera();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var apresentacaoDoFulado = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulado.Length);
            Console.WriteLine(apresentacaoDoFulado);
        }

    }
}