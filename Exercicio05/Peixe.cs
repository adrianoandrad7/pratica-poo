using System;

namespace Exercicio05
{
    public class Peixe : Animal
    {
        private string CorEscama;
        public string getCorEscama()
        {
            return CorEscama;
        }
        public void setCorEscama(string CorEscama)
        {
            this.CorEscama = CorEscama;
        }
        public override void alimentar()
        {
            System.Console.WriteLine("Comendo substâncias");
        }

        public override void emitirSom()
        {
            System.Console.WriteLine("Peixe não faz som");
        }

        public override void locomover()
        {
            System.Console.WriteLine("Nadando");
        }

        public void soltarBolha()
        {
            System.Console.WriteLine("Soltando bolha");
        }
       
    }
}
