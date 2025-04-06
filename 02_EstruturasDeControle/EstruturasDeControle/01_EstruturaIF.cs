Console.WriteLine("Instrução IF\n");

Console.WriteLine("Cliente Especial (S/N)");
var resposta = Console.ReadLine();

if(resposta == "S")
{
    Console.WriteLine("Desconto de 10% \n\n\n");
}

Console.WriteLine("Informe os valores de x \t");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe os valores de y \t");
int y = Convert.ToInt32(Console.ReadLine());

if(x > y)
{
    Console.WriteLine("x é maior que y");
}
if (y > x)
    Console.WriteLine("x é menor que y");

if (x == y)
    Console.WriteLine("x e y possuem o mesmo valor");




Console.ReadKey();
