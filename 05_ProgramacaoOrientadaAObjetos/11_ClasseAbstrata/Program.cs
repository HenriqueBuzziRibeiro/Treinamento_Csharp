using _11_ClasseAbstrata;

Console.WriteLine("Classe abstrata");

Quadrado q = new Quadrado();
Console.WriteLine(q.Descricao());

Console.WriteLine("Informe o valor do lado do quadrado: ");
q.Lado = Convert.ToInt32(Console.ReadLine());

q.CalculaArea();
q.CalcularPerimetro();

Console.WriteLine($"Area = {q.Area} metros quadrados");
Console.WriteLine($"Perimetro = {q.Perimetro} metros");
