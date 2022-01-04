using AppCalculoArea.Entidades.Enums;

namespace AppCalculoArea.Entidades
{
    class Retangulo : Figura
    {
        public double Altura { get; private set; }
        public double Largura { get; private set; }

        public Retangulo(double altura, double largura, Cor color) : base(color)
        {
            Altura = altura;
            Largura = largura;
        }

        public override double Area()
        {
            return Altura * Largura;
        }
    }
}
