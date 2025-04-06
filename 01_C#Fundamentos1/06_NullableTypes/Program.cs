Console.WriteLine("Nullable Type");

//Nullable vai suportar os valores normais dos tipos de variáveis e o 'null'

//Nullable<int> i = null;
//Nullable<int> d = null;
//Nullable<int> b = null;

//Declaração simplificada:
int? i = null;
double? d = null;
bool? b = null;

Console.WriteLine(i); //Não vai apresentar nada
Console.WriteLine(d);
Console.WriteLine(b);

//Operador de coalescência nula - operador para atribuir o valor de um Nullable a outra variável
//int? x = null;
//int y = x ?? 0; //tem que escrever assim, com '?? 0'

int? x = 4;
int? y = 3;
int? z = x*y;
Console.WriteLine(z);

//HasValue: true se tiver valor e false se não tiver valor (null)
//Value: exibe valor atribuído

int? w = 100; //se fsse null (sem valor) entraria no else

if (w.HasValue)
{
    Console.WriteLine($"w = {w.Value}");
}
else
{
    Console.WriteLine("w não possui valor (null)");
}






