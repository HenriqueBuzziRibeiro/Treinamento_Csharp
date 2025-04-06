Console.WriteLine("Construtores");

Aluno aluno1 = new();

//operador ternáro (condição ? expressão1_se_true : expressão2_se_false)
Console.WriteLine(aluno1.nome == null ? "null" : aluno1.nome);
Console.WriteLine(aluno1.idade == 0 ? 0 : aluno1.idade);
Console.WriteLine(aluno1.sexo == null ? "null" : aluno1.sexo);
Console.WriteLine(aluno1.aprovado == null ? "null" : aluno1.aprovado);

Professor professor1 = new("Ricardo", 30, "Masculino");
Console.WriteLine(professor1.Nome);
Console.WriteLine(professor1.Idade);
Console.WriteLine(professor1.Sexo);

Console.ReadKey();

public class Aluno //toda classe tem um construtor padrão, caso não façamos um específico
{
    public string? nome;
    public int idade;
    public string? sexo;
    public string? aprovado;
}

public class Professor
{
    //construtor parametrizado, quando definimos um construtor assim temos que obrigatoriamente instanciar o objeto definindo esses parâmetros
    public Professor(string nome, int idade, string sexo) 
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
}