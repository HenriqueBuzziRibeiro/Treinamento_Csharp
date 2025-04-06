Console.WriteLine("Construtor Estático"); //construtor estático sempre será executado uma vez, antes de qualquer instância da classe ser criada, não pode conter parâmetros 

Pessoa p1 = new(27, "Henrique");

Console.WriteLine(p1.Nome + " - " + p1.Idade);
Console.WriteLine("Idade Minima " + Pessoa.IdadeMinima);

Pessoa p2 = new(25, "Gabriela");
Console.WriteLine(p2.Nome + " - " + p2.Idade);
Console.WriteLine("Idade Minima " + Pessoa.IdadeMinima);

Console.ReadKey();
