using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClasseEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Exececoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEContantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                //Estrutura de Controle
                { "Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                { "Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                { "Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                { "Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                { "Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                { "Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                { "Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                { "Estrutura Foreach - Estruturas de Controle", EstruturaForeach.Executar},
                { "Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                { "Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                //Classes e Métodos
                { "Membros - Classes e Métodos", Membros.Executar},
                { "Construtores - Classes e Métodos", Construtores.Executar},
                { "Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},               
                { "Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                { "Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                { "Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                { "Params - Classes e Métodos", Params.Executar},// para ter varios parametro em um unico metodo
                { "Parametros nomeados - Classes e Métodos", ParametroNomeados.Executar},// para ter varios parametro em um unico metodo
                { "Getters & Setters - Classes e Métodos", GettersSetters.Executar},// esta no video 57, aula muito grande
                { "Props - Classes e Métodos", Props.Executar},
                { "Enumerações (Enum) - Classes e Métodos", ExemploEnum.Executar},
                { "Struct - Classes e Métodos", ExemploStruct.Executar},
                { "Struct Vs Class - Classes e Métodos", StructVsClass.Executar},


                //Coleçoes
                { "Array - Coleções", Colecoes.Array.Executar},
                { "List - Coleções", ColecoesList.Executar},
                { "ArrayList - Coleções", ColecoesArrayList.Executar},
                { "Set - Coleções", ColecoesSet.Executar}, // n aceita repetição
                { "Queue - Coleções", ColecoesQueue.Executar}, //fila do inicio para o fim
                { "Igualdade - Coleções", ColecoesIgualdade.Executar},
                { "Stack - Coleções", ColecoesStack.Executar}, //pilha do fim para o inicio
                { "Dictionary - Coleções", ColecoesDictionary.Executar}, 

                //OO
                { "Heranção - OO", Heranca.Executar}, 
                { "Construtor This - OO", ConstrutorThis.Executar}, 
                { "Encapsulamento - OO", OO.Encapsulamento.Executar}, 
                { "Polimorfismo - OO", Polimorfismo.Executar}, 
                { "Abstract - OO", Abstract.Executar}, 
                { "Interface - OO", Interface.Executar}, 
                { "Sealed - OO", Sealed.Executar}, 

                //Metodos & Funções
                { "Exemplo Lambda - Metodos & Funções", ExemploLambda.Executar},
                { "Lambdas com Delegate - Metodos & Funções", LambdasDelegate.Executar},
                { "Usando Delegates - Metodos & Funções", UsandoDelegates.Executar},
                { "Delegate Fun. Anonima - Metodos & Funções", DelegateFunAnonima.Executar},
                { "Delegates Como Parametros - Metodos & Funções", DelegatesComoParametros.Executar},
                { "Metodos De Extensao - Metodos & Funções", MetodosDeExtensao.Executar},

                //Excecao
                { "Primeira Excecao - Excecao", PrimeiraExcecao.Executar},
                { "Excecoes Personalizadas - Excecao", ExcecoesPersonalizadas.Executar},

                //Api
                { "Primeiro Arquivo - Usando Api", PrimeiroArquivo.Executar}, // belo explo de como gera log.
                { "Lendo Arquivos - Usando Api", LendoArquivos.Executar}, 
                { "Exemplo FileInfo - Usando Api", ExemploFileInfo.Executar}, 
                { "Diretorios - Usando Api", Diretorios.Executar}, 
                { "Exemplo DirectoryInfo - Usando Api", Diretorios.Executar}, 
                { "Exemplo Path - Usando Api", ExemploPath.Executar}, 
                { "Exemplo DateTime - Usando Api", ExemploDateTime.Executar}, 
                { "Exemplo TimeSpan - Usando Api", ExemploTimeSpan.Executar}, 

                //Tópicos Avançados
                { "LINQ #01 - Tópicos Avançados", LONQ1.Executar}, 
                { "LINQ #02 - Tópicos Avançados", LONQ2.Executar}, 
                { "Nulllables - Tópicos Avançados", Nulllables.Executar}, 
                { "Dynamics - Tópicos Avançados", Dynamics.Executar}, 
                { "Generics - Tópicos Avançados", Generics.Executar}, 

            });

            central.SelecionarEExecutar();
        }
    }
}