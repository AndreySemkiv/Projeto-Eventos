using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Entidades
{
    public class PaisEnt
    {
        private int id_pais;
        private string descricao;

        public int Id_pais { get => id_pais; set => id_pais = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
