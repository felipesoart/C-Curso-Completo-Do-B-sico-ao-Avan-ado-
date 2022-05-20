using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exececoes
{
    public class Conta
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente.");
            }

            Saldo -= valor;
        }
    }

    class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_223.45);

            try
            {
                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");
            }
            catch (Exception ex)//caso hajá problema no trya vai no catch vai ter a mensagem do erro
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally //embora caia no catch o codigo qm esta no finally vai ser executado
            {
                Console.WriteLine("obrigado");
            }
        }
    }
}
