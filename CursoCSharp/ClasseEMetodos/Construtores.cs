﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace CursoCSharp.ClasseEMetodos {
    class Carro {
        public string Fabricante;
        public string Modelo;
        public int Ano;

        public Carro(string fabricante, string modelo, int ano) {
            Fabricante = fabricante;
            Modelo = modelo;
            Ano = ano;
        }

        public Carro() {

        }
    }

        class Construtores {
        public static void Executar() {
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            Console.WriteLine(
                $"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine(
                $"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var carro3 = new Carro() {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019,
            };
            Console.WriteLine(
                $"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");

        }
    }
}