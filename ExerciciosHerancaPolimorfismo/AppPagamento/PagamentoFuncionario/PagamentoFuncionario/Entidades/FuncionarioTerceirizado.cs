using System;
using System.Collections.Generic;
using System.Text;

namespace PagamentoFuncionario.Entidades
{
    class FuncionarioTerceirizado : Funcionario
    {
        public double DespesaAdicional { get; private set; }
        public FuncionarioTerceirizado()
        {

        }
        public FuncionarioTerceirizado(string nome, int horas, double valorHora,double despesaAdicional) : base(nome, horas, valorHora)
        {
           
            DespesaAdicional = despesaAdicional;
        }
        public override double PagamentoSalario()
        {
            return base.PagamentoSalario() + 1.1 * DespesaAdicional;
        }
    }
}
