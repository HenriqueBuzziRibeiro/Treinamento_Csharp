Console.WriteLine("\n ## Entrada de dados ##");  //'ReadLine', 'Read' e ''

Console.WriteLine("\nInforme o seu nome");
string nome = Console.ReadLine();   //usuário vai digitar um valor
Console.WriteLine("O seu nome é " + nome);
Console.WriteLine($"O seu nome é {nome}");

//Usuário informando a idade
Console.WriteLine("\ne sua idade?");
int idade = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine("\nA sua idade é " + idade + ".");
Console.WriteLine($"\nA sua idade é {idade}");

Console.ReadKey();
