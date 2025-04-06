Console.WriteLine("Estrutura IF ELSE IF");

Console.WriteLine("Informe a nota do aluno \t");
var nota = Convert.ToDouble(Console.ReadLine());

if(nota < 5)
{
    Console.WriteLine("Aluno reprovado\n");
}
else if(nota >= 5 && nota < 6)
{
    Console.WriteLine("Aluno em recuperação\n");
}
else if (nota >= 6 && nota <= 9)
{
    Console.WriteLine("Aluno aprovado\n");
}
else if (nota > 9)
{
    Console.WriteLine("Aluno aprova com distinçao\n");
}
Console.WriteLine("Fim do processamento");

Console.ReadLine();



