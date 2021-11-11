using System;

namespace Exercicio06
{
    class Pessoa 
    {
        private string Nome;
        private int Idade;
        private string Sexo;

        private float Experiencia;

        public Pessoa(string nome, int idade, string sexo)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
            Experiencia = 0;
        }
        public float GetExperiencia()
        {
            return Experiencia;
        }
        public void SetExperiencia(float value)
        {
            Experiencia = value;
        }
        public string GetSexo()
        {
            return Sexo;
        }

        public void SetSexo(string value)
        {
            Sexo = value;
        }

        public int GetIdade()
        {
            return Idade;
        }

        public void SetIdade(int value)
        {
            Idade = value;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string value)
        {
            Nome = value;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\nIdade: " + Idade + "\nSexo: " + Sexo + "\nExperiencia: " + Experiencia;
        } 

    }
}
