using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            ControleRemoto controle = new ControleRemoto();
            controle.ligar();
            controle.play();
            controle.maisVolume();
            controle.abrirMenu();
            controle.desligar();

        }
    }
}
