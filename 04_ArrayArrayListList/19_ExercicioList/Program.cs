using _19_ExercicioList;

Console.WriteLine("Exercício List<T>");

List<Aluno> alunos = FonteDados.GetAlunos();
exibeAlunos(alunos);


//adiciona novos alunos na coleção
Aluno bia = new Aluno() { Nome = "Bia", Nota = 7.75};
Aluno mario = new Aluno() { Nome = "Mario", Nota = 7.75 };
alunos.Add(bia);
alunos.Add(mario);
//agora terá os alunso Bia e Mario a mais
exibeAlunos(alunos);


//localiza o aluno "Amanda" (variável deixamos como var porque se não tiver 'Amanda' ele vai retornar null
var alunoAmanda = alunos.Find(a => a.Nome.Equals("Amanda")); //a => a.Nome.Equals("Amanda") - expressão lambda que 'a' representa cada elemento da lista e comparando ele com 'Amanda'
alunos.Remove(alunoAmanda);
//Amanda não vai mais estar na lista
exibeAlunos(alunos);


//lista ordenada
var listaOrdenada = alunos.OrderBy(a => a.Nome).ToList(); ; //ele vai ordenar pelos nomes em uma nova lista
exibeAlunos(listaOrdenada);


//nota maior ou igual a 8
var notamaiorIgualOito = alunos.FindAll(a => a.Nota >= 8.0);
exibeAlunos(notamaiorIgualOito);

Console.ReadKey();

static void exibeAlunos(List<Aluno> alunos)   //perceba que é usado o static pois é um método que não depende de uma classe
{
    var somaNotas = 0.0;
    foreach (var aluno in alunos)
    {
        Console.WriteLine($"Nome: {aluno.Nome}\t Nota: {aluno.Nota}");
        somaNotas = somaNotas + aluno.Nota;
    }

    var mediaNotas = somaNotas / alunos.Count;
    Console.WriteLine($"\nA média das notas é {mediaNotas}");
    Console.WriteLine($"\nTotal de alunos é {alunos.Count}\n");
}