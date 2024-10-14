namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtTipoTelefone;
        private System.Windows.Forms.TextBox txtNumeroTelefone;
        private System.Windows.Forms.CheckBox chkPrincipal;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lstContatos;

        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtTipoTelefone = new System.Windows.Forms.TextBox();
            this.txtNumeroTelefone = new System.Windows.Forms.TextBox();
            this.chkPrincipal = new System.Windows.Forms.CheckBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lstContatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.PlaceholderText = "Nome";

            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 38);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.PlaceholderText = "Email";

            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(12, 64);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(50, 20);
            this.txtDia.TabIndex = 2;
            this.txtDia.PlaceholderText = "Dia";

            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(68, 64);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(50, 20);
            this.txtMes.TabIndex = 3;
            this.txtMes.PlaceholderText = "Mês";

            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(124, 64);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(88, 20);
            this.txtAno.TabIndex = 4;
            this.txtAno.PlaceholderText = "Ano";

            // 
            // txtTipoTelefone
            // 
            this.txtTipoTelefone.Location = new System.Drawing.Point(12, 90);
            this.txtTipoTelefone.Name = "txtTipoTelefone";
            this.txtTipoTelefone.Size = new System.Drawing.Size(200, 20);
            this.txtTipoTelefone.TabIndex = 5;
            this.txtTipoTelefone.PlaceholderText = "Tipo de Telefone";

            // 
            // txtNumeroTelefone
            // 
            this.txtNumeroTelefone.Location = new System.Drawing.Point(12, 116);
            this.txtNumeroTelefone.Name = "txtNumeroTelefone";
            this.txtNumeroTelefone.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroTelefone.TabIndex = 6;
            this.txtNumeroTelefone.PlaceholderText = "Número de Telefone";

            // 
            // chkPrincipal
            // 
            this.chkPrincipal.AutoSize = true;
            this.chkPrincipal.Location = new System.Drawing.Point(12, 142);
            this.chkPrincipal.Name = "chkPrincipal";
            this.chkPrincipal.Size = new System.Drawing.Size(68, 17);
            this.chkPrincipal.TabIndex = 7;
            this.chkPrincipal.Text = "Principal";
            this.chkPrincipal.UseVisualStyleBackColor = true;

            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 165);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(93, 165);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);

            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(174, 165);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);

            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(255, 165);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);

            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(336, 165);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 12;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);

            // 
            // lstContatos
            // 
            this.lstContatos.FormattingEnabled = true;
            this.lstContatos.Location = new System.Drawing.Point(12, 194);
            this.lstContatos.Name = "lstContatos";
            this.lstContatos.Size = new System.Drawing.Size(399, 147);
            this.lstContatos.TabIndex = 13;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(423, 353);
            this.Controls.Add(this.lstContatos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.chkPrincipal);
            this.Controls.Add(this.txtNumeroTelefone);
            this.Controls.Add(this.txtTipoTelefone);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Agenda de Contatos";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);

        }

        #endregion
    }
}
