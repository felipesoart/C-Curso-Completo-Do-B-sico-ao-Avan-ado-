
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadorTernario {
        public static void Executar() {
            var nota = 9.0;
            bool bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento
                ? "Aprovado" : "Reprovado";
            //primeiro é a expreção, depois a verificação = ? se for verdade vai da "Aprovado" senão = : "Reprovado"
            Console.WriteLine(resultado);
        }
    }
}