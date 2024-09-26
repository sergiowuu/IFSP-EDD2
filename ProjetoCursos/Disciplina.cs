using ProjetoCursos;

public class Disciplina
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public Curso Curso { get; set; }
    private List<Aluno> alunos = new List<Aluno>();
    


    public List<Aluno> PesquisarAlunos(string pesquisa)
    {
        return alunos.Where(a => a.Nome.Contains(pesquisa, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public bool MatricularAluno(Aluno aluno)
    {
        if (alunos.Count < 15)
        {
            alunos.Add(aluno);
            aluno.Matricular(this);
            return true;
        }
        return false;
    }

    public bool DesmatricularAluno(Aluno aluno)
    {
        if (alunos.Contains(aluno))
        {
            alunos.Remove(aluno);
            aluno.Desmatricular(this);
            return true;
        }
        return false;
    }

    public bool RemoverAluno(int alunoId)
    {
        Aluno aluno = alunos.Find(a => a.Id == alunoId);
        if (aluno != null)
        {
            alunos.Remove(aluno);
            return true;
        }
        return false; // Aluno não encontrado
    }

    public List<Aluno> GetAlunos()
    {
        return alunos;
    }

    public override string ToString()
    {
        return Descricao;
    }
}
