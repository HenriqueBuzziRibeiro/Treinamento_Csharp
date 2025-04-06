Console.WriteLine("Try Catch - Exceções");
//vai ser utilizado caso não haja um tratamento para algo

Console.WriteLine("\nInforme o valor de x ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

try
{
    int z = x / y;
    Console.WriteLine($"\n{x} / {y} = {z}");
}
catch (Exception ex)
{
    Console.WriteLine("Não existe divisão por zero, tente outro número");
    Console.WriteLine($"\n Erro: <<< {ex.Message} >>>"); //linguagem já traz pronto esses tratamentos
    Console.WriteLine($"\n Detalhes: {ex?.StackTrace?.ToString()}");
}
finally
{
    Console.WriteLine("\nProcessamento concluído...");
}



Console.ReadKey();


