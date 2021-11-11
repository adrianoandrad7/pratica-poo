using System;

namespace Exercicio05
{
    public class Ave : Animal
    {
        private string corPena;

        public string GetCorPena()
        {
            return corPena;
        }

        public void SetCorPena(string value)
        {
            corPena = value;
        }

        public override void alimentar()
        {
            System.Console.WriteLine("Comendo frutas");
        }

        public override void emitirSom()
        {
            System.Console.WriteLine("Som de ave");
        }

        public override void locomover()
        {
            System.Console.WriteLine("Voando");
        }

        public void fazerNinho()
        {
            System.Console.WriteLine("Fazendo ninho");
        }
    }

}

