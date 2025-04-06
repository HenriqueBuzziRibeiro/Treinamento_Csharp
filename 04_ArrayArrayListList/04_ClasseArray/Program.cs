Console.WriteLine("Classe Array");

string[] nomes = { "Ana", "Pedro", "Henrique" };
Console.WriteLine("\nExibindo o array original:");
ExibeArray(nomes);

Console.WriteLine("\nInvertendo o Array original:");
Array.Reverse(nomes); //método 'Reverse' da calsse array
ExibeArray(nomes);

Console.WriteLine("\nArray ordenado na ordem crescente:");
Array.Sort(nomes); //método 'Sort' ordena na ordem crescente, nesse caso por ser string ficará em ordem alfabética
ExibeArray(nomes);

Console.WriteLine("\nLocalizando Item no array:");
string nomeEspecifico = Console.ReadLine();
var indice = Array.BinarySearch(nomes, nomeEspecifico); //método 'BinarySearch' procura por valor procurado

if (indice >= 0) //se o indice for negativo então ele não encontrou
{
    Console.WriteLine($"{nomeEspecifico} foi encontrado no índice {indice}");
}
else
{
    Console.WriteLine($"{nomeEspecifico} não foi encontrado");
}

Console.ReadKey();

static void ExibeArray(string[] array)
{
    foreach (var n in array)
    {
        Console.WriteLine(n);
    }
}