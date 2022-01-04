using AppCalculoArea.Entidades.Enums;

namespace AppCalculoArea.Entidades
{
    abstract class Figura
    {
        public Cor Color {get; set;}

        public Figura (Cor color)
        {
            Color = color;
        }
        public abstract double Area();

    }
}
