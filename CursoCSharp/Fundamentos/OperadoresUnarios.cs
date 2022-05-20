
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);//inverte o cinal
            Console.WriteLine(!booleano);//transforma de true para false e viciversa

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2); //esse tipo de codigo não é bom, pois não traz um certo escrarecimento de facil leitura
            Console.WriteLine($"{numero1} {numero1}");
        }
    }
}