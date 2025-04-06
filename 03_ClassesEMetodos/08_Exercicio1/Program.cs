Console.WriteLine("Exercício 1");

Carro carro1 = new("Sedan", "Chevrolet", "Onix", "2016", 110);
Carro carro2 = new("SUV", "Ford", "EcoSport", "2018", 120);

carro1.Acelerar(carro1.marca);
carro2.Acelerar(carro2.marca);

Console.ReadKey();

public class Carro
{

    public Carro(string modelo, string montadora, string marca, string ano, int potencia)
    {
        this.modelo = modelo;
        this.montadora = montadora;
        this.marca = marca;
        this.ano = ano;
        this.potencia = potencia;
    }

    public string? modelo;
    public string? montadora;
    public string? marca;
    public string? ano;
    public int potencia;

    public void Acelerar(string? Marca)
    {
        Console.WriteLine($"Acelerando o meu {Marca}");
    }
}