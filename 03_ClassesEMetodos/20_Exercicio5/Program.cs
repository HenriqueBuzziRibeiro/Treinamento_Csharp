Console.WriteLine("Exercício 5");

Carro car1 = new();

car1.ExibirInfo(marca: "Fiat",montadora: "montadora", modelo: "modelo", potencia: 400);
car1.ExibirInfo(marca: "Fiat", montadora: "montadora", modelo: "modelo", potencia: 400, ano:2026);

Console.ReadKey();

public class Carro
{

    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 2025)
    {

        Console.WriteLine($"modelo = {modelo}, montadora = {montadora}, marca = {marca}, potencia = {potencia}, ano = {ano}\n");

    }
}