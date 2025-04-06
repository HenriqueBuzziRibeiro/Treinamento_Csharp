Console.WriteLine("List <T> e Enumerable");

/* IEnumerable é uma interface e só se consegue ler a coleção.
 IEnumerable não precisa ter toda a coleção na memória */

/* List implementa métodos capazes de acessar e alterar a coleção, não é apenas leitura.
 List possui toda a coleção na memória e sabe quantos itens possui a coleção */

var caderno = new List<Folha>();  //caderno é uma lista de folhas

for (int i = 0; i < 51; i++)
{
    caderno.Add(new Folha() { Pagina = i});  //Pagina é uma propriedade
    if (caderno[i].AnalisaSeContemRabiscoSemConsoleWrite() == true)
    {
        Console.WriteLine($"A pagina {caderno[i].Pagina} é um rabisco");
    }
}




var folhasComRabiscos = caderno.Where(c => c.AnalisaSeContemRabisco());

if(folhasComRabiscos.Count() > 5)   //é na hora que chamamos o count que a gente enumera o enumerable
{
    Console.WriteLine($"Possui 5 ou mais folhas com rabisco e são elas: ");
}

Console.ReadKey();

public class Folha
{
    public int Pagina { get; set; }
    private bool isLimpa, isRabisco, isTexto;

    public Folha()
    {
        var aleatorio = Random.Shared.Next(1, 4); //toda vez que uma folha for instanciada ela vai colocar um valor nesses 'is'
        isLimpa = aleatorio == 1;
        isRabisco = aleatorio == 2;
        isTexto = aleatorio == 3;
    }

    public bool AnalisaSeContemRabisco()
    {
        Console.WriteLine($"Executa análise na página {Pagina}");
        return isRabisco;
    }

    public bool AnalisaSeContemRabiscoSemConsoleWrite()
    {
        return isRabisco;
    }




}