using System;

namespace Exercicio05
{
    public class Reptil : Animal
    {
        private string corEscama;

        public string GetCorEscama()
        {
            return corEscama;
        }

        public void SetCorEscama(string value)
        {
            corEscama = value;
        }

        public override void alimentar()
        {
            System.Console.WriteLine("Comendo vegetais");
        }

        public override void emitirSom()
        {
            System.Console.WriteLine("Som de réptil");
        }

        public override void locomover()
        {
            System.Console.WriteLine("Rastejando");
        }
    }

}

