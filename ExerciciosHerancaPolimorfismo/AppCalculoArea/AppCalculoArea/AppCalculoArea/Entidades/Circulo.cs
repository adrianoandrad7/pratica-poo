using System;
using AppCalculoArea.Entidades.Enums;

namespace AppCalculoArea.Entidades
{
    class Circulo : Figura
    {

        public double Raio { get; private set; }
        public Circulo(double raio,Cor color) : base(color)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
