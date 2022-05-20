
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIfElse {
        public static void Executar() {
            double nota = 7.0;

            if (nota >= 7.0) {
                Console.WriteLine("Aprovedo!");
                Console.WriteLine("Não fez mais que sua obrigação...");
            } else {
                Console.WriteLine("Recuperação");
            }
        }
    }
}