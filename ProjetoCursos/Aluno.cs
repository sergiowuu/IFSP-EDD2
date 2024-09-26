using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCursos
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<Disciplina> disciplinas = new List<Disciplina>();


        public bool PodeMatricular(Curso curso)
        {
            return disciplinas.Count < 6;
        }

        public void Matricular(Disciplina disciplina)
        {
            if (PodeMatricular(disciplina.Curso))
            {
                disciplinas.Add(disciplina);
            }
        }

        public void Desmatricular(Disciplina disciplina)
        {
            disciplinas.Remove(disciplina);
        }

        public List<Disciplina> GetDisciplinas()
        {
            return disciplinas;
        }
    }
}
