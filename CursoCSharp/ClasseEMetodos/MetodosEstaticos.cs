using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos
{
    public class CalculadoraEstatica
    {
        //Método de classe ou Método estático!!!
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        //Método de instância!!!
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            //chamada para  Método estático!!!
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            //chamada para  Método de instância!!!
            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine("Resultado: " + calc.Somar(2, 2));
            //Console.Read();
        }

    }
}
