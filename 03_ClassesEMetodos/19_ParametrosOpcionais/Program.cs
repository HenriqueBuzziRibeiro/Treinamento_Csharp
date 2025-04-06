using System.Collections.Specialized;

Console.WriteLine("Parâmetros opcionais");

Email email1 = new();
email1.enviar("henrique@gmail.com"); //notar que não é obrigatório informar o parâmetro de título, ele está setado como 'Reunião'
email1.enviar("gabi@gmail.com", "demissão"); //note que agora passamos o parâmetro titulo, então ele vai usar o parâmetro que foi passado
Console.ReadKey();

public class Email
{
    public void enviar(string destino, string titulo = "Reunião") //é importante salientar que os parâmetros opcionais sempre vão ser os últimos parâmetros do método
    {
        Console.WriteLine($"O email com o título '{titulo}' foi mandado para {destino}");
    }
}