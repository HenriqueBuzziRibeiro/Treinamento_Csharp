Console.WriteLine("Parâmetros entre classes e referências");

//Aluno aluno1 = new();
//aluno1.nome = "Henrique";
//aluno1.idade = 16;
//aluno1.sexo = "Masculino";
//aluno1.aprovado = "S";

//Curso curso1 = new();
//curso1.Resultado(aluno1.nome, aluno1.idade, aluno1.sexo, aluno1.aprovado);

Aluno aluno1 = new();
aluno1.Consultar();


Console.ReadKey();

public class Aluno
{
    public string? nome;
    public int idade;
    public string? sexo;
    public string? aprovado;

    public void Consultar()
    {
        Aluno aluno1 = new();
        Console.WriteLine("Nome: ");
        aluno1.nome = Console.ReadLine();
        Console.WriteLine("Idade: ");
        aluno1.idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sexo: ");
        aluno1.sexo = Console.ReadLine();
        Console.WriteLine("Aprovado (S)im (N)ão: ");
        aluno1.aprovado = Console.ReadLine();

        Curso curso1 = new();
        curso1.Resultado(aluno1); //podemos fazer desse jeito também
    }
}


//public class Curso
//{
//    public void Resultado(string nome, int idade, string sexo, string aprovado)
//    {
//        Console.WriteLine($"O aluno {nome}, sexo {sexo} com {idade} anos foi ");
//        if (aprovado == "S")
//            Console.WriteLine("aprovado");
//        else
//            Console.WriteLine("reprovado");
//    }
//}

public class Curso
{
    public void Resultado(Aluno aluno) //passa um objeto aluno como parâmetro
    {
        Console.WriteLine($"O aluno {aluno.nome}, sexo {aluno.sexo} com {aluno.idade} anos foi ");
        if (aluno.aprovado == "S")
            Console.WriteLine("aprovado");
        else
            Console.WriteLine("reprovado");
    }
}