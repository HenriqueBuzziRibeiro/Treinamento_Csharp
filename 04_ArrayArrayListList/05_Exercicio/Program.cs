Console.WriteLine("Exercicio 01");

string[] nomes = new string[5]; //declaro que haverá um array com 5 itens de string
double[] notas = new double[5];
double total=0;

Console.WriteLine("Digite cinco nomes: ");

for(int i=0; i<nomes.Length; i++)
{
    Console.WriteLine("Informe o nome do aluno: ");
    nomes[i] = Console.ReadLine();
    Console.WriteLine("Informe a nota do aluno: ");
    notas[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Nomes: ");
foreach (string N in nomes)
{
    Console.Write(N);
}

Console.WriteLine("Notas: ");
foreach (double N in notas)
{
    total = total + N;
    Console.Write(N);
}
 double media = total/notas.Length;

Console.WriteLine($"A media total é: {media}");

Console.ReadKey();