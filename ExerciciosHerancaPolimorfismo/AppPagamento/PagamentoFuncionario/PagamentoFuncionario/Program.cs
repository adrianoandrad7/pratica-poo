using PagamentoFuncionario.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace PagamentoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();

            Console.WriteLine("Quantos funcionarios a pagar? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Funcionario #{i}:");
                Console.Write("Digite o nome do Funcionário: ");
                string nome = Console.ReadLine();
                System.Console.Write("Digite as horas trabalhadas: ");
                int horas = int.Parse(Console.ReadLine());
                System.Console.Write("Digita valor por hora: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                System.Console.Write("Funcionario é terceirizado? (s/n)");
                if(Console.ReadLine() == "s")
                {
                    System.Console.Write("Digite o valor da despesa: ");
                    double despesa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new FuncionarioTerceirizado(nome, horas,valorHora, despesa));
                }
                else
                {
                    list.Add(new Funcionario(nome,horas, valorHora));
                }
            }

            foreach(Funcionario func in list)
            {
                System.Console.WriteLine("Nome funcionário: " + func.Nome);
                System.Console.WriteLine("Salário Funcionário: R$" + func.PagamentoSalario().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
