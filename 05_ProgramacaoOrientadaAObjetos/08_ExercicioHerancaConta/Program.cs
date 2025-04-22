using _08_ExercicioHerancaConta;

Console.WriteLine("Exercício Herança Conta");

Console.WriteLine($"Conta corrente : Numero : 111 Titular : Maria");
Conta conta = new();
conta.Numero = 111;
conta.Titular = "Maria";

Console.WriteLine("Depositando R$ 1.000,00");
conta.Depositar(1000);
Console.WriteLine("Sacando R$ 100,00");
conta.Sacar(100);
Console.WriteLine($"Saldo da conta: {conta.Saldo.ToString("c")}");
conta.Sacar(2000);
Console.WriteLine($"Saldo da conta: {conta.Saldo.ToString("c")}");

//vai fazendo varios testes assim com as classes Conta, ContaInvestmento e ContaPoupança


