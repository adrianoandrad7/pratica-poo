namespace AppBank.Entities
{
    sealed class ContaPoupanca : Conta
    {
        public double Juros { get; private set; }
        public ContaPoupanca()
        {
        }
        public ContaPoupanca(int numero, string titular, double saldo, double juros) : base(numero, titular, saldo)
        {
            Juros = juros;
        }
        public void AtualizaContaPoupanca()
        {
            Saldo += Saldo * Juros;
        }

        public sealed override void Saque(double montante)
        {
            base.Saque(montante);
            Saldo -= 2.0;
        }
    }
}
