using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Exercicio1
{
    internal class Carro : IVeiculo
    {
        public int Gasolina {  get; set; }
        public Carro(int qntGasolinaInicial)
        {
            Gasolina = qntGasolinaInicial;
        }

        public void Dirigir()
        {
            if (Gasolina > 0)
                Console.WriteLine("Dirigindo o carro");
            else
                Console.WriteLine("Sem gasolina");
        }

        public bool Abastecer(int litros)
        {
            Gasolina += litros;
            return true;
        }
    }
}
