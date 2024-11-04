using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaForms
{
    public class Livro
    {
        public int Isbn { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public List<Exemplar> Exemplares { get; set; } = new List<Exemplar>();

        public void AdicionarExemplar(Exemplar exemplar)
        {
            Exemplares.Add(exemplar);
        }

        public int QtdeExemplares()
        {
            return Exemplares.Count;
        }

        public int QtdeDisponiveis()
        {
            int count = 0;
            foreach (var exemplar in Exemplares)
            {
                if (exemplar.Disponivel) 
                {
                    count++;
                }
            }
            return count;
        }

        public int QtdeEmprestimos()
        {
            int count = 0;
            foreach (var exemplar in Exemplares)
            {
                count += exemplar.QtdeEmprestimos();
            }
            return count;
        }

        public double PercDisponibilidade()
        {
            if (Exemplares.Count == 0) return 0;
            return (double)QtdeDisponiveis() / Exemplares.Count * 100;
        }

        public void Emprestar()
        {
            foreach (var exemplar in Exemplares)
            {
                if (exemplar.Disponivel) 
                {
                    exemplar.Emprestar();
                    break;
                }
            }
        }

        public void Devolver()
        {
            foreach (var exemplar in Exemplares)
            {
                if (!exemplar.Disponivel) 
                {
                    exemplar.Devolver();
                    break;
                }
            }
        }
    }
}
