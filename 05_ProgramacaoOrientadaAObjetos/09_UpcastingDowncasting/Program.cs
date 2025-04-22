using _09_UpcastingDowncasting;

Console.WriteLine("Upcasting e Downcasting"); //faz um objeto da classe herança virar um da classe base e visse versa

//Downcasting converte um objeto de um tipo geral (classe base) para um tipo mais especializado (classe filha)

Circulo circulo = new Circulo(10, 20); 
Forma forma = circulo; //upcasting

circulo.Desenhar();
circulo.PintarCirculo();

forma.Desenhar(); //não consegue acessar o método 'PintarCirculo();'

Console.WriteLine(forma == circulo); //vai retornar true

Circulo c = (Circulo)forma;  //downcasting - downcasting dessa forma possui risco de excessão, então é interessante usar o AS

c.PintarCirculo();
c.Desenhar();

Console.WriteLine(c == forma);
Console.WriteLine(c == circulo);
   


