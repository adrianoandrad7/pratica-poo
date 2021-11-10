using System;

namespace Exercicio04
{
    class Professor : Pessoa
    {
    public string Especialidade { get; set; }
    public double Salario{ get; set; }
    
    public void receberAumento(double aumento)
    {
        Salario = Salario + aumento;
    }
    }
}