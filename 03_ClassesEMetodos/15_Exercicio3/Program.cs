Console.WriteLine("Exercício 3");

int potOriginal = 5;
Carro car1 = new();

Console.WriteLine($"A potencia antes de entrar no  é {potOriginal}");
car1.AumentarPotencia(potOriginal);
Console.WriteLine($"A potencia depois de sair do método é {potOriginal}");

Console.WriteLine($"A potencia antes de entrar no é método {potOriginal}");
car1.AumentarPotencia(ref potOriginal);
Console.WriteLine($"A potencia depois de sair do método é {potOriginal}");

Console.ReadKey();

public class Carro
{

    public int AumentarPotencia(int potencia)
    {
        potencia = potencia + 3;
        Console.WriteLine($"A potencia depois de aumentada é {potencia}, dentro do método");
        return potencia;
    }

    public int AumentarPotencia(ref int potencia)
    {
        potencia = potencia + 3;
        Console.WriteLine($"A potencia depois de aumentada é {potencia}, dentro do método");
        return potencia;
    }
}