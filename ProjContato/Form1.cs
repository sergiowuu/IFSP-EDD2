namespace Agenda
{
    public partial class Form1 : Form
    {
        private Contatos contatos = new Contatos();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var contato = new Contato
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                DtNasc = new Data
                {
                    Dia = int.Parse(txtDia.Text),
                    Mes = int.Parse(txtMes.Text),
                    Ano = int.Parse(txtAno.Text)
                }
            };
            contato.AdicionarTelefone(new Telefone
            {
                Tipo = txtTipoTelefone.Text,
                Numero = txtNumeroTelefone.Text,
                Principal = chkPrincipal.Checked
            });

            if (contatos.Adicionar(contato))
            {
                MessageBox.Show("Contato adicionado com sucesso!");
                AtualizarListaContatos();
            }
            else
            {
                MessageBox.Show("Contato já existe!");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var contato = new Contato { Email = txtEmail.Text };
            var resultado = contatos.Pesquisar(contato);
            if (resultado != null)
            {
                MessageBox.Show(resultado.ToString());
            }
            else
            {
                MessageBox.Show("Contato não encontrado!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var contato = new Contato
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                DtNasc = new Data
                {
                    Dia = int.Parse(txtDia.Text),
                    Mes = int.Parse(txtMes.Text),
                    Ano = int.Parse(txtAno.Text)
                }
            };
            contato.AdicionarTelefone(new Telefone
            {
                Tipo = txtTipoTelefone.Text,
                Numero = txtNumeroTelefone.Text,
                Principal = chkPrincipal.Checked
            });

            if (contatos.Alterar(contato))
            {
                MessageBox.Show("Contato alterado com sucesso!");
                AtualizarListaContatos();
            }
            else
            {
                MessageBox.Show("Contato não encontrado!");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var contato = new Contato { Email = txtEmail.Text };
            if (contatos.Remover(contato))
            {
                MessageBox.Show("Contato removido com sucesso!");
                AtualizarListaContatos();
            }
            else
            {
                MessageBox.Show("Contato não encontrado!");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            AtualizarListaContatos();
        }

        private void AtualizarListaContatos()
        {
            lstContatos.Items.Clear();
            foreach (var contato in contatos.Listar())
            {
                lstContatos.Items.Add(contato.ToString());
            }
        }
    }
}
