using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Exercicio3
{
    internal class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
        }

        public void Explicar()
        {
            Console.WriteLine($"Professor {Nome} está explicando");
        }
    }
}