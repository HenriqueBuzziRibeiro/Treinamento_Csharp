Console.WriteLine("Exercício 6");

Carro car1 = new();
Carro car2 = new();

car1.ExibirInfo(marca: "Fiat", montadora: "montadora", modelo: "Argo", potencia: 400);
car2.ExibirInfo(marca: "Fiat", montadora: "montadora", modelo: "Cronos", potencia: 600);

Console.WriteLine($"Valor Ipva = {Carro.valorIpva}");

Console.ReadKey();

public class Carro
{
    public static double valorIpva = 4f;

    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 2025)
    {
        Console.WriteLine($"modelo = {modelo}, montadora = {montadora}, marca = {marca}, potencia = {potencia}, ano = {ano}\n");
    }

    //public static double ObterValorIpva()
    //{
    //    return valorIpva = 4f;
    //}
}

//a palavra chave 'static' seja para atributos ou métodos faz com que o atributo ou método seja referente a classe e não ao objeto, logo só é possível chama-los usando a classe diretamente