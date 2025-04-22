Console.WriteLine("Modificador Sealed");   //para que uma classe não possa ter subclasses, também podemos usar em propriedades e métodos das subclasses


Console.ReadKey();

/*sealed*/ class Pessoa //sealed faria essa classe não poder ter subclasses
{
    public string? Nome { get; set; }

    public virtual void ExibeNome()
    {
        Console.WriteLine($"Meu nome é{Nome}");
    }
}

class Cliente : Pessoa
{
    sealed public override void ExibeNome()
    {
        Console.WriteLine($"Nome do cliente é {Nome}");
    }
}

class ClienteVIP : Cliente
{
    //public override void ExibeNome() //não está sendo possível sobreescrever porque tem o sealed
    //{
    //    Console.WriteLine($"Nome do fornecedor é {Nome}");
    //}
}


