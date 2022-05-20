using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Nulllables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null;
            int? num2 = null;

            if (num1.HasValue)//tem valor?
            {
                Console.WriteLine("Valor de num: {0}", num1);
            }
            else
            {
                Console.WriteLine("A variável não possui valor.");
            }

            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try
            {
                //int x = num1.Value;// pode ter erro
                //int y = num2.Value;// pode ter erro

                int x = num1.GetValueOrDefault();// correto
                int y = num2.GetValueOrDefault();// pode ter erro
                Console.WriteLine(x + y);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
