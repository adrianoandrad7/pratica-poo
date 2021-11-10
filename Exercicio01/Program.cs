using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBanco conta01 = new ContaBanco();

            conta01.NumConta = 0001;
            conta01.Titular = "João";
            conta01.abrirConta("CC");

            ContaBanco conta02 = new ContaBanco();
            conta02.NumConta = 0002;
            conta02.Titular = "Ana";
            conta02.abrirConta("CP");
            
            conta01.depositar(100);
            conta02.depositar(500);
            conta01.sacar(100);

            conta01.estadoAtual();
            System.Console.WriteLine();
            conta02.estadoAtual();
        }
    }
}
