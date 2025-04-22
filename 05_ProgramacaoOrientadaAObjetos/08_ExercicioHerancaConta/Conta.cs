using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ExercicioHerancaConta
{
    internal class Conta
    {
        public int Numero {  get; set; }
        public string? Titular {  get; set; }
        public decimal Saldo { get; set; } = 0.00m;
        public virtual double Juros { get; set; } = 0.00;

        public virtual decimal Sacar(decimal valor) //'virtual' nos diz que nas classes derivadas ele vai ter que ser reimplementado
        {
            Saldo -= valor;
            return Saldo;
        }

        public decimal Depositar(decimal valor)
        {
            Saldo += valor + (Saldo*(decimal)Juros); //'(decimal)' transforma o double em decimal
            return Saldo;
        }
    }
}
