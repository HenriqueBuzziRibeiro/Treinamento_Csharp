Console.WriteLine("Exercício 2");

Carro carro1 = new("Sedan", "Chevrolet");
Console.WriteLine(carro1.VelocidadeMaxima(2));

Console.ReadKey();

public class Carro
{

    public Carro(string Modelo, string Montadora)
    {
        this.modelo = Modelo;
        this.montadora = Montadora;
    }

    public string? modelo;
    public string? montadora;

    public void Acelerar(string? Marca)
    {
        Console.WriteLine($"Acelerando o meu {Marca}");
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75; //irá retornar essa multiplicação pois é um método com retorno
    }
}