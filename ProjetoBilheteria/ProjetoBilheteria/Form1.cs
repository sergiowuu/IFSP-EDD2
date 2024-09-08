using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBilheteria
{
    public partial class Form1 : Form
    {
        private CheckBox[] poltrona;
        private Button btnOcupacao;
        private Button btnDesocupar;
        private Label lblOcupacao;

        private void InitializeMyComponents()
        {
            poltrona = new CheckBox[5 * 5];

            for (int col = 0; col < 5; col++)
            {
                for (int lin = 0; lin < 5; lin++)
                {
                    int index = col * 5 + lin;
                    poltrona[index] = new CheckBox();
                    poltrona[index].Parent = this;
                    poltrona[index].Checked = false;
                    poltrona[index].Top = 25 * (lin + 1);
                    poltrona[index].Left = 105 * col;
                }
            }

            btnOcupacao = new Button();
            btnOcupacao.Parent = this;
            btnOcupacao.Left = 178;
            btnOcupacao.Top = 200;
            btnOcupacao.Text = "Ver Ocupaçao";
            btnOcupacao.Width = 100;
            btnOcupacao.Click += new EventHandler(ocupar);

            btnDesocupar = new Button();
            btnDesocupar.Parent = this;
            btnDesocupar.Left = 178;
            btnDesocupar.Top = 225;
            btnDesocupar.Text = "Desocupar tudo";
            btnDesocupar.Width = 100;
            btnDesocupar.Click += new EventHandler(desocupar);

            lblOcupacao = new Label();
            lblOcupacao.Parent = this;
            lblOcupacao.Left = 190;
            lblOcupacao.Top = 180;
            lblOcupacao.Text = "Ocupação: 0%";

        }

        private void ocupar(object sender, EventArgs e)
        {
            int total = poltrona.Length;
            int ocupado = 0;

            foreach (CheckBox cb in poltrona)
            {
                if (cb.Checked)
                {
                    ocupado++;
                }
            }

            double percentual = (ocupado / (double)total) * 100;

            lblOcupacao.Text = $"Ocupação: {percentual}%";
        }

        private void desocupar(object sender, EventArgs e)
        {
            foreach (CheckBox cb in poltrona)
            {
                cb.Checked = false;
            }

            lblOcupacao.Text = "Ocupação: 0%";
        }

        public Form1()
        {
            InitializeComponent();
            InitializeMyComponents();
        }
    }
}
