using System;

namespace Exercicio06
{
    class Gafanhoto : Pessoa
    {
        private string Login;
        private int TotAssistido;

        public int GetTotAssistido()
        {
            return TotAssistido;
        }

        public void SetTotAssistido(int value)
        {
            TotAssistido = value;
        }

        public string GetLogin()
        {
            return Login;
        }

        public void SetLogin(string value)
        {
            Login = value;
        }

        public Gafanhoto(string nome, int idade, string sexo, string login) : base(nome, idade, sexo)
        {
            Login = login;
            TotAssistido = 0;
        }

        public override string ToString() => ("Gafanhoto " + base.ToString() + " Login: " + Login + " Total de Assistido: " + TotAssistido);

    }
}
