Console.WriteLine("Classes e Métodos");

Pessoa p1 = new Pessoa(); //o p1 vai ficar na memória Stack que vai conter a referência para a memória Heap
//pode ser só 'Pessoa p1 = new();'
p1.nome = "Maria";
p1.idade = 25;
p1.sexo = "Feminino";

Console.WriteLine($"{p1.nome} {p1.idade} {p1.sexo}");

Pessoa p2 = new Pessoa();
p1.nome = "Henrique";
p1.idade = 27;
p1.sexo = "Masculino";

Console.WriteLine($"{p2.nome} {p2.idade} {p2.sexo}");

Pessoa p3 = p2; //p3 vai apontar pros mesmos atributos que estão na memória Heap que p2

Console.ReadKey();

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}