
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;//conversao explicita de double para int (int).
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.Write("Difite sua idade: ");
            string idadeString = Console.ReadLine();
            int indadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", indadeInteiro);

            indadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", indadeInteiro);

            Console.Write("Difite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);// caso digite letra o valor passado para o numero vai ser 0
            Console.WriteLine("Resultado 1: {0}", numero1);

            //outra forma de representa o exemplo de cima mas simplificado

            Console.Write("Difite o primeiro número: ");
            int.TryParse(Console.ReadLine(), out int numero2);// caso digite letra o valor passado para o numero vai ser 0
            Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }
}