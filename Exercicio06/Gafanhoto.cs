using System;

namespace Exercicio06
{
    class Gafanhoto : Pessoa
    {
        private string Login;
        private int TotAssistido;

        public Gafanhoto(string nome, int idade, string sexo, string login) : base(nome, idade, sexo)
        {
            Login = login;
            TotAssistido = 0;
        }

        public override string ToString()
        {
            return "Login: " + Login + "\nTotal de Assistido: " + TotAssistido;
        }
    }
}
