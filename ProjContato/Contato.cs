using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contato
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public Data DtNasc { get; set; }
        public List<Telefone> Telefones { get; set; } = new List<Telefone>();

        public int GetIdade()
        {
            var hoje = DateTime.Today;
            var idade = hoje.Year - DtNasc.Ano;
            if (hoje.Month < DtNasc.Mes || (hoje.Month == DtNasc.Mes && hoje.Day < DtNasc.Dia))
            {
                idade--;
            }
            return idade;
        }

        public void AdicionarTelefone(Telefone t)
        {
            Telefones.Add(t);
        }

        public string GetTelefonePrincipal()
        {
            var telefonePrincipal = Telefones.FirstOrDefault(t => t.Principal);
            return telefonePrincipal != null ? telefonePrincipal.Numero : "Nenhum telefone principal";
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Email: {Email}, Data de Nascimento: {DtNasc}, Telefone Principal: {GetTelefonePrincipal()}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Contato contato)
            {
                return Email == contato.Email;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }

}
