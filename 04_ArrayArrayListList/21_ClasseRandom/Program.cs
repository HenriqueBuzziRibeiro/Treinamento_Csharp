Console.WriteLine("Classe Random");

Random random = new();
int[] numeroSorteados = new int[6];

for(int i = 0; i < 6; i++)
{
    numeroSorteados[i] = random.Next(1,61);
}

Array.Sort(numeroSorteados);

Console.WriteLine(string.Join(" ", numeroSorteados));


Console.ReadKey();