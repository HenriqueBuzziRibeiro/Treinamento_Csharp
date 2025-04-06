Console.WriteLine("Array 3 Laço FOREACH"); //FOREACH é muito utilizado para percorrer todos os itens de um array

int[] numeros = { 1, 2, 3, 4, 5 };
string[] nomes = { "Henrique", "Gabi", "Bruno" };

foreach (int N in numeros) // pode usar 'var' foreach(var N in numeros)
{
    Console.WriteLine(N);
}

foreach (string N in nomes) // pode usar 'var' foreach(var N in nomes)
{
    Console.WriteLine(N);
}


Console.ReadKey();