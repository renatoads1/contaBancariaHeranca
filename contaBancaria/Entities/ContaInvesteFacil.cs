using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBancaria.Entities
{
    public class ContaInvesteFacil : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaInvesteFacil(string titular, string agencia, string contaCorrente, double taxaJuros)
            : base(titular, agencia, contaCorrente)
        {
            TaxaJuros = taxaJuros;
        }

        public void RenderJuros()
        {
            //base.Sacar(200);
            if (Saldo > 0)
            {
                double juros = Saldo * (TaxaJuros / 100);
                Saldo += juros;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para render juros.");
            }
        }

    }
}
