using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_PolimorfismoExemplo
{
    public class Figura
    {

        public virtual void Desenhar()
        {
            Console.WriteLine("Desenhar na classe base");
        }


    }
}
