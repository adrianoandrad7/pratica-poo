using System;

namespace Exercicio06
{
    class Video : AcoesVideo
    {
        private string Titulo;
        private int Avalicao;
        private int Views;
        private int Curtidadas;
        private bool reproduzindo;

        public bool GetReproduzindo()
        {
            return reproduzindo;
        }

        public void SetReproduzindo(bool value)
        {
            reproduzindo = value;
        }

        public Video(string titulo)
        {
            Titulo = titulo;
            Avalicao = 1;
            Views = 0;
            Curtidadas = 0;
            reproduzindo = false;
        }

        public string GetTitulo()
        {
            return Titulo;
        }

        public void SetTitulo(string value)
        {
            Titulo = value;
        }

        public int GetAvalicao()
        {
            return Avalicao;
        }

        public void SetAvalicao(int value)
        {
            int nova;
            nova = Avalicao + value / Views;
            Avalicao = value;
        }
        public int GetViews()
        {
            return Views;
        }

        public void SetViews(int value)
        {
            Views = value;
        }

        public int GetCurtidadas()
        {
            return Curtidadas;
        }

        public void SetCurtidadas(int value)
        {
            Curtidadas = value;
        }

        public void Reproduzindo()
        {
            SetReproduzindo(true);
        }

        public void play() => reproduzindo = true;

        public void pause() => reproduzindo = false;

        public void like()
        {
           Curtidadas++;
        }

       public override string ToString()
        {
            return "Titulo: " + GetTitulo() + "\nAvalicao: " + GetAvalicao() + "\nViews: " + GetViews() + "\nCurtidas: " + GetCurtidadas();
        }
    }
}
