using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(4);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);
            
            foreach (var item in pilha)
            {
                Console.WriteLine($"{item} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()} remove da pilha");

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item} ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()} pega o primeiro da pilha mas n remove");
            Console.WriteLine(pilha.Count);

        }
    }
}
