using Enumeracoes; //o 'using' é pra usar o 'namespace'

Console.WriteLine("Enum");

Console.WriteLine(DiasDaSemana.Domingo);
Console.WriteLine(DiasDaSemana.Terca);

int dia1 = (int) DiasDaSemana.Domingo; //atribui o valor do enum (que é um int) a uma variável int
int dia2 = (int) DiasDaSemana.Terca;

Console.WriteLine($"\n{DiasDaSemana.Domingo} vale: {dia1}"); //notar que domingo vai valer 9, pois atribuimos 'Quarta = 5'
Console.WriteLine($"\n{DiasDaSemana.Terca} vale: {dia2}");

Console.WriteLine("Encerrando processo ***\n\n\n");
/* ---------------------------------------------- */

foreach (Categorias categoria in Enum.GetValues(typeof(Categorias)))
{         
    Console.WriteLine($"{(Categorias)categoria} - {(int)categoria}");
}

Console.WriteLine("Digite o valor que quer: ");
int valor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Você selecionou a categoria {(Categorias)valor}");

Console.ReadKey();

