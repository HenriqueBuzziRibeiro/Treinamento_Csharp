using partialClass;

Console.WriteLine("Partial Class"); //Permite que uma classe seja implementada em vários arquivos
//o compilador junta as 'partial class' uma com a outra, ou seja, pro compilador não muda nada, porque ele vai entender como se fosse uma unica classe

MinhaPartialClass minhaPartialClass = new();

Console.WriteLine("Idade para nascidos em 07/08/2003: \n");
var idade = minhaPartialClass.CalculaIdade(new DateTime(2003, 8, 7));
Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos");

Console.WriteLine("\nIdade par aos nascidos em 02/06/2005 \n");

var data1 = DateTime.Now;
var data2 = new DateTime(2005, 06, 02);
var diferenca = minhaPartialClass.DiferencaEntreDatas(data1, data2);
Console.WriteLine($"{Math.Round(diferenca.TotalDays / 365)} anos");

Console.ReadKey();

/*

Partial classes:
- Todas as definições devem estar no mesmo assembly, possuindo a mesma acessibilidade
- Pode aparecer em class, struct e interface
...(várias regrinhas que não compensa escrever aqui)

 */