using System;

namespace Exercicio04
{
    class Aluno : Pessoa
    {
        public int Matricula { get; set; }
        public string Curso { get; set; }
        
        public void cancelarMatricula()
        {
            Console.WriteLine("Matrícula cancelada");
        }

    }
}