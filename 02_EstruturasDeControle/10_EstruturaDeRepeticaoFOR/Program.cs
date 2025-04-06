Console.WriteLine("Estrutura de repetição FOR");

int resultado, numero;

Console.WriteLine("Informe o numero inteiro: \t");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    for (int i = 1; i <= 10; i++)
    {
        resultado = numero * i;
        Console.WriteLine(numero + " x " + i + " = " + resultado);
    }
}
else
{
    Console.WriteLine("Número inválido");
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();





