Console.WriteLine("Métodos com retorno");

Calculadora calc1 = new();
Console.WriteLine(calc1.Somar(13, 10));
Console.WriteLine(calc1.Subtrair(13, 10));

Console.ReadKey();

public class Calculadora
{
    public int Somar(int n1, int n2)
    {
        return n1+n2;
    }
    public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }
}