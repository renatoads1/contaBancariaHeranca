namespace contaBancaria.Entities
{
    public class ContaEmpresa : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaEmpresa(string titular, string agencia, string contaCorrente,double limiteEmprestimo)
            :base(titular,agencia,contaCorrente)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double valor)
        {
            if (valor > 0 && valor <= LimiteEmprestimo)
            {
                Saldo += valor;
                LimiteEmprestimo -= valor;
            }
            else
            {
                Console.WriteLine("Valor de empréstimo inválido ou limite insuficiente.");
            }
        }

        public override void Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Valor de saque inválido ou saldo insuficiente.");
            }
        }
    }
}
