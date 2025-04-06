Console.WriteLine("Operadorres aritméticos");

//Classe 'Math' possui várias operações matemáticas, as mais usadas, como Sin(x), Tan(x), raiz, etc...

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"soma de x+y = {x+y}");
//Console.WriteLine($"subtração de x+y = {x - y}");
//Console.WriteLine($"multiplicação de x*y = {x * y}");
//double divisao = x / y;
//Console.WriteLine($"divisão de x/y = {x / y}");
//Console.WriteLine($"módulo de x%y = {x | y}");

//Usando a classe 'Math'
Console.WriteLine($"\nRaiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"Potência de x elevado a y = {Math.Pow(x,y)}");
Console.WriteLine($"Valor ínimo entre x e y = {Math.Min(x, y)}");
Console.WriteLine($"Valor máximo entre x e y = {Math.Max(x, y)}");
Console.WriteLine($"Coseno de x = {Math.Cos(x)}");
Console.WriteLine($"Seno x = {Math.Sin(x)}");
Console.WriteLine($"Exponencial de x = {Math.Exp(x)}");

Console.ReadKey();






