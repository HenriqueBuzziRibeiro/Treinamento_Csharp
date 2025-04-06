Console.WriteLine("Constante"); //constantes sempre maiusculas...

const int ANO = 12;   //é obrigatório atribuir um valor quando inicializa

const int MES = 30, SEMANA = 7, QUINZENA = 15;

const int MESES_ANO = 12;
const int DIAS_ANO = 365;

const float DIA_POR_MES = (float)DIAS_ANO / (float)MESES_ANO;

Console.WriteLine(DIA_POR_MES);

//Exemplo de uso 

double raio, perimetro, area;

//const double PI = 3.14; //interessante usar 'const' para dados que nunca vão mudar

//Calculo da área e perímetro do círculo
Console.WriteLine("Informe o raio do circulo: ");

raio = Convert.ToDouble(Console.ReadLine()); //ReadLine sempre retorna uma string, temos que usar o convert

//perimetro = 2 * PI * raio;
//area = PI * raio * raio;

perimetro = 2 * Math.PI * raio;
area = Math.PI * Math.Pow(raio, 2);


Console.WriteLine($"Perímetro = {perimetro}");
Console.WriteLine($"Área = {area}");

Console.ReadKey();





