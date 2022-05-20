using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, "World!").Replace("Word!", "Mundo!");

            Console.WriteLine(saudacao);

            Console.WriteLine("TEste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); //o ? faz no que não de erro e fique mas seguro e facio de exibir
        }
    }
}