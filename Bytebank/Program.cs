using Bytebank.Contas;
using Bytebank.Titular;


Cliente cliente = new Cliente();
cliente.nome = "Felippe Silva";
cliente.cpf = "123456789";
cliente.profissao = "Developers";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.conta = "1010-X";
conta.numero_agencia = 15;
conta.SetSaldo (100);

Console.WriteLine("Titular = " + conta.titular.nome);
Console.WriteLine("Cpf = " + conta.titular.cpf);
Console.WriteLine("Profissao = " + conta.titular.profissao);
Console.WriteLine("Nº Conta = " + conta.conta);
Console.WriteLine("Saldo = " + conta.GetSaldo());
Console.WriteLine("Nº Agência = " + conta.numero_agencia);

ContaCorrente conta2 = new ContaCorrente();
conta2.SetSaldo (-10);
Console.WriteLine(conta2.GetSaldo());

ContaCorrente conta3 = new ContaCorrente();
conta3.SetSaldo(200);
Console.WriteLine(conta3.GetSaldo());