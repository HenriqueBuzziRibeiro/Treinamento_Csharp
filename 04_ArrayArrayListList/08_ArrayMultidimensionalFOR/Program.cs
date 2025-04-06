Console.WriteLine("Arrays multidimensional FOR"); //pode ter até 32 dimensões mas o comum é só 2 (bidimensional, ou seja, matriz)

int[,] matriz = { { 5, 9 , 12}, { 15, 18, 22 } }; 

for(int i = 0; i < matriz.GetLength(0); i++) //GetLength é usado para obter o tamanho de uma dimensão, nesse caso como é (0) estamos falando das linhas
{
    for(int j = 0; j < matriz.GetLength(1); j++) //GetLength é usado para obter o tamanho de uma dimensão, nesse caso como é (1) estamos falando das colunas
    {
        Console.Write($"{matriz[i, j]}  ");
    }
    Console.WriteLine();
}

//utilizando foreach

Console.WriteLine("\nAgora utilizando foreach"); //é mais comum usar os FOR para arrays bidimensionais e para os unidimensionais usar o FOREACH

foreach(int m in matriz) 
{  
    Console.Write($"{m}  "); 
}

Console.ReadKey();