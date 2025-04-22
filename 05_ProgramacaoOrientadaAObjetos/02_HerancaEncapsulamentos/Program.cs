Console.WriteLine("Herança");



Console.ReadKey();

public class ClasseBase
{
    //campos 
    public int public_int = 1;
    protected int protected_int = 2;
    internal int internal_int = 3;
    private int private_int = 4; // a classe filha não consegue acessar diretamente, porém se fizermos uma propriedade pública ela consegue

    public int Private_int
    {
        get { return private_int; }
        set { private_int = value; }
    }

    public void Public_Membro()
    {
        Console.WriteLine("Método público");
    }

    public void Protected_Membro()
    {
        Console.WriteLine("Método protected");
    }

    public void Internal_Membro()
    {
        Console.WriteLine("Método internal");
    }

    public void Protected_internal_Membro()
    {
        Console.WriteLine("Método protected intenal");
    }

    private void Private_Membro()
    {
        Console.WriteLine("Método private");
    }
}

public class ClasseDerivada : ClasseBase
{
    public void Verifica_Acesso()
    {
        Public_Membro();
        Protected_Membro();
        Internal_Membro();
        Protected_internal_Membro();
        //Private_Membro();  --- esse aqui não da de acessar pois ele é um método private

        //Console.WriteLine($"{public_int + protected_int + internal_int + private_int}"); -- não funciona pois estamos tentando acessar o private_int direto pelo atributo
        Console.WriteLine($"{public_int + protected_int + internal_int + Private_int}"); //funciona pois estamos acessando pela propriedade que é pública
    }
}