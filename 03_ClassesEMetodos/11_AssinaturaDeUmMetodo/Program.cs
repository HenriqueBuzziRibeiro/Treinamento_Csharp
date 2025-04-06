Console.WriteLine("Assinatura de um método");

Email email1 = new();
email1.Enviar("Endereco aleatório", 10); //execute em debug para ver funcionando, note que irá para o enviar da linha 20

Console.ReadKey();

public class Email
{
    public void Enviar(string endereco)
    {
        Console.WriteLine($"{endereco}");
    }

    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
    }
    public void Enviar(string endereco, decimal valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{valor}");
    }
    public void Enviar(decimal valor, string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{valor}");
    }

    //Perceba que a assinatura do método é dada pela quantidade de parâmetros, o tipo de parâmetro e também a ordem dos parâmetros
}