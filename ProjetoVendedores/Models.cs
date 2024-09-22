using System.Collections.Generic;
using System.Linq;

namespace MVC_Vendedores
{
    public class Venda
    {
        public int Qtde { get; set; }
        public double Valor { get; set; }

        public Venda(int qtde, double valor)
        {
            Qtde = qtde;
            Valor = valor;
        }

        public double ValorMedio()
        {
            return Valor / Qtde;
        }
    }

    public class Vendedores
    {
        private List<Vendedor> osVendedores;
        private int max;

        public Vendedores(int max)
        {
            this.max = max;
            osVendedores = new List<Vendedor>(max);
        }

        public bool AddVendedor(Vendedor v)
        {
            if (osVendedores.Count >= max)
            {
                return false;
            }
            osVendedores.Add(v);
            return true;
        }

        public bool DelVendedor(Vendedor v)
        {
            return osVendedores.Remove(v);
        }

        public Vendedor SearchVendedor(int id)
        {
            return osVendedores.FirstOrDefault(v => v.Id == id);
        }

        public double ValorVendas()
        {
            return osVendedores.Sum(v => v.ValorVendas());
        }

        public double ValorComissao()
        {
            return osVendedores.Sum(v => v.ValorComissao());
        }

        // Propriedade pública somente leitura para expor osVendedores
        public IReadOnlyList<Vendedor> OsVendedores => osVendedores.AsReadOnly();
    }

    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double PercComissao { get; set; }
        public Venda[] AsVendas { get; set; }

        public Vendedor(int id, string nome, double percComissao)
        {
            Id = id;
            Nome = nome;
            PercComissao = percComissao;
            AsVendas = new Venda[31];
        }

        public void RegistrarVenda(int dia, Venda venda)
        {
            if (dia < 1 || dia > 31)
            {
                throw new ArgumentException("Dia inválido. Deve ser entre 1 e 31.");
            }
            AsVendas[dia - 1] = venda;
        }

        public double ValorVendas()
        {
            return AsVendas.Where(v => v != null).Sum(v => v.Valor);
        }

        public double ValorComissao()
        {
            return ValorVendas() * PercComissao;
        }
    }
}