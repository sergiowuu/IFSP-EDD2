using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCursos
{
    public class Escola
    {
        private List<Curso> cursos = new List<Curso>();

        public bool AdicionarCurso(Curso curso)
        {
            if (cursos.Count < 5)
            {
                cursos.Add(curso);
                return true;
            }
            return false;
        }

        public List<Curso> PesquisarCursos(string pesquisa)
        {
            return cursos.Where(c => c.Descricao.Contains(pesquisa, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Curso PesquisarCurso(int id)
        {
            return cursos.FirstOrDefault(c => c.Id == id);
        }

        public bool RemoverCurso(int id)
        {
            var curso = PesquisarCurso(id);
            if (curso != null && curso.GetDisciplinas().Count == 0)
            {
                cursos.Remove(curso);
                return true;
            }
            return false;
        }

        public bool RemoverAluno(int alunoId)
        {
            foreach (var curso in cursos)
            {
                foreach (var disciplina in curso.GetDisciplinas())
                {
                    if (disciplina.RemoverAluno(alunoId))
                    {
                        return true;
                    }
                }
            }
            return false; // Aluno não encontrado
        }

        public List<Curso> GetCursos()
        {
            return cursos;
        }
    }
}
