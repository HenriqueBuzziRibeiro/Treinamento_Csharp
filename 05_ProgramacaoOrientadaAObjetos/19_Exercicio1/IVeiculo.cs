using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Exercicio1
{
    internal interface IVeiculo
    {
        public int Gasolina { get; set; }

        public void Dirigir();

        public bool Abastecer(int qntAbastecer);
    }
}