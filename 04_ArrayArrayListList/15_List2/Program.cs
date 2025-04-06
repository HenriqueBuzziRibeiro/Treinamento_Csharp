using System.ComponentModel;

Console.WriteLine("List<T> 2"); //equivalente a ArrayList e muito mais usado, é uma estrutura dinâmica podendo ser redimensionada (seu tamanho fica mudando como quisermos) e ela sempre inicia vazia

List<string> nomes = new() //capacity será 4 e count 3 --- é bem parecido com array list
{
    "Henrique", "Maria", "Paulo", "Ricardo"
};

Console.WriteLine(nomes.Count() + " itens.");

nomes.Add("Hiago");  //vai adicionar ao final da lisa
nomes.Insert(0, "Everson");  //vai adicionar no índice 0

Console.WriteLine(nomes.Count() + " itens.");

//é possível adicionar listas (arrays) na List

nomes.Remove("Everson"); //Everson vai ser removido
nomes.RemoveAt(1); //vai remover o item no index 1
nomes.RemoveRange(0, 1); //vai remover do index 0 até o index 1










Console.ReadKey();









Console.ReadKey();