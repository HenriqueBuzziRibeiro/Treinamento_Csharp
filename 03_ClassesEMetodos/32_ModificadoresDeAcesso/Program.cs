Console.WriteLine("Modificadores de acesso");

/*

public            : Ilimitado. O membro ou tipo pode ser acessado de qualquer lugar, seja dentro da mesma classe, de outras classes no mesmo assembly (projeto) ou de outros assemblies (projetos referenciados).
private           : Restrito à própria classe. O membro só pode ser acessado dentro da classe onde foi declarado. É o modificador de acesso mais restritivo.
protected         : Restrito à própria classe e às classes derivadas (herança). O membro pode ser acessado dentro da classe onde foi declarado e em classes que herdam dessa classe. 
internal          : Restrito ao mesmo assembly (projeto). O membro ou tipo pode ser acessado por qualquer código dentro do mesmo assembly, mas não de outros assemblies.
protected internal: Combinação de protected e internal. O membro pode ser acessado dentro do mesmo assembly ou em classes derivadas, mesmo que estejam em outros assemblies.
private protected : Restrito à própria classe e às classes derivadas no mesmo assembly. O membro pode ser acessado apenas dentro da classe onde foi declarado ou em classes derivadas que estejam no mesmo assembly.

*/

Console.ReadKey();