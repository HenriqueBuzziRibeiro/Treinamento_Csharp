Console.WriteLine("List 4");

List<string> frutas = new()
{
    "Banana", "Maça", "Pera", "Mamão", "Abacaxi"
};

var fruta0 = frutas.Find(Procura); //vai procurar pelo primeiro item que tenha um 'n'
Console.WriteLine(fruta0);

//para substituir esse predicado (função 'Procura' dentro do Find) usamos o LAMBDA '=>'
var fruta1 = frutas.Find(i=>i.StartsWith("M"));
Console.WriteLine(fruta1);

var fruta3 = frutas.FindLast(i => i.Contains('n'));
Console.WriteLine($"\nFindLast: {fruta3}");

var fruta4 = frutas.FindIndex(i=>i.Contains("n")); //vai retornar o índice
Console.WriteLine($"\nFindIndex: indice = {fruta4}   item={frutas[fruta4]}");

var fruta5 = frutas.FindLastIndex(i => i.Contains("M"));
Console.WriteLine($"\nFindLastIndex: indice = {fruta5}   item={frutas[fruta5]}");

var frutas6 = frutas.FindAll(i=>i.Contains("M"));

Console.WriteLine("\nFindAll:");
foreach(var item in frutas6)
{
    Console.WriteLine($"{item}");
}

Console.ReadKey();

static bool Procura(string item)
{
    return item.Contains('n'); //return item.StartsWith('L');
}