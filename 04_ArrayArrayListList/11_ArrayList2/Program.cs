using System.Collections;

Console.WriteLine("Array List 2");

//'Add'         - adiciona um elemnto ao final da ArrayList
//'Insert'      - adiciona um elemnto no indíce indicado
//'AddRange'    - adiciona a coleção de elementos ao final da ArrayList
//'InsertRange' - adicioan a coleção de elementos no index específicado

ArrayList lista = new(5) { "Henrique", 3, true, null, "Isabel" }; //count=5 e capacity=10

lista.Add("Ultimo");
lista.Insert(2, 5);

int[] array = { 1, 2, 3 };

lista.AddRange(array);
lista.InsertRange(1, array);

Console.ReadKey();