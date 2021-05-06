using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaJurida, 0, 0, "Dan Primo");

            Console.WriteLine(minhaConta.ToString());
        }
    }
}
