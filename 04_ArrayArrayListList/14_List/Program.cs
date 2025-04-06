Console.WriteLine("List<T>"); //equivalente a ArrayList e muito mais usado, é uma estrutura dinâmica podendo ser redimensionada (seu tamanho fica mudando como quisermos) e ela sempre inicia vazia

List<int> list1 = new();
var list2 = new List<int>();
List<double> list3 = new List<double>();

List<string> nomes1 = new();
nomes1.Add("Henrique");
nomes1.Add("Paulo");

List<string> nomes2 = new() //capacity será 4 e count 3 --- é bem parecido com array list
{
    "Henrique", "Maria", "Paulo"
};









Console.ReadKey();