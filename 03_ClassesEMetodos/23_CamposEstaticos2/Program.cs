Console.WriteLine("Campos Estáticos 2!");

ContaCorrente c1 = new();
c1.Conta = 101;
c1.Nome = "Henrique";

ContaCorrente c2 = new();
c2.Conta = 102;
c2.Nome = "Gabriela";

ContaCorrente.Juros = 3.99f; //juros do banco é o mesmo para todas as contas

Console.WriteLine($"Cliente: {c1.Nome} - juros Anual: {c1.JurosAnual}");
Console.WriteLine($"Cliente: {c2.Nome} - juros Anual: {c2.JurosAnual}");

Console.ReadKey();

public class ContaCorrente
{
    public int Conta;
    public string? Nome;
    public static float Juros;

    public float JurosAnual()
    {
        return Juros * 12;
    }
}