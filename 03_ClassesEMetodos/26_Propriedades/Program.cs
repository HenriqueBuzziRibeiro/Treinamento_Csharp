Console.WriteLine("Propriedades"); //As propriedades são membros de uma classe que fornecem um mecanismo para ler, gravar ou calcular o valor de um atributo privado. Elas permitem controlar o acesso aos atributos de forma mais segura e flexível.

Produto p1 = new("Caderno Espiral", 4.99, 10);
p1.Exibir();

Console.ReadKey();

public class Produto
{
    public Produto (string Nome, double Preco, int EstoqueMinimo)
    {
        this.Nome = Nome;
        this.Preco = Preco;
        this.EstoqueMinimo = EstoqueMinimo;
    }

    private string? nome; //quando você declara um campo privado manualmente, pode adicionar lógica personalizada no get ou set da propriedade
    public string? Nome 
    { 
        get { return nome.ToUpper(); } 
        set {  nome = value; } 
    }

    private double preco;
    public double Preco 
    { 
        get { return preco; }
        set
        {
            if (value < 5.00)
                preco = 5.00;
            else 
                preco = value;
        }
    }

    private double desconto = 0.05; //como atribuimos o valor aqui, só vai ser possível fazer a leitura dele
    public double Desconto 
    {
        get { return desconto; } 
 
    }

    public double PrecoFinal 
    {
        get { return Preco - (Preco * desconto); } 
    }

    private int estoqueMinimo;
    public int EstoqueMinimo //somente gravação (não é comum ver isso no código, na vdd é bem raro)
    {
        set { estoqueMinimo = value; } 
    }

    public void Exibir()
    {
        Console.WriteLine($"{Nome}\n R$ {Preco.ToString()}\n {Desconto}\n {PrecoFinal.ToString()}\n {estoqueMinimo}");
    }
}