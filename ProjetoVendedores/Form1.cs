using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MVC_Vendedores

    //jackson de lima gregório
{
    public partial class Form1 : Form
    {
        private TextBox txtId, txtNome, txtPercComissao, txtIdConsulta, txtIdExcluir, txtIdVenda, txtQtdeVenda, txtValorVenda;
        private MaskedTextBox txtDiaVenda; // Nova definição
        private Button btnCadastrar, btnConsultar, btnExcluir, btnRegistrarVenda, btnListar;
        private ListBox lstVendedores;
        private Vendedores vendedores = new Vendedores(10);

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();

            // Labels
            Label lblId = new Label { Text = "ID:", Location = new Point(20, 0), Width = 200 };
            Label lblNome = new Label { Text = "Nome:", Location = new Point(20, 40), Width = 200 };
            Label lblPercComissao = new Label { Text = "Percentual de Comissão:", Location = new Point(20, 80), Width = 200 };
            Label lblIdConsulta = new Label { Text = "ID para Consulta:", Location = new Point(20, 120), Width = 200 };
            Label lblIdExcluir = new Label { Text = "ID para Exclusão:", Location = new Point(20, 160), Width = 200 };
            Label lblIdVenda = new Label { Text = "ID do Vendedor para Venda:", Location = new Point(20, 200), Width = 200 };
            Label lblDiaVenda = new Label { Text = "Dia da Venda:", Location = new Point(20, 240), Width = 200 };
            Label lblQtdeVenda = new Label { Text = "Quantidade da Venda:", Location = new Point(20, 280), Width = 200 };
            Label lblValorVenda = new Label { Text = "Valor da Venda:", Location = new Point(20, 320), Width = 200 };

            // TextBoxes
            txtId = new TextBox { Location = new Point(20, 20), Width = 200 };
            txtNome = new TextBox { Location = new Point(20, 60), Width = 200 };
            txtPercComissao = new TextBox { Location = new Point(20, 100), Width = 200 };
            txtIdConsulta = new TextBox { Location = new Point(20, 140), Width = 200 };
            txtIdExcluir = new TextBox { Location = new Point(20, 180), Width = 200 };
            txtIdVenda = new TextBox { Location = new Point(20, 220), Width = 200 };
            txtDiaVenda = new MaskedTextBox { Location = new Point(20, 260), Width = 200, Mask = "00" };
            txtQtdeVenda = new TextBox { Location = new Point(20, 300), Width = 200 };
            txtValorVenda = new TextBox { Location = new Point(20, 340), Width = 200 };

            // Buttons
            btnCadastrar = new Button { Text = "Cadastrar", Location = new Point(240, 20), Width = 100 };
            btnConsultar = new Button { Text = "Consultar", Location = new Point(240, 60), Width = 100 };
            btnExcluir = new Button { Text = "Excluir", Location = new Point(240, 100), Width = 100 };
            btnRegistrarVenda = new Button { Text = "Registrar Venda", Location = new Point(240, 140), Width = 100 };
            btnListar = new Button { Text = "Listar", Location = new Point(240, 180), Width = 100 };

            // ListBox
            lstVendedores = new ListBox { Location = new Point(360, 20), Width = 280, Height = 320 };

            // Add controls to the form
            Controls.Add(lblId);
            Controls.Add(lblNome);
            Controls.Add(lblPercComissao);
            Controls.Add(lblIdConsulta);
            Controls.Add(lblIdExcluir);
            Controls.Add(lblIdVenda);
            Controls.Add(lblDiaVenda);
            Controls.Add(lblQtdeVenda);
            Controls.Add(lblValorVenda);
            Controls.Add(txtId);
            Controls.Add(txtNome);
            Controls.Add(txtPercComissao);
            Controls.Add(txtIdConsulta);
            Controls.Add(txtIdExcluir);
            Controls.Add(txtIdVenda);
            Controls.Add(txtDiaVenda);
            Controls.Add(txtQtdeVenda);
            Controls.Add(txtValorVenda);
            Controls.Add(btnCadastrar);
            Controls.Add(btnConsultar);
            Controls.Add(btnExcluir);
            Controls.Add(btnRegistrarVenda);
            Controls.Add(btnListar);
            Controls.Add(lstVendedores);

            // Event Handlers
            btnCadastrar.Click += BtnCadastrar_Click;
            btnConsultar.Click += BtnConsultar_Click;
            btnExcluir.Click += BtnExcluir_Click;
            btnRegistrarVenda.Click += BtnRegistrarVenda_Click;
            btnListar.Click += BtnListar_Click;

            // Form1
            ClientSize = new Size(662, 452);
            Name = "Form1";
            ResumeLayout(false);
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string nome = txtNome.Text;
            double percComissao = double.Parse(txtPercComissao.Text);

            Vendedor vendedor = new Vendedor(id, nome, percComissao);
            if (vendedores.AddVendedor(vendedor))
            {
                MessageBox.Show("Vendedor cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar vendedor. Limite atingido.");
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdConsulta.Text);
            Vendedor vendedor = vendedores.SearchVendedor(id);
            if (vendedor != null)
            {
                var vendas = vendedor.AsVendas.Where(v => v != null);
                double valorMedio = vendas.Any() ? vendas.Average(v => v.ValorMedio()) : 0;
                MessageBox.Show($"ID: {vendedor.Id}\nNome: {vendedor.Nome}\nValor Total das Vendas: {vendedor.ValorVendas()}\nValor da Comissão: {vendedor.ValorComissao()}\nValor Médio das Vendas Diárias: {valorMedio}");
            }
            else
            {
                MessageBox.Show("Vendedor não encontrado.");
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdExcluir.Text);
            Vendedor vendedor = vendedores.SearchVendedor(id);
            if (vendedor != null && vendedores.DelVendedor(vendedor))
            {
                MessageBox.Show("Vendedor excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir vendedor. Verifique se ele possui vendas registradas.");
            }
        }

        private void BtnRegistrarVenda_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdVenda.Text);
            Vendedor vendedor = vendedores.SearchVendedor(id);
            if (vendedor != null)
            {
                int dia = int.Parse(txtDiaVenda.Text);
                int qtde = int.Parse(txtQtdeVenda.Text);
                double valor = double.Parse(txtValorVenda.Text);

                Venda venda = new Venda(qtde, valor);
                vendedor.RegistrarVenda(dia, venda);
                MessageBox.Show("Venda registrada com sucesso!");
            }
            else
            {
                MessageBox.Show("Vendedor não encontrado.");
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            lstVendedores.Items.Clear();
            foreach (var vendedor in vendedores.OsVendedores)
            {
                if (vendedor != null)
                {
                    lstVendedores.Items.Add($"ID: {vendedor.Id}, Nome: {vendedor.Nome}, Valor Total das Vendas: {vendedor.ValorVendas()}, Valor da Comissão: {vendedor.ValorComissao()}");
                }
            }
            lstVendedores.Items.Add($"Total das Vendas: {vendedores.ValorVendas()}");
            lstVendedores.Items.Add($"Total das Comissões: {vendedores.ValorComissao()}");
        }
    }
}
