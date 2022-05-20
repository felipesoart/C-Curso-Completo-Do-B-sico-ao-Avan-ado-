using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public abstract class Celular
    {
        public abstract string Assistente();

        public string Totar()
        {
            return "Trim trinm trim...";
        }
    }

    public class SamSung : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Bixby!";
        }
    }

    public class IPhone : Celular
    {
        public override string Assistente()
        {
            return "Olá! Meu nome é Siri!";
        }
    }

    class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new IPhone(),
                new SamSung()
            };

            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
