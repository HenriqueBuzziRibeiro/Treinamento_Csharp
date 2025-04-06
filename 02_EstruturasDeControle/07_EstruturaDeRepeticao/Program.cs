Console.WriteLine("Estrutura de repetição WHILE");

var i = 1;

while (i <= 10)
{
    Console.WriteLine($"i = {i}");
    i++;
}

Console.WriteLine("Fim do processamento...\n\n\n");

Console.WriteLine("Digite um número de 1 a 10 que você que a tabuada tabuada: \n");
var numero = Convert.ToInt32(Console.ReadLine());
int j = 1;
int resultado;

Console.WriteLine($"Tabuada do {numero}");
while (j <= 10)
{
    resultado = j*numero;
    Console.WriteLine($"{j} x {numero} = {resultado}");
    j++;
}

Console.ReadKey();