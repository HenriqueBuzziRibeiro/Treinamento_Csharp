Console.WriteLine("Exemplos Métodos e Assinaturas");

Cadastro cadastro1 = new();
var cliente = cadastro1.Registrar(); //vai utilizar o método sem parâmetros
cadastro1.ExibirDados(cliente); //vai exibir os dados que são Henrique, 23, 3000

//alterar renda
cliente = cadastro1.Registrar(cliente); //esse método 'Registrar' ele apenas altera a renda para um valor de 3500
cadastro1.ExibirDados("Renda alterada", cliente);

Console.ReadKey();

public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente(string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }

    public Cliente() { } //tendo esse construtor eu posso inicial um objeto da forma padrão, sem atribuir nenhum valor aos atributos inicialmente
}

public class Cadastro
{
    public Cliente Registrar()
    {
        Cliente cliente = new ("Henrique", 23, 3000);
        return cliente;
    }

    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 3500;
        return cliente;
    }

    public void ExibirDados(Cliente cliente)
    {
        Console.WriteLine($"{cliente.Nome} {cliente.Idade} {cliente.Renda.ToString("c")}");
    }

    public void ExibirDados(string texto, Cliente cliente)
    {
        Console.WriteLine($"\n{texto}\t");
        Console.WriteLine($"{cliente.Nome} {cliente.Idade} {cliente.Renda.ToString("c")}");
    }
}