using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_AgragacaoRelacionamento
{
    internal class Departamento
    {
        public string? Nome { get; set; }
        public List<Professor> professores { get; set; }

        public Departamento(string? nome)
        {
            Nome = nome;
            professores = new List<Professor>();
        
        }

        public void IncluirProfessor(Professor professor)
        {
            professores.Add(professor);
        }

        public void ListaProfessores()
        {
            Console.WriteLine($"Departamento de {Nome}");

            foreach(Professor prof in professores)
            {
                Console.WriteLine($"{prof.Nome} da disciplina {prof.Disciplina}");
            }
        }


    }
}
