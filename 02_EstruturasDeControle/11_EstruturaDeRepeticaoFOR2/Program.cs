Console.WriteLine("Estrutura de repetição FOR");

for(int i = 0, j = 0; i < 10; i++, j++) //loop for com duas de inicialização e duas de interação
{
    Console.WriteLine($"i = {i} e j={j}");
}

Console.WriteLine("Fim do processamento...\n\n\n");

int k = 1;
for (; k <= 10;)
{
    Console.WriteLine($"k = {k}");
    k++;
}

Console.WriteLine("Fim do processamento");

for(int i=0; i<5; i++)
{
    for(int j=0; j<5; j++)
    {
        Console.Write($"({i},{j})");
    }
    Console.WriteLine();
}