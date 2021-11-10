using System;

namespace Exercicio01
{
    class ContaBanco
    {
        public int NumConta { get; set; }
        public string Tipo { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public bool Status { get; set; }

        public ContaBanco()
        {
          
        }

        public ContaBanco(int numConta, string tipo, string nome, double saldo, bool status)
        {
            this.NumConta = numConta;
            this.Tipo = tipo;
            this.Titular = nome;
            this.Saldo = saldo;
            this.Status = status;
        }

        public void estadoAtual()
        {
            Console.WriteLine("Conta: " + this.NumConta);
            Console.WriteLine("Tipo: " + this.Tipo);
            Console.WriteLine("Titular: " + this.Titular);
            Console.WriteLine("Saldo: " + this.Saldo);
            Console.WriteLine("Status: " + this.Status);
        }
           
        public void abrirConta(string tipo)
        {
            this.Tipo = tipo;
            this.Status = true;
            if (tipo == "CC")
            {
                this.Saldo = 50;
            }
            else if (tipo == "CP")
            {
                this.Saldo = 150;
            }
        }

        public void fecharConta()
        {
            if (this.Saldo > 0)
            {
                Console.WriteLine("Conta com saldo positivo, não pode ser fechada");
            }
            else if (this.Saldo < 0)
            {
                Console.WriteLine("Conta com saldo negativo, não pode ser fechada");
            }
            else
            {
                this.Status = false;
            }
        }

        public void depositar(double valor)
        {
            if (this.Status == true)
            {
                this.Saldo += valor;
                System.Console.WriteLine("Depósito realizado na conta de " + this.Titular);;
            }
            else
            {
                Console.WriteLine("Conta fechada, não pode depositar");
            }
        }

        public void sacar(double valor)
        {
            if (this.Status == true)
            {
                if (this.Saldo >= valor)
                {
                    this.Saldo -= valor;
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente");
                }
            }
            else
            {
                Console.WriteLine("Conta fechada, não pode sacar");
            }
        }
        public void pagarMensal()
        {
            if (this.Status == true)
            {
                this.Saldo -= 12;
                System.Console.WriteLine("Mensalidade paga com sucesso por " +this.Titular);
            }
            else
            {
                Console.WriteLine("Conta fechada, não pode pagar mensal");
            }
        }

    }
}
