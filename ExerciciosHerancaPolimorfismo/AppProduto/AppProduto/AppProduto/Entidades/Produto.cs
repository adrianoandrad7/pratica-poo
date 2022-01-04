using System;
using System.Collections.Generic;
using System.Text;

namespace AppProduto.Entidades
{
    class Produto
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }

        protected Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string Etiqueta()
        {
            return Nome + " $ " + Preco.ToString("F2");
        }

    }
}
