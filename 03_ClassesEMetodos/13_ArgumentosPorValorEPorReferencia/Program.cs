Console.WriteLine("Argumentos por Valor");

int x = 20;
Console.WriteLine($"Valor do x antes de passar por Dobrar {x}");

Calculo calc1 = new();
calc1.Dobrar(x);

Console.WriteLine($"Valor do x depois de passar por Dobrar {x}"); //perceba que o valor de X não mudou, pois ele só mudou dentro do método, para mudar ele fora temos que passar ele por referência

Console.ReadKey();

public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2;
        Console.WriteLine($"O valor do parâmetro y no método Dobrar {y}");
    }



}




