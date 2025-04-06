Console.WriteLine("Estrutura SWITCH 2");

Console.WriteLine("Informe o mês\t");
var mes = Console.ReadLine().ToLower(); //ToLower - vai transformar a string em minusculo

switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mês tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("Este mÇes tem 28 dias");
        break;
    default:
        Console.WriteLine("Este mês tem 30 dias");
        break;
}

Console.WriteLine("Fim do processamento\n\n\n");

int cargo = 0;
int funcao = 0;
Console.WriteLine("Você é gerente(1) ou programador(2)?\n");
cargo = Convert.ToInt32(Console.ReadLine());

switch (cargo)
{
    case 1:
        Console.WriteLine("Você é um gerente");
        break;
    case 2:
        Console.WriteLine("Você é um programador. Digite qual a sua função");
        Console.WriteLine("1 para Junior, 2 para Pleno e 3 para Senior");
        funcao = Convert.ToInt32(Console.ReadLine());
        switch (funcao)
        {
            case 1:
                Console.WriteLine("Você é Junior");
                break;
            case 2:
                Console.WriteLine("Você é Pleno");
                break;
            case 3:
                Console.WriteLine("Você é Senior");
                break;
            default:
                Console.WriteLine("Digite um valor válido");
                break;
        }
        break;
    default:
        Console.WriteLine("Digite um valor válido");
        break;
}











