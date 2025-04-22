using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ClasseAbstrata
{
    internal class Quadrado : Forma
    {
        public double Lado {  get; set; }
        public override void CalculaArea()   //era obrigatório implementar devido a classe abstrata 'Forma'
        {
            Area = Lado * Lado;
        }

        public override void CalcularPerimetro()   //era obrigatório implementar devido a classe abstrata 'Forma'
        {
            Perimetro = 4 * Lado;  
        }

    }
}
