Console.WriteLine("Array 1"); //Usado mais de um valor literal do mesmo tipo em uma variável do mesmo nome

//declarei o array
int[] numeros;

//aloquei memória
numeros = new int[5] {1,2,3,4,5};

string[] nome = {"Ana", "Maria", "Henrique" };

Console.WriteLine(nome[0]); //Ana
Console.WriteLine(nome[1]); //Maria
Console.WriteLine(nome[2]); //Henrique

int[] numeros1; //declara um array
numeros1 = new int[3]; //aloca memória
numeros1[0] = 1; //atribuindo valores
numeros1[1] = 2;
numeros1[2] = 3;
//numeros1[3] = 4; //notar que o compilador não reclama, mas o erro vai aparecer em tempo de execução

Console.ReadKey();