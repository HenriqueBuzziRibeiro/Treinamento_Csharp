Console.Write("Declarando variáveis numéricas:\n");

//Declarando variáveis
byte valor1  = 255; //256 ou maior o 'byte' não consegue armazenar
sbyte valor2 = -127;
int valor3   = -2147483647;
uint valor4  = 2147483647;
long valor5  = -21474836489;
const int valor6 = 999; //não é possível atribuir outro valor para 'valor6' pois é uma constante

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);  
Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(valor6);