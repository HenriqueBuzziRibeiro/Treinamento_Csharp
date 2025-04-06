Console.WriteLine("Campos estáticos");

A a1 = new();
a1.x = 10;

A a2 = new();
a2.x = 20;
//a2.y = 30; - essa linha estaria incorreta

A.y = 30; //é preciso ser feito dessa forma, pois ele virou um atributo da classe e não mais do objeto
//o y é compartilhado entre a1 e a2 pelo mesmo local na memória

Console.WriteLine($"A.y = {A.y}");

Console.ReadKey();

public class A
{
    public int x;
    public static int y;
    //...
}



