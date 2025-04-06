Console.WriteLine("Saída de dados : Formatação\n");

int idade = 25;
string nome = "Henrique";
Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine();

//Escreve na mesma linha 'Maria' tem 25 anos
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos ");
Console.WriteLine();

//usando concatenação : usando o operador '+'
Console.WriteLine(nome + " tem " + idade + " anos ");
Console.WriteLine(nome + " tem " + idade + " anos ");

//usa a interpolação de strings : $ -> a interpolação {}
Console.WriteLine($"{nome} tem {idade} anos");

//usar place holder : usa {} com numeração com inicio em zero
Console.WriteLine("{0} tem {1} anos", nome, idade);





