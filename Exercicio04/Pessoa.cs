using System;

namespace Exercicio04
{
    class Pessoa
    {
       public string Nome { get; set; }

       public int Idade { get; set; }

       public string Sexo { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public void fazerAniv()
       {
           Idade++;
       }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString(){
            return "Nome: " + Nome + " Idade: " + Idade + " Sexo: " + Sexo;
        }
        
    }
}
