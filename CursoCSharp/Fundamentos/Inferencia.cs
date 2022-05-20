
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            var nome = "felipe";//inferencia o copilador identifica o tipo interno e atribui para a variavel
            //nome = 123; uma vez atribuido o tipo ele não pode mudar de string para int
            Console.WriteLine(nome);

            // int idade;
            var idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);

        }
        
    }
}