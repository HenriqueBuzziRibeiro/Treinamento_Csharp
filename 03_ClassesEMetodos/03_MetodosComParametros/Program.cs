Console.WriteLine("Métodos com Parâmetros");

MinhaClasse Minha1 = new();
Minha1.Saudacao("Henrique", DateTime.Now.ToShortTimeString()); //passando os valores dos argumentos

Console.ReadKey();

public class MinhaClasse
{
    public void Saudacao(string nome, string data) //parâmetros
    {
        Console.WriteLine($"Seu nome é {nome}");
        Console.WriteLine($"A data de hoje é {data}");
    }
}




