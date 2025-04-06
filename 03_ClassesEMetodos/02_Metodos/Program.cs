Console.WriteLine("Métodos");

MinhaClasse Meu = new();
Meu.Saudacao(); //saudação já está invocando o 'ExibirData'
//Meu.ExibirData();

Console.ReadKey();

class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Bem-Vindo");
        Console.WriteLine("Esse é o estudo de classes e objetos");
        ExibirData();
    }

    public void ExibirData()
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
    }
}











