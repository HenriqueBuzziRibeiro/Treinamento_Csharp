using System.Collections;

Console.WriteLine("Exercicio 4");

ArrayList lista = new(3);

for(int i = 0; i < 3; i++)
{
    Pessoa pessoa = new Pessoa();  //tem que ser aqui dentro para não ficar o mesmo endereço de 'pessoa' em todos os index da lista
    Console.WriteLine("Digite o nome: ");
    pessoa.Nome = Console.ReadLine();
    Console.WriteLine("Digite a idade: ");
    pessoa.Idade = Convert.ToInt32(Console.ReadLine());
    lista.Add(pessoa);
}

foreach(Pessoa p in lista) 
{  
    Console.WriteLine($"{p.Nome} tem {p.Idade}"); 
}

Console.WriteLine("Adiciona mais duas pessoas a lista");
for (int i = 0; i < 2; i++)
{
    Pessoa pessoa1 = new Pessoa();  //tem que ser aqui dentro para não ficar o mesmo endereço de 'pessoa' em todos os index da lista
    Console.WriteLine("Digite o nome: ");
    pessoa1.Nome = Console.ReadLine();
    Console.WriteLine("Digite a idade: ");
    pessoa1.Idade = Convert.ToInt32(Console.ReadLine());
    lista.Add(pessoa1);
}

lista.RemoveAt(lista.Count-1); //tira o último item da lista

foreach (Pessoa p in lista)
{
    Console.WriteLine($"{p.Nome} tem {p.Idade}");
}


Console.ReadKey();

public class Pessoa()
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void Exibir()
    {
        Console.WriteLine($"Nome: {Nome}   Idade: {Idade}");
    }
}
