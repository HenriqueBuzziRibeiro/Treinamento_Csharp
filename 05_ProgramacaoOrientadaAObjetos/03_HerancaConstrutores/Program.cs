Console.WriteLine("Herança construtores");

//a classe drivada não herda o construtor da classe base porém pode invocá-lo
//ao criar uma instancia da classe derivada o construtor da classe base sem parâmetros será invocado primeiro e depois será invocado o construtor da classe derivada

Aluno aluno = new("Henrique"); //note que vai passar pelos 2 construtores e não vai passar pelo construtor com parâmetro na classe 'Pessoa'




Console.ReadKey();

class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Construtor da classe Pessoa");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor da classe Pessoa com parâmetro Nome");
    }
}

class Aluno : Pessoa
{
    public Aluno()
    {
        Console.WriteLine("Construtor da classe Aluno");
    }

    public Aluno(string nome) // : base() -- isso invocaria o construtor com parâmetro da classe base
    {
        Console.WriteLine("Construtor da classe Aluno com parâmetro Nome");
    }
}