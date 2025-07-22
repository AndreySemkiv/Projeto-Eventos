using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Entidades
{
    public class TemaEnt
    {
        private int id_tema;
        private string descricao;

        public int Id_tema { get => id_tema; set => id_tema = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
