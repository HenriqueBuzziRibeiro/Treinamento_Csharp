using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_AgragacaoRelacionamento
{
    class Professor
    {
        public string Nome { get; set; }
        public string? Disciplina { get; set; }
        public Professor(string? nome, string? disciplina)
        {
            this.Nome = nome;
            this.Disciplina = disciplina; 
        }
    }




}
