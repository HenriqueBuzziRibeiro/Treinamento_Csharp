using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Exercicio2
{
    internal class LivroFotos
    {
        private int numPaginas;

        public LivroFotos() 
        {
            numPaginas = 16;
        }

        public LivroFotos(int paginasRequeridas)
        {
            numPaginas = paginasRequeridas;
        }

        public int GetNumeroPaginas()
        {
            return numPaginas;
        }
    }

    internal class SuperLivroFotos
    {
        private int numPaginas;

        public SuperLivroFotos() 
        {
            numPaginas = 64;
        }

        public int GetNumeroPaginas()
        {
            return numPaginas;
        }


    }




}
