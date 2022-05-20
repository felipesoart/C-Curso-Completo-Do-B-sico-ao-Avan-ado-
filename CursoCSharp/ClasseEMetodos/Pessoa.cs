
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class Pessoa {
        public string Nome;
        public int Idade;

        public string Apresentar() {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }

        public void Zera() {
            Nome = "";
            Idade = 0;
        }
          

    }
}