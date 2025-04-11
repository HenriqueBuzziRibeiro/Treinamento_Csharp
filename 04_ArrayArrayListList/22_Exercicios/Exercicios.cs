Console.WriteLine("Exercícios");

#region Exercício 1

Console.WriteLine("Exercício 1");

string[] frutas = { "Maça", "Banana", "Laranja", "Uva", "Manga", "Pera", "Abacate", "Mamao", "Pessego", "Amora" };

//Exibe todas as frutas
foreach (string fruta in frutas)
{
    Console.Write($"{fruta}  ");
}

//Exibe o nome da segunda e da penúltima fruta
Console.WriteLine($"\nSegunda fruta: {frutas[1]}");
Console.WriteLine($"Penultima fruta:{frutas[8]}");

frutas[2] = "Kiwi";
frutas[9] = "Caqui";

Console.WriteLine("\nExibe as frutas, agora com Kiwi e Caqui:");
foreach (string fruta in frutas)
{
    Console.Write($"{fruta}   ");
}

Array.Sort(frutas);

Console.WriteLine("\nExibe as frutas em ordem alfabética:");
foreach (string fruta in frutas)
{
    Console.Write($"{fruta}   ");
}

Array.Reverse(frutas);

Console.WriteLine("\nExibe as frutas em ordem decrescente:");
foreach (string fruta in frutas)
{
    Console.Write($"{fruta}   ");
}

#endregion

#region Exercício 2

Console.WriteLine("\n\n\nExercício 2");

Console.WriteLine("Digite o número de itens que terá o array: ");
int itensDoArray = Convert.ToInt32(Console.ReadLine());
int[] valoresInteiros = new int[itensDoArray];

for (int i = 0; i < valoresInteiros.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}° número da lista: ");
    valoresInteiros[0] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Digite um número inteiro para pesquisar dentro do array: ");
int valorProcurado = Convert.ToInt32(Console.ReadLine());
bool achou = false;

foreach (int n in valoresInteiros)
{
    if (n == valorProcurado)
    {
        Console.WriteLine($"O número {valorProcurado} existe no array");
        achou = true;
    }
}

if (achou == false)
    Console.WriteLine($"O número {valorProcurado} não existe no array");


#endregion  

#region Exercício 3

Console.WriteLine("\n\n\nInforme as notas de 10 alunos: ");

float[,] notasMatriz = new float[2, 5];

for (int i = 0; i<notasMatriz.GetLength(0); i++)
{
    Console.WriteLine($"Informe as notas do {i + 1}° grupo: ");
    for (int j = 0;j<notasMatriz.GetLength(1); j++)
    {
        float notas = Convert.ToSingle(Console.ReadLine());
        notasMatriz[i,j] = notas;
    }
}





#endregion








Console.ReadKey();