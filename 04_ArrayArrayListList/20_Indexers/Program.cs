Console.WriteLine("Indexers");

Time time = new();

time[1] = "Palmeiras";
time[2] = "Corinthias";
time[5] = "Inter";
time[11] = "Gremio";  //fora do range que setamos na classe

string valor1 = time[1];
string valor2 = time[2];
string valor5 = time[5];
string valor11 = time[11]; //não vai atribuir nada ao 'valor11'

Console.WriteLine($"{valor1}");

Console.ReadKey();

public class Time
{
    string[] valor = new string[10];

    public string this[int i] //indexador - fornece uma sintaxe para acessar através do índice itens de um objeto que represente a coleção
    {
        get
        {
            if(i>=0 && i<valor.Length) 
                return valor[i];
            return "Erro";
        }
        set
        {
            if(i>=0 && i < valor.Length)
            {
                valor[i] = value;
            }
        }
    }
}