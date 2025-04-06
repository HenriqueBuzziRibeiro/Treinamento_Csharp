Console.WriteLine("Estrutura Switch");

int compra = 600;
Console.WriteLine("Valor da compra 600$");
Console.WriteLine("Informe o no. de parcelas (1 a 3)");
var numeroParcelas = Convert.ToInt32(Console.ReadLine());

switch (numeroParcelas)
{
    case 1:
        Console.WriteLine($"\nPrestação $ {compra / numeroParcelas}");
        break;
    case 2:
        Console.WriteLine($"\nPrestação $ {compra / numeroParcelas}");
        break;
    case 3:
        Console.WriteLine($"\nPrestação $ {compra / numeroParcelas}");
        break;
    default:
        Console.WriteLine("\nValor inválido, informe 1, 2 ou 3");
        break;
}

Console.WriteLine("\nFim de processamento...\n\n\n");

Console.WriteLine("Estrutura switch-case\n");
Console.WriteLine("Informe o numero inteiro");
var numero = Convert.ToInt32(Console.ReadLine());

switch (numero%2)
{
    case 0:
        Console.WriteLine("\n" + numero + " é PAR");
        break;
    case 1:
        Console.WriteLine("\n" + numero + " é IMPAR");
        break;
}

Console.WriteLine("\nFim de processamento...");











Console.ReadKey();






