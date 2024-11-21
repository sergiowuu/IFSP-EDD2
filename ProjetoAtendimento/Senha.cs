using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento
{
    public class Senha
    {
        public int Id { get; private set; }
        public DateTime DataGerac { get; private set; }
        public DateTime HoraGerac { get; private set; }
        public DateTime DataAtend { get; set; }
        public DateTime HoraAtend { get; set; }

        public Senha(int id)
        {
            Id = id;
            DataGerac = DateTime.Now;
            HoraGerac = DateTime.Now;
        }

        public string DadosParciais()
        {
            return $"{Id} - {DataGerac.ToShortDateString()} - {HoraGerac.ToShortTimeString()}";
        }

        public string DadosCompletos()
        {
            return $"{Id} - {DataGerac.ToShortDateString()} - {HoraGerac.ToShortTimeString()} - {DataAtend.ToShortDateString()} - {HoraAtend.ToShortTimeString()}";
        }
    }
}
