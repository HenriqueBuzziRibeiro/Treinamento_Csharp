Console.WriteLine("Exercício 2");

string [,] alunos = new string[2, 5]; //declaro o tamanho da matriz mas sem preenche-lo

Console.WriteLine("Informe o nome dos alunos: ");
for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        alunos[i,j] = Console.ReadLine();
        Console.WriteLine($"A coluna {j} na linha {i} recebeu '{alunos[i,j]}'");
    }
}

Console.WriteLine("Imprimindo a matriz");

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.Write($"[{i},{j}] = {alunos[i, j]}   ");
    }
    Console.WriteLine();
}

Console.ReadKey();