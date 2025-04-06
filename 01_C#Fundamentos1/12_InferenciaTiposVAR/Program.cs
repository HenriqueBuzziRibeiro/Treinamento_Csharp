Console.WriteLine("Inferência de dados, utilizando VAR\n");

int idade = 25; //Definição explícita ou direta do tipo de dados da variável X
string nome = "Henrique";
decimal salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} e ganha {salario.ToString("c")}");

var y = 0; //Definição implícita ou indireta do tipo de dados da variável X
//quando usa var a gente tem que inicializa

//var salario = null;
//var titulo;
//var salario, imposto, total;
//não é possível nenhuma dessas opções acima

//não da de mudar o tipo apos inicializar
//var num = 10;
//num = num + 20; - funciona
//num = "Teste"; - não funciona


//VAR também vai servir para quando estivermos trabalhando com tipos feitos pelo usuário, ou seja, as CLASSES


