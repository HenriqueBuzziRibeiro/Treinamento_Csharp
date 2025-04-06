Console.WriteLine("Palavra THIS");

Teste teste1 = new();
teste1.Num1 = 88;
teste1.Num2 = 99;
teste1.Exibir();

Console.ReadKey();

public class Professor
{

    public Professor(string nome, int idade, string sexo)
    {
        this.nome = nome; //o this é usado aqui para evitar confusão quando as variáveis tem o mesmíssimo nome dos parametros
        this.idade = idade;
        this.sexo = sexo;
    }

    public string? nome;
    public int idade;
    public string? sexo;
}

public class Teste
{
    public int Num1;
    public int Num2;

    public void PassarParametro(Teste t)
    {
        Console.WriteLine($"\nthis = {this}");
        Console.WriteLine("Num1: " + t.Num1);
        Console.WriteLine("Num2: " + t.Num2);
    }

    public void Exibir()
    {
        PassarParametro(this); //esse THIS é para apontar para a instância do objeto
    }
}