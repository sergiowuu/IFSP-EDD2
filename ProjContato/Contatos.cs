using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contatos
    {
        private List<Contato> agenda = new List<Contato>();

        public bool Adicionar(Contato c)
        {
            if (!agenda.Contains(c))
            {
                agenda.Add(c);
                return true;
            }
            return false;
        }

        public Contato Pesquisar(Contato c)
        {
            return agenda.FirstOrDefault(contato => contato.Equals(c));
        }

        public bool Alterar(Contato c)
        {
            var contatoExistente = Pesquisar(c);
            if (contatoExistente != null)
            {
                agenda.Remove(contatoExistente);
                agenda.Add(c);
                return true;
            }
            return false;
        }

        public bool Remover(Contato c)
        {
            return agenda.Remove(c);
        }

        public List<Contato> Listar()
        {
            return new List<Contato>(agenda);
        }
    }

}
