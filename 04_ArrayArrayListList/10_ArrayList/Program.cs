using System.Collections;

Console.WriteLine("Array List"); ///JÁ DE LARGADA, ARRAYLIST DEVE SER ALGO EVITADO NOS DIAS DE HOJE, O CERTO É USAR LIST

//ArrayList está no namespace System.Collections e possui 3 tipos construtores
//A 'capacity' padrão de uma ArrayList é 4 e ela aumenta de 4 em 4, se o 'count' (número de elementos) for 5, a 'capacity' será 8
//Se inicializarmos a capacity com 5, quando botarmos o sexto item a capacity irá dobrar

ArrayList lista = new();      //também da de ser 'var lista = new ArrayList()'
ArrayList lista1 = new(5);    //'capacity' será 5, utilizamos o segundo construtor


//adicionando elementos pro ArrayList no momento da criãção
ArrayList lista2 = new(5) { "Henrique", 27, 5, true, null, "Isabel"};

Console.ReadKey();