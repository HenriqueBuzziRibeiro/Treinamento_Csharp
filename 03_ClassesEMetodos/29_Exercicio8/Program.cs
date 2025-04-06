Console.WriteLine("Exercício 8");

Cliente cli1 = new("Henrique", "henrique@gmail.com" , 15);
Cliente.ExibirInfo(cli1.nome, cli1.email);
Cliente.ExibirInfo(cli1.nome, cli1.email, cli1.Idade);

Console.ReadKey();

public struct Cliente
{
    public Cliente(string? nome, string? email, int Idade)
    {
        this.nome = nome;
        this.email = email;
        this.idade = Idade;
    }

    public string? nome;
    public string? email;
    public int idade;
    public int Idade //propriedade Idade, caso seja menor que 18 vai setar como 18 a Idade
    {
        get {  return idade; }
        set
        {
            if (value < 18)
                idade = 18;
        }
    }

    public static void ExibirInfo(string? nome, string? email, int idade = -1) //idade é opcional informar na chamada do método
    {

        if (idade == -1)
            Console.WriteLine($"O nome é {nome}, o email é {email}");
        else
            Console.WriteLine($"O nome é {nome}, o email é {email} e a idade é {idade}");        
    }
}