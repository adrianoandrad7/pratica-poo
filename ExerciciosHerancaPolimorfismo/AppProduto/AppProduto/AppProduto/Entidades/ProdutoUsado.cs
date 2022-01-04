using System;
using System.Collections.Generic;
using System.Text;

namespace AppProduto.Entidades
{
    class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; private set; }
        public ProdutoUsado()
        {
        }
        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }
        public override string Etiqueta()
        {
            return Nome + " $ " + Preco.ToString("F2") + " (Data de Fabricação: " + DataFabricacao.ToString("dd/MM/yyyy") + ")";
        }
    }
}
