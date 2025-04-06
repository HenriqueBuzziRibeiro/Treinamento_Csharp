Console.WriteLine("Conversão de tipos de dados\n");

//Conversão implícita - compilador C# converte autoamticamente um tipo de dados em outro tipo (Quando a conversão entre os tipos for compatível
//Conversão explícita - covnersão tem que ser feita manualmente de forma explícita

#region Conversão implícita
int varInt = 100;                  
double varDouble = varInt;

//byte -> 1 byte
//short -> 2 byes
//int -> 4 bytes
//long -> 8 bytes
//float -> 4 bytes
//double -> 8 bytes
//decimal -> 16 bytes

Console.WriteLine(varDouble);

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);
#endregion

#region Conversão explícita

double vDouble = 12456;       //Double usar 8bytes
int vInt = (int)vDouble;      //Int usa 4 bytes
//para converter é necessário esse (int) pois o 'double' ocupa mais espaço de memória que o 'int'

int num1 = 10;
int num2 = 4;

float resultado = num1 / num2;   //10/4 = 2.5
Console.WriteLine(resultado);    //vai apresentar um número inteiro

#endregion

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.45678m;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

Console.ReadLine();

//Overflow Exception:
int variaInt = 10000;
Console.WriteLine(Convert.ToByte(variaInt)); //aqui vai ocorrer uma overflow exception, o tipo byte é de 0 a 255 e se converter vai ter um estreitamento de dados com perda de dados 








