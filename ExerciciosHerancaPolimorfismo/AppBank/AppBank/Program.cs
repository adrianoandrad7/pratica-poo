using AppBank.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AppBank
{
   class Program
    {
        static void Main(string[] args)
        {
            List<Conta> contas = new List<Conta>();

            contas.Add(new ContaPoupanca(1001, "Alex", 500.0,0.01));
            contas.Add(new ContaEmpresa(1002, "Anna", 500.0,400.00));
            contas.Add(new ContaPoupanca(1003, "Bob", 500.0,0.01));
            contas.Add(new ContaEmpresa(1004, "Maria", 500.0,500.00));

            System.Console.WriteLine($"Saldo Total: {contas.Sum(x => x.Saldo)}");

            foreach (Conta conta in contas)
            {
                conta.Saque(10.0);
            }
            
            System.Console.WriteLine("Saldos atualizados: ");
            foreach (Conta conta in contas)
            {
                System.Console.WriteLine($"Conta: {conta.Numero}, Saldo: {conta.Saldo}");
            } 
        }
    }
}
