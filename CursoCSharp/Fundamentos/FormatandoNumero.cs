
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("pt-BR");
            //CultureIofr cultura = new CultureInfor("en-US");
            Console.WriteLine(valor.ToString("C2", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));

        }
    }
}