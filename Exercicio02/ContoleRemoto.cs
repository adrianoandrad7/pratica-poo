using System;

namespace Exercicio02
{
    class ControleRemoto
    {
        public int Volume { get; set; }
        public bool Ligado { get; set; }
        public bool Tocando { get; set; }

        public ControleRemoto()
        {
            Volume = 50;
            Ligado = true;
            Tocando = false;
        }

        public void maisVolume()
        {
            if (Ligado && Tocando)
            {
                Volume += 5;
            }
            else
            {
                System.Console.WriteLine("Impossível aumentar volume");
            }
        }

        public void diminuirVolume()
        {
            if (Ligado && Tocando)
            {
                Volume -= 5;
            }
            else
            {
                System.Console.WriteLine("Impossível diminuir volume");
            }
        }

        public void ligar()
        {
            if (!Ligado)
            {
                Ligado = true;
            }
        }

        public void abrirMenu()
        {

            if (Ligado)
            {
                System.Console.WriteLine("-----Menu-----");
                System.Console.WriteLine("Está ligado? " + Ligado);
                System.Console.WriteLine("Está tocando? " + Tocando);
                System.Console.WriteLine("Volume: " + Volume);
                for (int i = 0; i < Volume; i++)
                {
                    System.Console.Write("|");
                }
                System.Console.WriteLine();
            }
            else
            {
                System.Console.WriteLine("Impossível abrir menu");
            }

        }

        public void fecharMenu()
        {
            System.Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            System.Console.ReadKey();
            abrirMenu();
        }

        public void desligar()
        {
            if (Ligado)
            {
                Ligado = false;
            }
        }

        public void ligarMudo()
        {
            if (Ligado && Tocando)
            {
                Volume = 0;
            }
        }

        public void desligarMudo()
        {
            if (Ligado && Tocando)
            {
                Volume = 50;
            }
        }

        public void play()
        {
            if (Ligado && !Tocando)
            {
                Tocando = true;
            }
        }

        public void pause()
        {
            if (Ligado && Tocando)
            {
                Tocando = false;
            }
            else
            {
                System.Console.WriteLine("Impossível pausar");
            }
        }


        public override string ToString()
        {
            return $"Está ligado? {Ligado} Está tocando? {Tocando} O volume está em {Volume}";
        }

    }
}
