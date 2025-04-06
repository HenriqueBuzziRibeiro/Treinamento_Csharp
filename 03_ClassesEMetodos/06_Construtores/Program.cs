Console.WriteLine("Construtores");

Professor professor1 = new("Ricardo", 30, "Masculino");
Console.WriteLine(professor1.Nome);
Console.WriteLine(professor1.Idade);
Console.WriteLine(professor1.Sexo);

Console.ReadKey();

public class Professor
{
    //fazendo dois construtores
    public Professor(string nome) => Nome = nome; //é possível fazer assim com os construtores também
    public Professor(string nome, int idade, string sexo):this(nome) //vai identificar que tem um outro construtor para inserir o valor na variável nome
    {
        Idade = idade;
        Sexo = sexo;
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
}





