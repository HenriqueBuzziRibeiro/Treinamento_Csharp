using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _16_HerancaXComposicao
{
    internal class Humano : Animal
    {
        private readonly ComportamentoAndar _comportamentoAndar;

        public Humano(ComportamentoAndar comportamentoAndar)
        {
            _comportamentoAndar = comportamentoAndar;
        }

        public void Locomocao()
        {
            Console.WriteLine(nameof(Humano)); //nameof produz o nome da classe Humano, que é Humano
            _comportamentoAndar.Andar();
        }




    }
}
