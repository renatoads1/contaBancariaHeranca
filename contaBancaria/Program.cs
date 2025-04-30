
using contaBancaria.Entities;

Conta conta = new Conta("João", "1234", "56789-0");
conta.Depositar(1000);
conta.Sacar(200);
Console.WriteLine($"Titular: {conta.Titular}");
Console.WriteLine($"Agência: {conta.Agencia}");
Console.WriteLine($"Conta Corrente: {conta.ContaCorrente}");
Console.WriteLine($"Saldo: {conta.Saldo}");
ContaEmpresa contaEmpresa = new ContaEmpresa("Maria", "1234", "56789-1", 5000);
contaEmpresa.Depositar(2000);
contaEmpresa.Emprestimo(1000);
ContaInvesteFacil contaInvesteFacil = new ContaInvesteFacil("Carlos", "1234", "56789-2", 10000);


//upcasting
//subclase para super classe
Conta c1 = contaEmpresa;
Conta c2 = contaInvesteFacil;

//Downcasting
//superclase para subclase
ContaEmpresa c3 = new Conta() as ContaEmpresa;
ContaEmpresa c4 = (ContaEmpresa)conta;
if (c3 is ContaEmpresa) { 
    c3 = new Conta( "1234", "56789-1","321321321") as ContaEmpresa;
}