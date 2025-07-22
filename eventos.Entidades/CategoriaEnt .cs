using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Entidades
{
    public class CategoriaEnt
    {
        private int id_categoria;
        private string descricao;

        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
