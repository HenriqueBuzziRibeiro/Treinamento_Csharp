Console.WriteLine("Operador Uniário e Ternário");

int positivo = 2;
int resultado;

resultado = +positivo; //operador + retorna positivo
Console.WriteLine(resultado);

Console.WriteLine("Informe o numero: ");
var negativo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"O negativo de {negativo} é {-negativo}"); //operandor - retorna negativo
//Operador condicional ternário (?:)
//condição ? expressão1_se_true : expressão2_se_false --- isso é o operador ternário



Console.WriteLine("Informe o valor para 'temperatura', para testar operador ternário");
var temp = Convert.ToDouble(Console.ReadLine());
var resultado1 = temp > 27   ?   "Quente"    :    "Normal"; //importante saber fazer esse operador ternário
//               condição      se for true       se for false
Console.WriteLine($"A temperatura está {resultado1}");



//Aninhando operadores ternário
Console.WriteLine("Informe o valor de x e de y para exemplificar aninhamento de operador ternário: ");
var x = Convert.ToDouble(Console.ReadLine());
var y = Convert.ToDouble(Console.ReadLine());

string resultado2 = x > y ? "x é maior que y" :
                    x < y ? "x é menor que y" :
                   x == y ? "x é igual a y" : "Sem resultado";
Console.WriteLine(resultado2);

Console.ReadKey();



