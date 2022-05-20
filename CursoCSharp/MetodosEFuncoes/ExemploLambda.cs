using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            //retorno é sempre void
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();
            //Func<retorno>
            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());
            //Func<parametro, retorno>
            Func<int, string> conversarHex = numero => numero.ToString("X");
            Console.WriteLine(conversarHex(1234));

            //Func<parametro,parametro,parametro, retorno>
            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/{0:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(1,1,2019));
        }
    }
}
