Console.WriteLine("Atribuindo valores a double, float e decimal");
Console.WriteLine();

double n1 = 1.234;
float n2 = 1.234F;     //necessário o "F"
decimal n3 = 1.234M;   //necessário o "M"

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);



Console.WriteLine("Comparando a precisão de float, double e decimal");

float x = 1f / 3f;   //menos preciso
double y = 1d / 3d;  //médio preciso
decimal z = 1m / 3m; //mais preciso 

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);







