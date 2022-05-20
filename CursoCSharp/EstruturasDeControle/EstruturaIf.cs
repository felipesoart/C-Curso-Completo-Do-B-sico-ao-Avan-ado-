
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIf {
        public static void Executar() {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.Write("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //bomComportamento = true;
            bomComportamento = entrada.ToLower() == "s"; //ToLower ele serve para caso digite S em ele colocar para s

            if (nota >= 9.0 && bomComportamento) {
                Console.Write("Quadro de honra!");
            }
        }
    }
}