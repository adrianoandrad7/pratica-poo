using System;

namespace Exercicio04
{
    class Funcionario : Pessoa
    {
      
      public string Setor { get; set; }
      public bool Trabalhando{ get; set; }

      public void mudaTrabalho()
      {
        if (Trabalhando)
          Trabalhando = false;
        else
          Trabalhando = true;
      }
        
    }
}