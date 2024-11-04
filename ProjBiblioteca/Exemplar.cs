using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaForms
{
    public class Exemplar
    {
        public bool Disponivel { get; private set; } = true;
        private int emprestimos = 0;

        public void Emprestar()
        {
            if (Disponivel)
            {
                Disponivel = false;
                emprestimos++;
            }
        }

        public void Devolver()
        {
            if (!Disponivel)
            {
                Disponivel = true;
            }
        }

        public int QtdeEmprestimos()
        {
            return emprestimos;
        }
    }
}
