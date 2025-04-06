using CarroEnum;

Console.WriteLine("Exercicio 9");

Console.WriteLine("Escolha a cor do seu carro: ");

foreach(Cores cores in Enum.GetValues(typeof(Cores)))
{
    Console.WriteLine($"{(Cores)cores} - {(int)cores}");
}

var valorcor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Você escolheu a cor {(Cores)valorcor}");

Carro car1 = new((int)valorcor);
car1.ExibirInfo((int)valorcor);

Console.ReadKey();

public class Carro
{
    public Carro(int cor)
    {
        this.cor = cor;
    }

    public string? marca;
    public string? modelo;
    public int cor;

    public void ExibirInfo(int cor, string? marca = "Fiat", string? modelo = "Cronos")
    {
        Console.WriteLine($"O seu carro é um  {modelo} da marca {marca} e cor {(Cores)cor}\n");
    }
}