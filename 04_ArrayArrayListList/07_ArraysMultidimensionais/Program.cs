Console.WriteLine("Arrays multidimensional"); //pode ter até 32 dimensões mas o comum é só 2 (bidimensional, ou seja, matriz)


//int[,] matriz = new int[3, 3] { { 0, 1 ,3}, { 4, 5, 6}, {7, 8, 9 } };
int[,] matriz = { { 5, 9 }, { 12, 15 } };

Console.WriteLine(matriz[0, 0]);
Console.WriteLine(matriz[0, 1]);
Console.WriteLine(matriz[1, 0]);
Console.WriteLine(matriz[1, 1]);

Console.ReadKey();
