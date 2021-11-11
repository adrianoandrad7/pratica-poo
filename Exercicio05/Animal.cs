using System;

namespace Exercicio05
{
    public abstract class Animal
    {
        protected float Peso;

        public float GetPeso()
        {
            return Peso;
        }

        public void SetPeso(float value)
        {
            Peso = value;
        }

        protected int Idade;

        public int GetIdade()
        {
            return Idade;
        }

       public void SetIdade(int value)
        {
            Idade = value;
        }

        public int Membros;

        protected int GetMembros()
        {
            return Membros;
        }

        public void SetMembros(int value)
        {
            Membros = value;
        }

        public abstract void locomover();
        public abstract void alimentar();
        public abstract void emitirSom();
    }
}
