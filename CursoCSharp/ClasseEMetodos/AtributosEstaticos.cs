using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double proco, double desconto)        {
            Nome = nome;
            Preco = proco;
            Desconto = desconto;
        }

        public Produto()     {        }

        public double CalcularDesconto()        {
            return Preco - Preco * Desconto;
        }
    }

    class AtributosEstaticos    {
        public static void Executar() {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto()            {
                Nome = "Borracha",
                Preco = 5.3
                //, Desconto = 0.5 atributos static não faz mas parte do objeto
            };

            Produto.Desconto = 0.5; // atributo estaticos atige todos de uma vez, pois não faz mas parte do objeto.
            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.02;
            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());
        }
    }
}
