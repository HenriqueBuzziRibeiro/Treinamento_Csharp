Console.WriteLine("Estrutura de repetição DO WHILE");

var i = 1;
do
{
    Console.WriteLine($"i = {i}");
    i++;

    if (i > 7)
        break;

} while (i <= 10);

Console.WriteLine("Exibir coordenada do plano cartesiano: ");

int x = 0;
do
{
    int y = 0;
    do
    {
        Console.Write($"({x},{y}) ");
        y++;
    }while (y < 5);
    x++;
    Console.WriteLine(); //para pular para a linha de baixo
}while(x < 5);









Console.WriteLine("\n Fim do processamento");
Console.ReadKey();






