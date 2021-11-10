using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Aluno p2 = new Aluno();
            Professor p3 = new Professor();
            Funcionario p4 = new Funcionario();

            p1.Nome ="João";
            p2.Nome ="Maria";
            p3.Nome = "Pedro";
            p4.Nome ="Fabiana";

            p1.Sexo = "M";
            p4.Sexo = "F";
            p2.Idade = 18;

            p2.Curso = "Informática";
            p3.Salario = 2500.75;
            p4.Setor = "Estoque";

            //p1.receberAumento(550.20);
            // p2.mudarTrabalho();
            //p4.cancelarMatricula();
            
            System.Console.WriteLine(p1.ToString());    
            System.Console.WriteLine(p2.ToString());
            System.Console.WriteLine(p4.ToString());
            
        }
    }
}
