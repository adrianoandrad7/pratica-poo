using System;
using System.Collections.Generic;
using AppImpostoRenda.Entidades;
using System.Globalization;

namespace AppImpostoRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ImpostoRenda> listaImpostoRenda = new List<ImpostoRenda>();
            System.Console.Write("Entre com numero de contribuintes: ");
            int NumeroContribuintes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= NumeroContribuintes; i++)
            {
                System.Console.WriteLine($"Entre com os dados do contribuinte {i}");
                System.Console.Write("Contribuinte é pessoa fisica ou juridica? (f/j)");
                string TipoContribuinte = Console.ReadLine();

                System.Console.Write("Nome: ");
                string Nome = Console.ReadLine();
                
                System.Console.Write("Renda Anual: ");
                double RendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (TipoContribuinte == "f")
                {
                    System.Console.Write("Gastos de Saúde: ");
                    double GastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listaImpostoRenda.Add(new PessoaFisica(Nome, RendaAnual, GastosSaude));
                }
                else
                {
                    System.Console.Write("Numero de Funcionarios: ");
                    int NumeroFuncionarios = int.Parse(Console.ReadLine());
                    listaImpostoRenda.Add(new PessoaJuridica(Nome, RendaAnual, NumeroFuncionarios));
                }
            }

            double sum = 0.0;

            foreach (ImpostoRenda impostoRenda in listaImpostoRenda)
            {
                System.Console.WriteLine($"{impostoRenda.Nome} - {impostoRenda.CalculaImposto().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += impostoRenda.CalculaImposto();
            }

            System.Console.WriteLine($"Valor total de taxas: " + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
