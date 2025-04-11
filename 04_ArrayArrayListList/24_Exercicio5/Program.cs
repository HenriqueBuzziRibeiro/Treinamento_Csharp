using _24_Exercicio5;

Console.WriteLine("Exercicio 5");

List<Produto> listProdutos = new()
{
    new Produto(){Nome="Clips", Preco=3.95m},
    new Produto(){Nome="Caneta", Preco=5.99m},
    new Produto(){Nome="Lapis", Preco=4.15m},
    new Produto(){Nome="Estojo", Preco=6.99m},
    new Produto(){Nome="Caderno", Preco=7.55m},
};

Exibir(listProdutos);

listProdutos.Add(new Produto() { Nome = "Mochila", Preco = 22.44m });

Exibir(listProdutos);

//Exibe ordenada
Exibir(listProdutos.OrderBy(x => x.Nome).ToList());

//Exibir produtos abaixo de 5.00
ExibirPrecoBaixo(listProdutos);

//Encontra o item 'Estojo'
var estojo = listProdutos.Find(e => e.Nome == "Estojo");  //var 'estojo' será uma variável produto
Console.WriteLine(estojo.Nome);

Console.ReadKey();

static void Exibir(List<Produto> listaProduto)
{
    decimal somaPrecos = 0;
    int i = 0;
    foreach (Produto produto in listaProduto)
    {
        Console.WriteLine(produto.Nome);
        somaPrecos = somaPrecos + produto.Preco;
        i++;
    }
    Console.WriteLine($"A soma de todos os produtos é {somaPrecos}");

    decimal media = somaPrecos / i;
    Console.WriteLine($"A lista possui {i} produtos e a média de preços é {media}");
}

static void ExibirPrecoBaixo(List<Produto> listaProduto)
{

    foreach (Produto produto in listaProduto)
    {
        if(produto.Preco < 5.00m)
            Console.WriteLine($"{produto.Nome} - {produto.Preco}");
    }
}

