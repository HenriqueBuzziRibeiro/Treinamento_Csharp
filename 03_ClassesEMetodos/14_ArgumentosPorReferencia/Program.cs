Console.WriteLine("Argumentos por Referência");

int x = 20;
Console.WriteLine($"Valor do x antes de passar por Dobrar {x}");

Calculo calc1 = new();
calc1.Dobrar(ref x);

Console.WriteLine($"Valor do x depois de passar por Dobrar {x}");

Console.ReadKey();

public class Calculo
{
    public void Dobrar(ref int y) //adicionar o 'ref' para se ter a referência
    {
        y *= 2;
        Console.WriteLine($"O valor do parâmetro y no método Dobrar {y}");
    }
}