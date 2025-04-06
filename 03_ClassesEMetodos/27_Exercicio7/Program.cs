Console.WriteLine("Exercício 7");

Carro car1 = new();
car1.ano = 2023; //temos que atribuir o valor através da propriedade e não do atributo
car1.Ano = 2023;
Console.WriteLine($"O ano do carro é {car1.Ano}");

Console.ReadKey();

public class Carro
{
    //public Carro(int ano)
    //{
    //    this.ano = ano;
    //}

    public int ano;
    public int Ano
    {
        get { return ano; }
        set
        {
            if (value < 2000)
                ano = 2000;
            else if(value > 2022)
                ano = 2022;
        }
    }
}