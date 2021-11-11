using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Mamifero m = new Mamifero();
            Reptil r = new Reptil();
            Peixe p = new Peixe();
            Ave a = new Ave();

            Cachorro c = new Cachorro();
            Canguru cg = new Canguru();
            Cobra c2 = new Cobra();
            Tartaruga   t = new Tartaruga();
            GoldFirsh gf = new GoldFirsh();
            Arara aa = new Arara();

            cg.locomover();
            cg.emitirSom();
            c.emitirSom();

                   



        }
    }
}
