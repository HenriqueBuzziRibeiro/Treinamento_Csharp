using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_UpcastingDowncasting
{
    internal class Forma
        {
            protected int xpos, ypos;

            public Forma(int x, int y)
            {
                xpos = x;
                ypos = y;
            }

            public virtual void Desenhar()
            {
                Console.WriteLine($"Desenhar - Forma na posição: ({xpos},{ypos})");
            }
        }
}
