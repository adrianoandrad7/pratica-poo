using System;
using System.Collections.Generic;
using AppProduto.Entidades;

namespace AppProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            System.Console.Write("Informe o numero de produtos: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++ ){
                System.Console.WriteLine($"Informações do Produto {i}:");
                System.Console.Write("Informe o nome do produto: ");
                string nome = Console.ReadLine();
                System.Console.Write("Informe o preco do produto: ");
                double preco = double.Parse(Console.ReadLine());
                
                System.Console.Write("Informe o tipo do produto: c/u/i: ");
                string tipo = Console.ReadLine();
                if(tipo == "u"){
                    System.Console.Write("Informe a data de fabricacao do produto: ");
                    DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoUsado(nome, preco, dataFabricacao));
                }else if (tipo == "i"){
                    System.Console.Write("Informe a taxa do produto: ");
                    double taxa = double.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoImportado(nome, preco, taxa));
                }else{
                    produtos.Add(new Produto(nome, preco));
                }
            }

            foreach(Produto p in produtos){
                System.Console.WriteLine(p.Etiqueta());
            }
        }
    }
}
