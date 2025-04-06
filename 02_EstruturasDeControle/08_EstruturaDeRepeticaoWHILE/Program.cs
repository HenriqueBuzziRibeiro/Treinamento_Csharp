using System.ComponentModel;

Console.WriteLine("Estrutura de repetição WHILE");

while(true)
{
    Console.WriteLine("\nInforme o numero inteiro: (Para sair tecle 999)");
    
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 999)
    {
        break; //break faz sair do laço
    }

    if (numero % 2 == 2)
        Console.WriteLine($"{numero} é PAR");
    else
        Console.WriteLine($"{numero} é IMPAR");
}

Console.WriteLine("\nFim do processamento...\n\n\n");

int x = 0;
while (x < 5)
{
    int y = 0;
    while (y < 5)
    {
        Console.WriteLine($"({x},{y})");
        y++;
    }
    x++;
    Console.WriteLine();
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();






Console.ReadKey();








