Console.WriteLine("Composição Relacionamento"); //Composição permite que uma classe contenha um ou mais objetos de outras classes

Carro meuCarro = new Carro("V8 Turbo");
meuCarro.LigarCarro();

Console.ReadKey();
public class Carro
{
    // Classe Motor declarada DENTRO da classe Carro
    private class Motor
    {
        public string Tipo { get; set; }

        public void Ligar()
        {
            Console.WriteLine($"Motor {Tipo} ligado!");
        }
    }

    // Campo que armazena a instância do Motor (composição)
    private Motor _motor;

    // Construtor do Carro que cria seu próprio Motor
    public Carro(string tipoMotor)
    {
        _motor = new Motor { Tipo = tipoMotor };
    }

    public void LigarCarro()
    {
        Console.WriteLine("Ligando o carro...");
        _motor.Ligar();
    }
}






