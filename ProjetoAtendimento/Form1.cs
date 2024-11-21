using System;
using System.Text;
using System.Windows.Forms;

namespace ProjetoAtendimento
{
    public partial class Form1 : Form
    {
        private Senhas senhas;
        private Guiches guiches;

        public Form1()
        {
            InitializeComponent();
            senhas = new Senhas();
            guiches = new Guiches();
        }

        private void btnGerarSenha_Click(object sender, EventArgs e)
        {
            senhas.Gerar();
            AtualizarListas();
        }

        private void btnAdicionarGuiche_Click(object sender, EventArgs e)
        {
            guiches.Adicionar(new Guiche(guiches.ListaGuiches.Count + 1));
            AtualizarListas();
        }

        private void btnChamarSenha_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtGuicheId.Text, out int guicheId))
            {
                var guiche = guiches.ListaGuiches.Find(g => g.Id == guicheId);
                if (guiche != null)
                {
                    guiche.Chamar(senhas.FilaSenhas);
                    AtualizarListas();
                }
                else
                {
                    MessageBox.Show("Guichê não encontrado.", "Erro");
                }
            }
            else
            {
                MessageBox.Show("ID do Guichê inválido.", "Erro");
            }
        }

        private void btnListarGuiches_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var guiche in guiches.ListaGuiches)
            {
                sb.AppendLine($"Guichê {guiche.Id} - Atendimentos: {guiche.Atendimentos.Count}");
            }
            MessageBox.Show(sb.ToString(), "Lista de Guichês");
        }

        private void btnListarAtendimentos_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var guiche in guiches.ListaGuiches)
            {
                foreach (var atendimento in guiche.Atendimentos)
                {
                    sb.AppendLine(atendimento.DadosCompletos());
                }
            }
            MessageBox.Show(sb.ToString(), "Lista de Atendimentos");
        }

        private void AtualizarListas()
        {
            lstSenhas.Items.Clear();
            foreach (var senha in senhas.FilaSenhas)
            {
                lstSenhas.Items.Add(senha.DadosParciais());
            }

            lstGuiches.Items.Clear();
            foreach (var guiche in guiches.ListaGuiches)
            {
                lstGuiches.Items.Add($"Guichê {guiche.Id} - Atendimentos: {guiche.Atendimentos.Count}");
            }
        }
    }
}
