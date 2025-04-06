Console.WriteLine("Tipos anônimos"); //não vai ter uma classe definida, então usamos o var

var aluno = new
{
    Nome = "Henrique",
    Idade = 27
};

Console.WriteLine(aluno.Nome + " " + aluno.Idade); //todas as propriedades do tipo anônimo são somente leitura, não é possível alterar

Console.ReadKey();




