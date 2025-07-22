using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Eventos.Model
{
    public class Cidade
    {
        public int IdCidade { get; set; }
        public string Cidade_nome { get; set; }
        public int IdEstado { get; set; }
        public string Estado_nome { get; set; }
        public int IdPais { get; set; }
        public string Pais_nome { get; set; }
    }
    
    public class EstadoPais
    {

        public int IdEstado { get; set; }
        public string Estado_nome { get; set; }
        public int IdPais { get; set; }
        public string Pais_nome { get; set; }

        // Propriedade para exibir estado e país juntos
        public string EstadoPaisConcatenado
        {
            get { return $"{Estado_nome} - {Pais_nome}"; }
        }

        // Mostrar no Grid
        public EstadoPais(int idEstado, string estadoNome, string paisNome)
        {
            IdEstado = idEstado;
            Estado_nome = estadoNome;
            Pais_nome = paisNome;
        }
    }
}