using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceExercicio
{
    public interface ISalvar
    {
        void Salvar();

        void Compactar() //para ter acesso a esse método eu tenho que que fazer o objeto referenciar essa interface
        {
            Console.WriteLine("Compactando arquivos");
        }

    }
}
