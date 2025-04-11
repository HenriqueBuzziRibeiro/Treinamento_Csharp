Console.WriteLine("Definindo variáveis do tipo string e object e dynamic");
Console.WriteLine();

string nome = "Curso C#";
String titulo = "Curso C# Essencial";

Console.WriteLine(nome);
Console.WriteLine(titulo);

string valor = "Isto é uma string";

valor = "Isto é uma string alterada"; //quando modifica uma string dessa forma é criado uma área na memória a mais, ou seja, fica duas áreas da memória sendo ocupadas

//object e dynamic são interessantes para quando não sei qual tipo de dados usar
object nota = 10;
object valor1 = 8.55m;
object nome1 = "Henrique";
object ativa = true;
object letra = 'A';

Console.WriteLine(nota);
Console.WriteLine(nome1);
Console.WriteLine(valor1);
Console.WriteLine(ativa);
Console.WriteLine(letra);

//StringBuilder - é mais interessante de se usar do que o 'String'

Console.ReadLine();
