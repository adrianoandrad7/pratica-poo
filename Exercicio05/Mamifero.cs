using System;

namespace Exercicio05
{
    public class Mamifero : Animal
    {
        private string corPelo;

        public string GetcorPelo()
        {
            return corPelo;
        }

        public void SetcorPelo(string value)
        {
            corPelo = value;
        }

        public override void alimentar()
        {
            System.Console.WriteLine("Mamando");
        }

        public override void emitirSom()
        {
           System.Console.WriteLine("Som de mamifero");
        }

        public override void locomover()
        {
            System.Console.WriteLine("Locomovendo");
        }
    }
}
