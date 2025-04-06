Console.WriteLine("Métodos Estáticos");

Console.WriteLine(Calculadora.Somar(13, 15)); //métodos estaticos não é possível chamar utilizando objetos, tem que chamar diretamente a partir da classe
Console.WriteLine(Calculadora.Subtrair(17, 14));

Console.ReadKey();

public class Calculadora
{
    public static int Somar(int n1, int n2) //método não vão pertencer ao objeto e sim a classe, então não é preciso criar o objeto para chamar o método
    {
        return n1 + n2;
    }
    public static int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }
}


