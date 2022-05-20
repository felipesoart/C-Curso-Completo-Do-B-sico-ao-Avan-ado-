using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{

    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada de Game of Throne", 99.9),
                new Produto("Poster", 10),
            };

            carrinho.UnionWith(combo);//add o combo de varios produtos de uma unica vez com o AddRange ^a^c^i^m^a
            Console.WriteLine(carrinho.Count);
          //  carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
               // Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"dentro do forech {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);// HashSet n permite repetições #######
            //Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
