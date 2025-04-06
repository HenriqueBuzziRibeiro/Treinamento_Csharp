Console.WriteLine("Argumentos por Referência OUT"); //out transfere dados para fora do método e não para dentro dele

Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circ1 = new();

double perimetro  = circ1.CalculaAreaPerimetro(raio, out double area); //note que não foi passado nenhum valor para 'area', o que se queria fazer era só extrair de dentro do método esse valor, note também que uma variável área foi criada
Console.WriteLine($"A área é {area}");
Console.WriteLine($"O perimetro é {perimetro}");

Console.ReadKey();

public class Circulo
{
    public double CalculaAreaPerimetro(double raio, out double area) //define que vai retornar o valor do parâmetro, não será preciso inicializar informando o valor da área
    {
        area = Math.PI*Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}