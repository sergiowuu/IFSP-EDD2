namespace ProjetoCursos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MaskedTextBox txtCursoId;
        private System.Windows.Forms.TextBox txtCursoDescricao;
        private System.Windows.Forms.Button btnAdicionarCurso;
        private System.Windows.Forms.MaskedTextBox txtDisciplinaId;
        private System.Windows.Forms.TextBox txtDisciplinaDescricao;
        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.Button btnAdicionarDisciplina;
        private System.Windows.Forms.MaskedTextBox txtAlunoId;
        private System.Windows.Forms.TextBox txtAlunoNome;
        private System.Windows.Forms.ComboBox cmbDisciplinas;
        private System.Windows.Forms.Button btnMatricularAluno;
        private System.Windows.Forms.Button btnExcluirCurso;
        private System.Windows.Forms.Button btnExcluirDisciplina;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.Button btnDesmatricularAluno;
        private System.Windows.Forms.TextBox txtPesquisarCurso;
        private System.Windows.Forms.Button btnPesquisarCurso;
        private System.Windows.Forms.TextBox txtPesquisarDisciplina;
        private System.Windows.Forms.Button btnPesquisarDisciplina;
        private System.Windows.Forms.TextBox txtPesquisarAluno;
        private System.Windows.Forms.Button btnPesquisarAluno;

        private void InitializeComponent()
        {
            txtCursoId = new MaskedTextBox();
            txtCursoDescricao = new TextBox();
            btnAdicionarCurso = new Button();
            txtDisciplinaId = new MaskedTextBox();
            txtDisciplinaDescricao = new TextBox();
            cmbCursos = new ComboBox();
            btnAdicionarDisciplina = new Button();
            txtAlunoId = new MaskedTextBox();
            txtAlunoNome = new TextBox();
            cmbDisciplinas = new ComboBox();
            btnMatricularAluno = new Button();
            btnExcluirCurso = new Button();
            btnExcluirDisciplina = new Button();
            btnExcluirAluno = new Button();
            btnDesmatricularAluno = new Button();
            txtPesquisarCurso = new TextBox();
            btnPesquisarCurso = new Button();
            txtPesquisarDisciplina = new TextBox();
            btnPesquisarDisciplina = new Button();
            txtPesquisarAluno = new TextBox();
            btnPesquisarAluno = new Button();
            lblCursoId = new Label();
            lblCursoDescricao = new Label();
            lblDisciplinaId = new Label();
            lblDisciplinaDescricao = new Label();
            lblAlunoId = new Label();
            lblAlunoNome = new Label();
            lblPesquisarCurso = new Label();
            lblPesquisarDisciplina = new Label();
            lblPesquisarAluno = new Label();
            SuspendLayout();
            // 
            // txtCursoId
            // 
            txtCursoId.Location = new Point(12, 12);
            txtCursoId.Mask = "00000";
            txtCursoId.Name = "txtCursoId";
            txtCursoId.Size = new Size(100, 23);
            txtCursoId.TabIndex = 0;
            txtCursoId.ValidatingType = typeof(int);
            // 
            // txtCursoDescricao
            // 
            txtCursoDescricao.Location = new Point(12, 38);
            txtCursoDescricao.Name = "txtCursoDescricao";
            txtCursoDescricao.PlaceholderText = "Descrição do Curso";
            txtCursoDescricao.Size = new Size(100, 23);
            txtCursoDescricao.TabIndex = 1;
            // 
            // btnAdicionarCurso
            // 
            btnAdicionarCurso.Location = new Point(12, 64);
            btnAdicionarCurso.Name = "btnAdicionarCurso";
            btnAdicionarCurso.Size = new Size(100, 23);
            btnAdicionarCurso.TabIndex = 2;
            btnAdicionarCurso.Text = "Adicionar Curso";
            btnAdicionarCurso.UseVisualStyleBackColor = true;
            btnAdicionarCurso.Click += btnAdicionarCurso_Click;
            // 
            // txtDisciplinaId
            // 
            txtDisciplinaId.Location = new Point(12, 93);
            txtDisciplinaId.Mask = "00000";
            txtDisciplinaId.Name = "txtDisciplinaId";
            txtDisciplinaId.Size = new Size(100, 23);
            txtDisciplinaId.TabIndex = 3;
            // 
            // txtDisciplinaDescricao
            // 
            txtDisciplinaDescricao.Location = new Point(12, 119);
            txtDisciplinaDescricao.Name = "txtDisciplinaDescricao";
            txtDisciplinaDescricao.PlaceholderText = "Descrição da Disciplina";
            txtDisciplinaDescricao.Size = new Size(100, 23);
            txtDisciplinaDescricao.TabIndex = 4;
            // 
            // cmbCursos
            // 
            cmbCursos.FormattingEnabled = true;
            cmbCursos.Location = new Point(12, 145);
            cmbCursos.Name = "cmbCursos";
            cmbCursos.Size = new Size(100, 23);
            cmbCursos.TabIndex = 5;
            // 
            // btnAdicionarDisciplina
            // 
            btnAdicionarDisciplina.Location = new Point(12, 172);
            btnAdicionarDisciplina.Name = "btnAdicionarDisciplina";
            btnAdicionarDisciplina.Size = new Size(100, 23);
            btnAdicionarDisciplina.TabIndex = 6;
            btnAdicionarDisciplina.Text = "Adicionar Disciplina";
            btnAdicionarDisciplina.UseVisualStyleBackColor = true;
            btnAdicionarDisciplina.Click += btnAdicionarDisciplina_Click;
            // 
            // txtAlunoId
            // 
            txtAlunoId.Location = new Point(12, 201);
            txtAlunoId.Mask = "00000";
            txtAlunoId.Name = "txtAlunoId";
            txtAlunoId.Size = new Size(100, 23);
            txtAlunoId.TabIndex = 7;
            txtAlunoId.ValidatingType = typeof(int);
            // 
            // txtAlunoNome
            // 
            txtAlunoNome.Location = new Point(12, 227);
            txtAlunoNome.Name = "txtAlunoNome";
            txtAlunoNome.PlaceholderText = "Nome do Aluno";
            txtAlunoNome.Size = new Size(100, 23);
            txtAlunoNome.TabIndex = 8;
            // 
            // cmbDisciplinas
            // 
            cmbDisciplinas.FormattingEnabled = true;
            cmbDisciplinas.Location = new Point(12, 253);
            cmbDisciplinas.Name = "cmbDisciplinas";
            cmbDisciplinas.Size = new Size(100, 23);
            cmbDisciplinas.TabIndex = 9;
            // 
            // btnMatricularAluno
            // 
            btnMatricularAluno.Location = new Point(12, 280);
            btnMatricularAluno.Name = "btnMatricularAluno";
            btnMatricularAluno.Size = new Size(100, 23);
            btnMatricularAluno.TabIndex = 10;
            btnMatricularAluno.Text = "Matricular Aluno";
            btnMatricularAluno.UseVisualStyleBackColor = true;
            btnMatricularAluno.Click += btnMatricularAluno_Click;
            // 
            // btnExcluirCurso
            // 
            btnExcluirCurso.Location = new Point(130, 64);
            btnExcluirCurso.Name = "btnExcluirCurso";
            btnExcluirCurso.Size = new Size(100, 23);
            btnExcluirCurso.TabIndex = 11;
            btnExcluirCurso.Text = "Excluir Curso";
            btnExcluirCurso.UseVisualStyleBackColor = true;
            btnExcluirCurso.Click += btnExcluirCurso_Click;
            // 
            // btnExcluirDisciplina
            // 
            btnExcluirDisciplina.Location = new Point(130, 172);
            btnExcluirDisciplina.Name = "btnExcluirDisciplina";
            btnExcluirDisciplina.Size = new Size(100, 23);
            btnExcluirDisciplina.TabIndex = 12;
            btnExcluirDisciplina.Text = "Excluir Disciplina";
            btnExcluirDisciplina.UseVisualStyleBackColor = true;
            btnExcluirDisciplina.Click += btnExcluirDisciplina_Click;
            // 
            // btnExcluirAluno
            // 
            btnExcluirAluno.Location = new Point(130, 280);
            btnExcluirAluno.Name = "btnExcluirAluno";
            btnExcluirAluno.Size = new Size(211, 23);
            btnExcluirAluno.TabIndex = 13;
            btnExcluirAluno.Text = "Excluir Aluno";
            btnExcluirAluno.UseVisualStyleBackColor = true;
            btnExcluirAluno.Click += btnExcluirAluno_Click;
            // 
            // btnDesmatricularAluno
            // 
            btnDesmatricularAluno.Location = new Point(188, 201);
            btnDesmatricularAluno.Name = "btnDesmatricularAluno";
            btnDesmatricularAluno.Size = new Size(211, 23);
            btnDesmatricularAluno.TabIndex = 14;
            btnDesmatricularAluno.Text = "Desmatricular aluno";
            btnDesmatricularAluno.UseVisualStyleBackColor = true;
            btnDesmatricularAluno.Click += btnDesmatricularAluno_Click;
            // 
            // txtPesquisarCurso
            // 
            txtPesquisarCurso.Location = new Point(12, 338);
            txtPesquisarCurso.Name = "txtPesquisarCurso";
            txtPesquisarCurso.PlaceholderText = "Nome Curso";
            txtPesquisarCurso.Size = new Size(100, 23);
            txtPesquisarCurso.TabIndex = 15;
            // 
            // btnPesquisarCurso
            // 
            btnPesquisarCurso.Location = new Point(130, 338);
            btnPesquisarCurso.Name = "btnPesquisarCurso";
            btnPesquisarCurso.Size = new Size(211, 23);
            btnPesquisarCurso.TabIndex = 16;
            btnPesquisarCurso.Text = "Pesquisar Curso";
            btnPesquisarCurso.UseVisualStyleBackColor = true;
            btnPesquisarCurso.Click += btnPesquisarCurso_Click;
            // 
            // txtPesquisarDisciplina
            // 
            txtPesquisarDisciplina.Location = new Point(12, 402);
            txtPesquisarDisciplina.Name = "txtPesquisarDisciplina";
            txtPesquisarDisciplina.PlaceholderText = "Nome Disciplina";
            txtPesquisarDisciplina.Size = new Size(100, 23);
            txtPesquisarDisciplina.TabIndex = 17;
            // 
            // btnPesquisarDisciplina
            // 
            btnPesquisarDisciplina.Location = new Point(130, 401);
            btnPesquisarDisciplina.Name = "btnPesquisarDisciplina";
            btnPesquisarDisciplina.Size = new Size(211, 23);
            btnPesquisarDisciplina.TabIndex = 18;
            btnPesquisarDisciplina.Text = "Pesquisar Disciplina";
            btnPesquisarDisciplina.UseVisualStyleBackColor = true;
            btnPesquisarDisciplina.Click += btnPesquisarDisciplina_Click;
            // 
            // txtPesquisarAluno
            // 
            txtPesquisarAluno.Location = new Point(12, 446);
            txtPesquisarAluno.Name = "txtPesquisarAluno";
            txtPesquisarAluno.PlaceholderText = "Nome Aluno";
            txtPesquisarAluno.Size = new Size(100, 23);
            txtPesquisarAluno.TabIndex = 19;
            // 
            // btnPesquisarAluno
            // 
            btnPesquisarAluno.Location = new Point(130, 445);
            btnPesquisarAluno.Name = "btnPesquisarAluno";
            btnPesquisarAluno.Size = new Size(211, 23);
            btnPesquisarAluno.TabIndex = 20;
            btnPesquisarAluno.Text = "Pesquisar Aluno";
            btnPesquisarAluno.UseVisualStyleBackColor = true;
            btnPesquisarAluno.Click += btnPesquisarAluno_Click;
            // 
            // lblCursoId
            // 
            lblCursoId.AutoSize = true;
            lblCursoId.Location = new Point(118, 15);
            lblCursoId.Name = "lblCursoId";
            lblCursoId.Size = new Size(52, 15);
            lblCursoId.TabIndex = 21;
            lblCursoId.Text = "ID Curso";
            // 
            // lblCursoDescricao
            // 
            lblCursoDescricao.AutoSize = true;
            lblCursoDescricao.Location = new Point(118, 41);
            lblCursoDescricao.Name = "lblCursoDescricao";
            lblCursoDescricao.Size = new Size(92, 15);
            lblCursoDescricao.TabIndex = 22;
            lblCursoDescricao.Text = "Descrição Curso";
            // 
            // lblDisciplinaId
            // 
            lblDisciplinaId.AutoSize = true;
            lblDisciplinaId.Location = new Point(118, 96);
            lblDisciplinaId.Name = "lblDisciplinaId";
            lblDisciplinaId.Size = new Size(72, 15);
            lblDisciplinaId.TabIndex = 23;
            lblDisciplinaId.Text = "ID Disciplina";
            // 
            // lblDisciplinaDescricao
            // 
            lblDisciplinaDescricao.AutoSize = true;
            lblDisciplinaDescricao.Location = new Point(118, 122);
            lblDisciplinaDescricao.Name = "lblDisciplinaDescricao";
            lblDisciplinaDescricao.Size = new Size(112, 15);
            lblDisciplinaDescricao.TabIndex = 24;
            lblDisciplinaDescricao.Text = "Descrição Disciplina";
            // 
            // lblAlunoId
            // 
            lblAlunoId.AutoSize = true;
            lblAlunoId.Location = new Point(118, 204);
            lblAlunoId.Name = "lblAlunoId";
            lblAlunoId.Size = new Size(53, 15);
            lblAlunoId.TabIndex = 25;
            lblAlunoId.Text = "ID Aluno";
            // 
            // lblAlunoNome
            // 
            lblAlunoNome.AutoSize = true;
            lblAlunoNome.Location = new Point(118, 230);
            lblAlunoNome.Name = "lblAlunoNome";
            lblAlunoNome.Size = new Size(92, 15);
            lblAlunoNome.TabIndex = 26;
            lblAlunoNome.Text = "Nome do Aluno";
            // 
            // lblPesquisarCurso
            // 
            lblPesquisarCurso.AutoSize = true;
            lblPesquisarCurso.Location = new Point(12, 320);
            lblPesquisarCurso.Name = "lblPesquisarCurso";
            lblPesquisarCurso.Size = new Size(91, 15);
            lblPesquisarCurso.TabIndex = 27;
            lblPesquisarCurso.Text = "Pesquisar Curso";
            // 
            // lblPesquisarDisciplina
            // 
            lblPesquisarDisciplina.AutoSize = true;
            lblPesquisarDisciplina.Location = new Point(11, 375);
            lblPesquisarDisciplina.Name = "lblPesquisarDisciplina";
            lblPesquisarDisciplina.Size = new Size(111, 15);
            lblPesquisarDisciplina.TabIndex = 28;
            lblPesquisarDisciplina.Text = "Pesquisar Disciplina";
            // 
            // lblPesquisarAluno
            // 
            lblPesquisarAluno.AutoSize = true;
            lblPesquisarAluno.Location = new Point(11, 428);
            lblPesquisarAluno.Name = "lblPesquisarAluno";
            lblPesquisarAluno.Size = new Size(92, 15);
            lblPesquisarAluno.TabIndex = 29;
            lblPesquisarAluno.Text = "Pesquisar Aluno";
            // 
            // Form1
            // 
            ClientSize = new Size(582, 605);
            Controls.Add(lblCursoId);
            Controls.Add(lblCursoDescricao);
            Controls.Add(lblDisciplinaId);
            Controls.Add(lblDisciplinaDescricao);
            Controls.Add(lblAlunoId);
            Controls.Add(lblAlunoNome);
            Controls.Add(lblPesquisarCurso);
            Controls.Add(lblPesquisarDisciplina);
            Controls.Add(lblPesquisarAluno);
            Controls.Add(txtCursoId);
            Controls.Add(txtCursoDescricao);
            Controls.Add(btnAdicionarCurso);
            Controls.Add(txtDisciplinaId);
            Controls.Add(txtDisciplinaDescricao);
            Controls.Add(cmbCursos);
            Controls.Add(btnAdicionarDisciplina);
            Controls.Add(txtAlunoId);
            Controls.Add(txtAlunoNome);
            Controls.Add(cmbDisciplinas);
            Controls.Add(btnMatricularAluno);
            Controls.Add(btnExcluirCurso);
            Controls.Add(btnExcluirDisciplina);
            Controls.Add(btnExcluirAluno);
            Controls.Add(btnDesmatricularAluno);
            Controls.Add(txtPesquisarCurso);
            Controls.Add(btnPesquisarCurso);
            Controls.Add(txtPesquisarDisciplina);
            Controls.Add(btnPesquisarDisciplina);
            Controls.Add(txtPesquisarAluno);
            Controls.Add(btnPesquisarAluno);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblCursoId;
        private Label lblCursoDescricao;
        private Label lblDisciplinaId;
        private Label lblDisciplinaDescricao;
        private Label lblAlunoId;
        private Label lblAlunoNome;
        private Label lblPesquisarCurso;
        private Label lblPesquisarDisciplina;
        private Label lblPesquisarAluno;
    }
}
