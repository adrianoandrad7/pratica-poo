using System;
using System.Collections.Generic;
using System.Text;

namespace AppProduto.Entidades
{
    class ProdutoImportado : Produto
    {
        public double Taxa { get; private set; }
        protected ProdutoImportado()
        {
        }
        public ProdutoImportado(string nome, double preco, double taxa) : base(nome, preco)
        {
            Taxa = taxa;
        }
        public double TotalPreco(){
            return Preco + Taxa;
        }
        public override string Etiqueta()
        {
            return Nome + "(Importado)" + " Valor $" + Preco + " Valor da taxa: $" + Taxa.ToString("F2") + " Valor Total $" + TotalPreco().ToString("F2");
        }
    }
}
