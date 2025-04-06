using System.ComponentModel;

Console.WriteLine("List<T> 3");

List<string> nomes = new()
{
    "Henrique", "Maria", "Pedro", "Daniel"
};

Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[2]);

nomes[0] = "Gabriel";
nomes[2] = "Ricardo";

Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[2]);

foreach (string nome in nomes)
{
    Console.Write($"{nome}  ");
}

var res1 = nomes.Contains("Henrique");
var res2 = nomes.Contains("Gabriel");

Console.WriteLine();
Console.WriteLine(res1); //vai exibir false
Console.WriteLine(res2); //vai exibit true

Console.ReadKey();