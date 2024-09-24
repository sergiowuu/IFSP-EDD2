using ProjetoCursos;
using System.Collections.Generic;
using System.Linq;

public class Curso
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    private List<Disciplina> disciplinas = new List<Disciplina>();

    public List<Disciplina> PesquisarDisciplinas(string pesquisa)
    {
        return disciplinas.Where(d => d.Descricao.Contains(pesquisa, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public bool AdicionarDisciplina(Disciplina disciplina)
    {
        if (disciplinas.Count < 12)
        {
            disciplinas.Add(disciplina);
            disciplina.Curso = this;
            return true;
        }
        return false;
    }

    public Disciplina PesquisarDisciplina(int id)
    {
        return disciplinas.FirstOrDefault(d => d.Id == id);
    }

    public bool RemoverDisciplina(int id)
    {
        var disciplina = PesquisarDisciplina(id);
        if (disciplina != null && disciplina.GetAlunos().Count == 0)
        {
            disciplinas.Remove(disciplina);
            return true;
        }
        return false;
    }

    public List<Disciplina> GetDisciplinas()
    {
        return disciplinas;
    }

    public override string ToString()
    {
        return Descricao;
    }
}
