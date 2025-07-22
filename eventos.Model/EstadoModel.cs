using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Eventos.Model
{
    public class Estado
    {
        public int IdEstado { get; set; }
        public string Estado_nome { get; set; }
        public int IdPais { get; set; }
        public string Pais_nome { get; set; }
    }
}