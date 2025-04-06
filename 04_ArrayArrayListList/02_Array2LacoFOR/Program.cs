Console.WriteLine("Array 2 utilizando laço FOR");

int[] numeros = {1,2,3,4,5};
string[] nomes = { "Henrique", "Gabi", "Bruno" };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}


Console.ReadKey();