Console.WriteLine("Virtual e Override");

Gato gato = new();
Cachorro cachorro = new();
Animal animal = new();

animal.Nome = "Animal";
gato.Nome = "Bixano";
cachorro.Nome = "Thor";

animal.ExibeNome();
gato.ExibeNome();
cachorro.ExibeNome();

Console.ReadKey();

//Para um membro da subclasse substitua um membro da classe base use o 'virtual' na classe base e o 'override' na subclasse

class Animal
{
    public string? Nome { get; set; }
    
    public virtual void ExibeNome()
    {
        Console.WriteLine($"{Nome}");
    }
}

class Gato : Animal
{
    public override void ExibeNome()  //vai estar sobrepondo o 'ExibeNome' da classe base
    {
        Console.WriteLine($"Sou um gato e meu nome é {Nome}");
    }
}

class Cachorro: Animal
{
    //como não declarei um novo 'ExibeNome' ele vai usar o da classe base
}
