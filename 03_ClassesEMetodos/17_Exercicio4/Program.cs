Console.WriteLine("Exercício 4");

int potOriginal = 7;
Carro car1 = new();

double potencia = car1.AumentarPotencia(potOriginal, out double velocidade);

Console.WriteLine($"A nova potencia é {potencia}");
Console.WriteLine($"A nova velocidade é {velocidade}");

Console.ReadKey();

public class Carro
{

    public int AumentarPotencia(int potencia, out double velocidade)
    {
        potencia = potencia + 3;
        velocidade = 50 + potencia * 1.75;
        return potencia;
    }
}