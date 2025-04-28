using _18_PolimorfismoExemplo;

Console.WriteLine("Exemplo Polimorfismo");

var figuras = new List<Figura>
{
    new Triangulo(),
    new Circulo()
};

foreach (var fig in figuras)
{
    fig.Desenhar();
}

Calcular calcular = new Calcular();
Console.WriteLine(calcular.Somar(30, 40));
Console.WriteLine(calcular.Somar(30, 40, 50)); //isso também é polimorfismo

Console.ReadKey();

class Calcular
{
    public int Somar(int num1, int num2)//métodos com mesmo nome mas parametros diferentes
    {
        return num1 + num2;
    }

    public int Somar(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }





}