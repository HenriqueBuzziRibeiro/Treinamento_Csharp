using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_PolimorfismoExemplo
{
    internal class Triangulo : Figura
    {

        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um triangulo");
            base.Desenhar(); //vai imprimir o desenhar do classe base
        }


    }
}
