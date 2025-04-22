using _10_OperadorISeAS;

Console.WriteLine("Operadores AS e IS");

Circulo circulo = new Circulo();
Forma forma = new Circulo();

if (forma is Circulo)
{
    Console.WriteLine("É possível converter forma para Circulo");
    //((Circulo)forma).PintarCirculo - jeito de fazer downcasting de forma expicita
}
else
{
    Console.WriteLine("Operação de downcasting não é possível");
}

Circulo c = forma as Circulo; //downcasting, caso não seja possível vai retornar null e não uma exceção

if(c != null) // - ao invés de fazer o if else inteiro eu poderia fazer assim: 'c?.PintarCirculo()', que é um Null-Conditional Operator - Se o objeto for null, a expressão retorna null (sem lançar NullReferenceException).
{
    c.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcasting é inválida");
}

c?.PintarCirculo();
//explicação linha 20 - Se o objeto for null, a expressão retorna null (sem lançar NullReferenceException).
//Null-Conditional Operator


