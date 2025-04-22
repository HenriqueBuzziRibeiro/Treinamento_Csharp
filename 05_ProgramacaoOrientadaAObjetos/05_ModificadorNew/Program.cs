Console.WriteLine("Modificador New"); //provavelmente não será usado, indicando problema de design

Aluno aluno = new();
aluno.Nome = "Maria";
aluno.Curso = "Quimica";
Console.WriteLine(aluno.Saudacao()); //vai usar o método da classe Aluno

Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }
    public string Saudacao() => $"Oi, eu sou o(a_{Nome}"; //jeito diferente de escrever um método

}

class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public string Saudacao() => $"Oi, Eu sou o(a) {Nome} do curso de : {Curso}";
    //o 'Saudacao()' está acusando algo porque não botamos um 'new' antes do 'string', não sinalizando que realmente queriamos ocultar o método da classe base
}