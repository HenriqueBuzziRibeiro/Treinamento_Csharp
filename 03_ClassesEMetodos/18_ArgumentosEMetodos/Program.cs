Console.WriteLine("Argumentos Nomeados");

Email email1 = new();
email1.enviar(destino: "henrique@gmail.com", titulo: "VaEstudarCara", assunto: "C# e análise de dados"); //esses são os argumentos nomeados
email1.enviar(titulo: "VaEstudarCara", assunto: "C# e análise de dados", destino: "henrique@gmail.com"); //note que a ordem não importa

Console.ReadKey();

public class Email
{
    public void enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo}. Assunto: {assunto}");
    }
}






