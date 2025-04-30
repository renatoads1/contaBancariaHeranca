using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBancaria.Entities
{
    public class Conta
    {
        public string Titular { get; set; }
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }
        public double Saldo { get; set; }

        public Conta() { }

        public Conta(string titular, string agencia, string contaCorrente)
        {
            Titular = titular;
            Agencia = agencia;
            ContaCorrente = contaCorrente;
            Saldo = 0.0;
        }
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }
        public  virtual void Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= (valor - 0.5);
            }
            else
            {
                Console.WriteLine("Valor de saque inválido ou saldo insuficiente.");
            }
        }
    }
}
