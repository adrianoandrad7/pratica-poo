using System;

namespace Exercicio03
{
    class Pessoa
    {
        public String Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public Pessoa(string nome, int idade, string sexo)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
        }

        public void fazerAniversario()
        {
            Idade++;
        }    

    }
}
