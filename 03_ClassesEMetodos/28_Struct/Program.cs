Console.WriteLine("Struct"); //semelhante a uma classe, unica diferença é basicamente que as instâncias das structs ficam na memória Stack

Cliente cli1 = new();
cli1.Nome = "Henrique";
cli1.Idade = 27;

Console.WriteLine($"{cli1.Nome} {cli1.Idade}");

Console.ReadKey();

public struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente (string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

/*
Quando usar Struct?

Struct - usar Struct se as instâncias forem pequenas e normalmente de curta duraçãoou se forem comumente incorporadas em utros projetos
*/