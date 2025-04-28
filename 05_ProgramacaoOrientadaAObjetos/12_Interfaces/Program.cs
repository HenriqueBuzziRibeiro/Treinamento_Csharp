Console.WriteLine("Interfaces"); //Interface não pode ser instanciada diretamente, seus membros são implementados por qualquer struct ou classe que implemente a interface

IControle d = new Demo();
d.Nome = "Teste";
d.Desenhar();
d.Exibir();
//d.Pintar(); - não é possível acessar pois é do tipo ICintrole

Console.ReadKey();



interface IControle //se não declarar o encapsulamento ela é naturalmente publica
{
    void Desenhar(); //esse método é abstrato, ou seja, a classe que herdar a interface deverá implmenta-la

    void Exibir() //notas que esse método não é abstrato
    {
        Console.WriteLine("Teste");
    }

    string Nome {  get; set; } //terá que ser implementada pela classe que herdar essa interface

}

interface Grafico
{

    //public Grafico() { } - interface não pode ter construtor

    void Pintar(); //classe abstrata, tem que ser implementada pela classe que herdar essa interface
}

public class Demo : IControle, Grafico //é possível herdar duas interfaces
{
    public void Desenhar()
    {
        Console.WriteLine("Desenhando...");
    }

    public void Pintar()
    {
        Console.WriteLine("Pintando...");
    }

    public string Nome { get; set; } //era obrigatório pois temos essa propriedade na interface IControle


}

