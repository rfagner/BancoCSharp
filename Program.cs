using BancoCSharp.Enums;
using BancoCSharp.Models;

Console.WriteLine("********************************************");
Console.WriteLine("*************** Banco CSharp ***************");
Console.WriteLine("********************************************");
Console.WriteLine();


var endereco = new Endereco
{
    Cep = "45895000",
    Rua = "Rua da Paz",
    Numero = 6042
};

var titular01 = new Titular("José da Silva", "12345678901", "7133014658", endereco);
var titular02 = new Titular("Maria Clara", "45645678901", "4523014658", endereco);

var conta01 = new ContaCorrente(titular01, 100.0);
var conta02 = new ContaInvestimento(titular02);
var conta03 = new ContaPoupanca(titular02);

conta01.Depositar(50.0);

conta02.Depositar(500.0);
conta02.Sacar(100.0);
conta02.Transferir(conta03, 100.0);

conta03.Sacar(25.0);

conta01.imprimirExtrato();
conta02.imprimirExtrato();
conta03.imprimirExtrato();


