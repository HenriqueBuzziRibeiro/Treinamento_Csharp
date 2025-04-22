using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_UpcastingDowncasting
{
    internal class Circulo : Forma
    {
        public Circulo(int x, int y) : base(x, y) //está invocando o construtor da classe base
        {

        }

        public override void Desenhar()
        {
            Console.WriteLine($"Desenha círculo na posição: ({xpos},{ypos})");
        }

        public void PintarCirculo()
        {
            Console.WriteLine("Pintar o Circulo");
        }
    }
}
