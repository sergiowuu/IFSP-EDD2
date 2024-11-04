using System;
using System.Windows.Forms;

namespace BibliotecaForms
{
    public partial class Form1 : Form
    {
        private Livros livros = new Livros();

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            this.Text = "Sistema de Biblioteca";
            this.Size = new System.Drawing.Size(1000, 1000);

           
            string imagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bibliotecaria.png");
            this.BackgroundImage = Image.FromFile(imagePath);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            var menu = new MenuStrip();
            var menuArquivo = new ToolStripMenuItem("Arquivo");
            var menuSair = new ToolStripMenuItem("Sair", null, (s, e) => this.Close());
            menuArquivo.DropDownItems.Add(menuSair);
            menu.Items.Add(menuArquivo);

            var menuLivros = new ToolStripMenuItem("Livros");
            var menuAdicionarLivro = new ToolStripMenuItem("Adicionar Livro", null, AdicionarLivro);
            var menuPesquisarLivro = new ToolStripMenuItem("Pesquisar Livro", null, PesquisarLivro);
            var menuRegistrarEmprestimo = new ToolStripMenuItem("Registrar Empr�stimo", null, RegistrarEmprestimo);
            var menuRegistrarDevolucao = new ToolStripMenuItem("Registrar Devolu��o", null, RegistrarDevolucao);
            menuLivros.DropDownItems.Add(menuAdicionarLivro);
            menuLivros.DropDownItems.Add(menuPesquisarLivro);
            menuLivros.DropDownItems.Add(menuRegistrarEmprestimo);
            menuLivros.DropDownItems.Add(menuRegistrarDevolucao);
            menu.Items.Add(menuLivros);

            this.MainMenuStrip = menu;
            this.Controls.Add(menu);
        }


        private void AdicionarLivro(object? sender, EventArgs e)
        {
            var form = new Form();
            form.Text = "Adicionar Livro";
            form.Size = new System.Drawing.Size(600, 600);

            var lblIsbn = new Label { Text = "ISBN", Top = 20 };
            var txtIsbn = new TextBox { Top = 20, Left = 100, Width = 200 };

            var lblTitulo = new Label { Text = "T�tulo", Top = 60 };
            var txtTitulo = new TextBox { Top = 60, Left = 100, Width = 200 };

            var lblAutor = new Label { Text = "Autor", Top = 100 };
            var txtAutor = new TextBox { Top = 100, Left = 100, Width = 200 };

            var lblEditora = new Label { Text = "Editora", Top = 140 };
            var txtEditora = new TextBox { Top = 140, Left = 100, Width = 200 };

            var lblQtdeExemplares = new Label { Text = "Quantidade de Exemplares", Top = 180 };
            var txtQtdeExemplares = new TextBox { Top = 180, Left = 200, Width = 100 };

            var btnSalvar = new Button { Text = "Salvar", Top = 220 };
            btnSalvar.Click += (s, ev) =>
            {
                if (int.TryParse(txtIsbn.Text.Trim(), out int isbn) && int.TryParse(txtQtdeExemplares.Text.Trim(), out int qtdeExemplares))
                {
                    var livro = new Livro
                    {
                        Isbn = isbn,
                        Titulo = txtTitulo.Text,
                        Autor = txtAutor.Text,
                        Editora = txtEditora.Text
                    };

                    for (int i = 0; i < qtdeExemplares; i++)
                    {
                        livro.AdicionarExemplar(new Exemplar());
                    }

                    livros.Adicionar(livro);
                    form.Close();
                }
                else
                {
                    MessageBox.Show("Coloque valores num�ricos v�lidos em ISBN e Quantidade de Exemplares.");
                }
            };

            form.Controls.Add(lblIsbn);
            form.Controls.Add(txtIsbn);
            form.Controls.Add(lblTitulo);
            form.Controls.Add(txtTitulo);
            form.Controls.Add(lblAutor);
            form.Controls.Add(txtAutor);
            form.Controls.Add(lblEditora);
            form.Controls.Add(txtEditora);
            form.Controls.Add(lblQtdeExemplares);
            form.Controls.Add(txtQtdeExemplares);
            form.Controls.Add(btnSalvar);

            form.ShowDialog();
        }


        private void PesquisarLivro(object? sender, EventArgs e)
        {
            var form = new Form();
            form.Text = "Pesquisar Livro";
            form.Size = new System.Drawing.Size(400, 400);

            var lblIsbn = new Label { Text = "ISBN", Top = 20 };
            var txtIsbn = new TextBox { Top = 20, Left = 100, Width = 200 };

            var btnPesquisar = new Button { Text = "Pesquisar", Top = 60, Left = 100 };
            btnPesquisar.Click += (s, ev) =>
            {
                var isbn = int.Parse(txtIsbn.Text);
                var livro = livros.Pesquisar(isbn);
                if (livro != null)
                {
                    MessageBox.Show($"T�tulo: {livro.Titulo}\nAutor: {livro.Autor}\nEditora: {livro.Editora}\nTotal de Exemplares: {livro.QtdeExemplares()}\nDispon�veis: {livro.QtdeDisponiveis()}\nEmpr�stimos: {livro.QtdeEmprestimos()}\nPercentual de Disponibilidade: {livro.PercDisponibilidade()}%");
                }
                else
                {
                    MessageBox.Show("Livro n�o encontrado.");
                }
            };

            form.Controls.Add(lblIsbn);
            form.Controls.Add(txtIsbn);
            form.Controls.Add(btnPesquisar);

            form.ShowDialog();
        }

        private void RegistrarEmprestimo(object? sender, EventArgs e)
        {
            var form = new Form();
            form.Text = "Registrar Empr�stimo";
            form.Size = new System.Drawing.Size(400, 400);

            var lblIsbn = new Label { Text = "ISBN", Top = 20 };
            var txtIsbn = new TextBox { Top = 20, Left = 100, Width = 200 };

            var btnEmprestar = new Button { Text = "Emprestar", Top = 60, Left = 100 };
            btnEmprestar.Click += (s, ev) =>
            {
                var isbn = int.Parse(txtIsbn.Text);
                var livro = livros.Pesquisar(isbn);
                if (livro != null && livro.QtdeDisponiveis() > 0)
                {
                    livro.Emprestar();
                    MessageBox.Show("Empr�stimo registrado com sucesso.");
                }
                else
                {
                    MessageBox.Show("Livro n�o dispon�vel para empr�stimo.");
                }
            };

            form.Controls.Add(lblIsbn);
            form.Controls.Add(txtIsbn);
            form.Controls.Add(btnEmprestar);

            form.ShowDialog();
        }

        private void RegistrarDevolucao(object? sender, EventArgs e)
        {
            var form = new Form();
            form.Text = "Registrar Devolu��o";
            form.Size = new System.Drawing.Size(400, 400);

            var lblIsbn = new Label { Text = "ISBN", Top = 20 };
            var txtIsbn = new TextBox { Top = 20, Left = 100, Width = 200 };

            var btnDevolver = new Button { Text = "Devolver", Top = 60, Left = 100 };
            btnDevolver.Click += (s, ev) =>
            {
                var isbn = int.Parse(txtIsbn.Text);
                var livro = livros.Pesquisar(isbn);
                if (livro != null && livro.QtdeEmprestimos() > 0)
                {
                    livro.Devolver();
                    MessageBox.Show("Devolu��o registrada com sucesso.");
                }
                else
                {
                    MessageBox.Show("Nenhum empr�stimo registrado para este livro.");
                }
            };

            form.Controls.Add(lblIsbn);
            form.Controls.Add(txtIsbn);
            form.Controls.Add(btnDevolver);

            form.ShowDialog();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
          
            MessageBox.Show("Bem-vindo ao Sistema de Biblioteca!");

            var livrosIniciais = new List<Livro>
            {
                new Livro { Isbn = 123, Titulo = "livro teste 1", Autor = "Autor 1", Editora = "Editora 4" },
                new Livro { Isbn = 456, Titulo = "Liovro", Autor = "Autor 2", Editora = "Editora 3" }
            };

            foreach (var livro in livrosIniciais)
            {
                livros.Adicionar(livro);
            }
        }
    }
}
