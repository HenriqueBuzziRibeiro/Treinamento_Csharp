using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ClasseAbstrata
{
    internal abstract class Forma
    {
        public string? Cor {  get; set; }
        public double Area {  get; set; }
        public double Perimetro {  get; set; }

        public abstract void CalculaArea(); //assim obrigamos que todas as classes derivadas da classe forma tenham que implementar um método para calcular área
        public abstract void CalcularPerimetro();

        public string Descricao()
        {
            return "Sou uma classe/objeto abstrata do tipo 'Forma'";
        }






    }
}
