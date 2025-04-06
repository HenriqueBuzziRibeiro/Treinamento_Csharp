using System.Collections;

Console.WriteLine("Array List 4");

//'Contains' - verificar se elemento específicado existe na ArrayList
//'Sort'     - vai ordenar na ordem ascendente
//'Clear'    - remove todos os elementos e deixa a propriedade 'capacity' com o mesmo valor

ArrayList lista = new(5) { "Henrique", 3, true, null, "Isabel", null }; //count=5 e capacity=10

bool contem = lista.Contains(3); //vai retornar um true (um boolean)
Console.WriteLine(contem);
contem = lista.Contains(4); //vai retornar false
Console.WriteLine(contem);

//para utilizar o 'Sort' eu preciso de ArrayList que seja elementos do mesmo tipo

lista.Clear(); //vai limpar todo o array


//OBS: ArrayList não é muito usado pois não apresenta um bom desempenho, o comum é usar List



Console.ReadKey();