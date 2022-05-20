using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Animal
    {       

        public string Nome { get; set; }//propriedade

        public Animal(string nome)//construtor
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }//propriedade

        public Cachorro(string nome) : base(nome)//construtor
        {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }

        public Cachorro(string nome,double altura) : this(nome)//construtor
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"{Nome} tem {Altura}cm de altura!";
        }
    }

    class ConstrutorThis
    {
        public static void Executar()
        {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40.0);

            Console.WriteLine(spike);
            Console.WriteLine(max);
        }
    }
}
