using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento
{
    public class Guiche
    {
        public int Id { get; private set; }
        public Queue<Senha> Atendimentos { get; private set; }

        public Guiche()
        {
            Id = 0;
            Atendimentos = new Queue<Senha>();
        }

        public Guiche(int id)
        {
            Id = id;
            Atendimentos = new Queue<Senha>();
        }

        public bool Chamar(Queue<Senha> filaSenhas)
        {
            if (filaSenhas.Count > 0)
            {
                Senha senha = filaSenhas.Dequeue();
                senha.DataAtend = DateTime.Now;
                senha.HoraAtend = DateTime.Now;
                Atendimentos.Enqueue(senha);
                return true;
            }
            return false;
        }
    }
}
