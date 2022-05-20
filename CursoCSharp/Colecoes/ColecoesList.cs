using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;

            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Preco);
        }
    }

    class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada de Game of Throne", 99.9),
                new Produto("Poster", 10),
            };

            carrinho.AddRange(combo);//add o combo de varios produtos de uma unica vez com o AddRange ^a^c^i^m^a
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"dentro do forech {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
