using System;
using System.Collections.Generic;
using System.Text;

namespace AppImpostoRenda.Entidades
{
    class PessoaFisica : ImpostoRenda
    {

        public double GastosSaude { get; private set; }
        public PessoaFisica(string nome, double rendaAnual,  double gastosSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }
        public override double CalculaImposto()
        {
            if(RendaAnual < 20000.0)
            {
                return RendaAnual * 0.15 - GastosSaude * 0.5;
            }
            else
            {
                return RendaAnual * 0.25 - GastosSaude * 0.5;
            }
        }
    }
}
