using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OperadorISeAS
{
    internal class Circulo : Forma
    {

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
