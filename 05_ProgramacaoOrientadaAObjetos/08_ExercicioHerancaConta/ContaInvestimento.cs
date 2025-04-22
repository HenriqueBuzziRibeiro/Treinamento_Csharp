using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ExercicioHerancaConta
{
    internal class ContaInvestimento : Conta
    {
        public override double Juros { get; set; } = 0.009;
        public decimal Imposto { get; set; } = 0.001m;
        
        public override decimal Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo = Saldo - valor - Imposto*Saldo;
                return Saldo;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
                return Saldo;
            }
        }

    }
}
