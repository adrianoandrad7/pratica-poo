namespace AppBank.Entities
{
    class ContaEmpresa : Conta
    {
        public double LimiteEmprestimo { get; private set; }
        public ContaEmpresa()
        {
        }
        public ContaEmpresa(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }
        public void Emprestimo(double valor)
        {
            if (valor <= LimiteEmprestimo)
            {
                Saldo += valor;
            }
        }
    }
}
