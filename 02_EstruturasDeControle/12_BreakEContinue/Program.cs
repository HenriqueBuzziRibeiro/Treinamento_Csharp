Console.WriteLine("Break e Continue");

for (; ; )
{
    Console.WriteLine("Tecle algo (X sai)");
    var opcao = Console.ReadLine();

    if (opcao == "X" || opcao == "x") 
    { 
        Console.WriteLine("Tchau...");
        break;
    }
}

Console.WriteLine("Fim do processamento...");

for(int i =1; i<=10; i++)
{
    if (i == 4)
        continue; //o 'continue' vai interromper essa repetição do for/while e passar par aa próxima
                  //tem que cuidar com o uso do 'continue' no WHILE, para não ficar em um looping infinito
    Console.WriteLine(i);
}

Console.WriteLine("\nFim do processamento...\n\n\n");

for (int i = 1; i <= 10; i++)
{
    if (i == 5)
        continue;
    if (i == 8)
        break;
    Console.WriteLine(i);
}

Console.WriteLine("\nFim do processamento...\n\n\n");
Console.ReadKey();