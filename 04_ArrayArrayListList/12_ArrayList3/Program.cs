using System.Collections;

Console.WriteLine("Array List 3");

//'Remove'         - remove a primeira ocorrência de um objeto específico
//'RemoveAt'       - remove o elemnto no índice específicado
//'RemoveRange'    - remove um número definido de elementos a partir de um índice específicado - (index, numero elementos a remover)

ArrayList lista = new(5) { "Henrique", 3, true, null, "Isabel", null }; //count=5 e capacity=10

lista.Remove(null); //vai remover o primeiro null
lista.RemoveAt(1);  //vai remover o item no index 1 (3)
lista.RemoveRange(0, 1); //vai remover o primeiro item da Arraylist

//no fim a lista = {true, "Isabel", null}

Console.ReadKey();