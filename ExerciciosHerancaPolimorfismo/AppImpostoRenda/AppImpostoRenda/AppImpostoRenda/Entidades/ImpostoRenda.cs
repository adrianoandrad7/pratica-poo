using System;
using System.Collections.Generic;
using System.Text;

namespace AppImpostoRenda.Entidades
{
    abstract class ImpostoRenda
    {
        public string Nome { get; private set; }
        public double RendaAnual { get; private set; }
        public ImpostoRenda(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }
        public abstract double CalculaImposto();
    }
}
