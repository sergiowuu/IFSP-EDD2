using System.Text;

namespace ProjetoCursos
{
    public partial class Form1 : Form
    {
        private Escola escola = new Escola();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionarCurso_Click(object sender, EventArgs e)
        {
            int cursoId = int.Parse(txtCursoId.Text);
            string cursoDescricao = txtCursoDescricao.Text;
            Curso curso = new Curso { Id = cursoId, Descricao = cursoDescricao };
            if (escola.AdicionarCurso(curso))
            {
                MessageBox.Show("Curso adicionado com sucesso!");
                cmbCursos.Items.Add(curso);
            }
            else
            {
                MessageBox.Show("Não foi possível adicionar o curso.");
            }
        }

        private void btnAdicionarDisciplina_Click(object sender, EventArgs e)
        {
            int disciplinaId = int.Parse(txtDisciplinaId.Text);
            string disciplinaDescricao = txtDisciplinaDescricao.Text;
            Curso cursoSelecionado = (Curso)cmbCursos.SelectedItem;
            Disciplina disciplina = new Disciplina { Id = disciplinaId, Descricao = disciplinaDescricao };
            if (cursoSelecionado.AdicionarDisciplina(disciplina))
            {
                MessageBox.Show("Disciplina adicionada com sucesso!");
                cmbDisciplinas.Items.Add(disciplina);
            }
            else
            {
                MessageBox.Show("Não foi possível adicionar a disciplina.");
            }
        }

        private void btnMatricularAluno_Click(object sender, EventArgs e)
        {
            int alunoId = int.Parse(txtAlunoId.Text);
            string alunoNome = txtAlunoNome.Text;
            Disciplina disciplinaSelecionada = (Disciplina)cmbDisciplinas.SelectedItem;
            Aluno aluno = new Aluno { Id = alunoId, Nome = alunoNome };
            if (disciplinaSelecionada.MatricularAluno(aluno))
            {
                MessageBox.Show("Aluno matriculado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possível matricular o aluno.");
            }
        }

        private void btnExcluirCurso_Click(object sender, EventArgs e)
        {
            Curso cursoSelecionado = (Curso)cmbCursos.SelectedItem;
            if (cursoSelecionado != null && escola.RemoverCurso(cursoSelecionado.Id))
            {
                MessageBox.Show("Curso excluído com sucesso!");
                cmbCursos.Items.Remove(cursoSelecionado);
            }
            else
            {
                MessageBox.Show("Não foi possível excluir o curso.");
            }
        }

        private void btnExcluirDisciplina_Click(object sender, EventArgs e)
        {
            Disciplina disciplinaSelecionada = (Disciplina)cmbDisciplinas.SelectedItem;
            Curso cursoSelecionado = (Curso)cmbCursos.SelectedItem;
            if (disciplinaSelecionada != null && cursoSelecionado.RemoverDisciplina(disciplinaSelecionada.Id))
            {
                MessageBox.Show("Disciplina excluída com sucesso!");
                cmbDisciplinas.Items.Remove(disciplinaSelecionada);
            }
            else
            {
                MessageBox.Show("Não foi possível excluir a disciplina.");
            }
        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            int alunoId = int.Parse(txtAlunoId.Text);
            Disciplina disciplinaSelecionada = (Disciplina)cmbDisciplinas.SelectedItem;
            if (disciplinaSelecionada != null && disciplinaSelecionada.RemoverAluno(alunoId))
            {
                MessageBox.Show("Aluno excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possível excluir o aluno.");
            }
        }

        private void btnDesmatricularAluno_Click(object sender, EventArgs e)
        {
            int alunoId = int.Parse(txtAlunoId.Text);
            Disciplina disciplinaSelecionada = (Disciplina)cmbDisciplinas.SelectedItem;
            Aluno aluno = disciplinaSelecionada.GetAlunos().Find(a => a.Id == alunoId);
            if (disciplinaSelecionada != null && aluno != null && disciplinaSelecionada.DesmatricularAluno(aluno))
            {
                MessageBox.Show("Aluno desmatriculado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possível desmatricular o aluno.");
            }
        }

        private void btnPesquisarCurso_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisarCurso.Text;
            var cursos = escola.PesquisarCursos(pesquisa);
            cmbCursos.Items.Clear();
            StringBuilder resultado = new StringBuilder();

            foreach (var curso in cursos)
            {
                cmbCursos.Items.Add(curso);
                resultado.AppendLine($"ID: {curso.Id}, Descrição: {curso.Descricao}");
            }

            MessageBox.Show(resultado.Length > 0 ? resultado.ToString() : "Nenhum curso encontrado.");
        }

        private void btnPesquisarDisciplina_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisarDisciplina.Text;
            Curso cursoSelecionado = (Curso)cmbCursos.SelectedItem;
            if (cursoSelecionado == null)
            {
                MessageBox.Show("Selecione um curso primeiro.");
                return;
            }

            var disciplinas = cursoSelecionado.PesquisarDisciplinas(pesquisa);
            cmbDisciplinas.Items.Clear();
            StringBuilder resultado = new StringBuilder();

            foreach (var disciplina in disciplinas)
            {
                cmbDisciplinas.Items.Add(disciplina);
                resultado.AppendLine($"ID: {disciplina.Id}, Descrição: {disciplina.Descricao}");
            }

            MessageBox.Show(resultado.Length > 0 ? resultado.ToString() : "Nenhuma disciplina encontrada.");
        }

        private void btnPesquisarAluno_Click(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisarAluno.Text;
            Disciplina disciplinaSelecionada = (Disciplina)cmbDisciplinas.SelectedItem;
            if (disciplinaSelecionada == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro.");
                return;
            }

            var alunos = disciplinaSelecionada.PesquisarAlunos(pesquisa);
            StringBuilder resultado = new StringBuilder();

            foreach (var aluno in alunos)
            {
                resultado.AppendLine($"ID: {aluno.Id}, Nome: {aluno.Nome}");
                resultado.AppendLine("Disciplinas:");
                foreach (var disciplina in aluno.disciplinas)
                {
                    resultado.AppendLine($"  - ID: {disciplina.Id}, Descrição: {disciplina.Descricao}");
                }
                resultado.AppendLine();
            }

            MessageBox.Show(resultado.Length > 0 ? resultado.ToString() : "Nenhum aluno encontrado.");
        }



    }
}
