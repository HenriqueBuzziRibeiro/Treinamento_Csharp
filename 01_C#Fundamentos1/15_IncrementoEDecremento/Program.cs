Console.WriteLine("Operadores de incremento e decremento!");

//Pós incremento -> primeiro resolve, depois incrementa
int x = 0;
Console.WriteLine($"x = {x}");

int resultado = x++ + 10;
Console.WriteLine($"pós-incremento -> {resultado}"); //primeiro ele resolve e depois incrementa em X, ou seja, 0+10=10
Console.WriteLine($"valor de x -> {x}\n"); 

//Pré incremento -> primeiro incrementa depois resolve
int y = 0;
int resultado2 = ++y + 10;
Console.WriteLine($"pré-incremento ->{resultado2}"); //nesse caso ele primeiro incrementa e depois soma, ou seja, 1+10=11
Console.WriteLine($"valor de y ->{y}\n");

//OBS: para decrementar segue a mesma lógica que o incremento
//isso é bem utilizado em estruturas de repetição



