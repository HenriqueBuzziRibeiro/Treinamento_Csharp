using _22_Exercicio4;

Pessoa[] pessoas = new Pessoa[3];

Console.WriteLine("Digite o nome de 3 pessoas: ");
for (int i = 0; i<3; i++)
{
    string nome = Console.ReadLine();
    pessoas[i] = new Pessoa(nome);
}

Console.WriteLine("Pessoas cadastradas: ");
foreach(Pessoa pessoa in pessoas)
{
    Console.WriteLine(pessoa.Nome);
}



