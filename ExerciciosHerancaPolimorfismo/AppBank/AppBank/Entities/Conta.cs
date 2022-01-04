namespace AppBank.Entities
{
    abstract class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public virtual void Saque(double montante)
        {
            Saldo -= montante + 5;
        }
        public void Deposito(double montante)
        {
            Saldo += montante;
        }
    }
}
