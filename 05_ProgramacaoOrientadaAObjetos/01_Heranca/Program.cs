Console.WriteLine("Herança");

Funcionario func1 = new();
func1.Nome = "Henrique"; //note que estamos usando a propriedade 'Nome' que está na classe 'Pessoa'

Aluno aluno1 = new();
aluno1.Email = "Henrique@gmail.com"; //note que estamos usando a propriedade 'Email' que está na classe 'Pessoa'

Console.ReadKey();


public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }

    public void Identificar()
    {
        Console.WriteLine($"{Nome} - {Email}");
    }
}

public class Funcionario : Pessoa //herda de 'Pessoa'
{
    public string Empresa { get; set; }
    public decimal Salario { get; set; }
}

public class Aluno : Pessoa //herda de 'Pessoa'
{
    public string? Curso { get; set; }
    public int Nota { get; set; }
}