Console.WriteLine("Modificador Param");

int[] valores = { 1, 2, 3 };
var resultado = Calcular.Soma(valores);
Console.WriteLine(resultado);

var resultado2 = Calcular.Soma(new int[] { 1, 2, 3, 5, 5 });
Console.WriteLine(resultado2);

var resultado3 = Calcular.SomaParams(1,2,3,4,5,6,7,100); //modificador 'params' faz com que possamos passar a lista direto no parâmetro, sem ter que criar um array antes
Console.WriteLine(resultado3);

Console.ReadKey();

public class Calcular
{
    public static int Soma(int[] numeros)
    {
        int total = 0;
        foreach (var N in numeros) 
        {        
            total += N;
        }
        return total;    
    }


    public static int SomaParams(params int[] numeros)
    {
        int total = 0;
        foreach (var N in numeros)
        {
            total += N;
        }
        return total;
    }


}