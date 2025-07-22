using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Eventos.Model
{
    public class Bairro
    {
        public int IdBairro { get; set; }
        public string Bairro_nome { get; set; }
        public int IdCidade { get; set; }
        public string Cidade_nome { get; set; }
        public int IdEstado { get; set; }
        public string Estado_nome { get; set; }
    }

    public class CidadeEstado
    {

        public int IdCidade { get; set; }
        public string Cidade_nome { get; set; }
        public int IdEstado { get; set; }
        public string Estado_nome { get; set; }

        // Propriedade para exibir cidade e estado juntos
        public string CidadeEstadoConcatenado
        {
            get { return $"{Cidade_nome} - {Estado_nome}"; }
        }

        // Mostrar no Grid
        public CidadeEstado(int idCidade, string cidadeNome, string estadoNome)
        {
            IdCidade = idCidade;
            Cidade_nome = cidadeNome;
            Estado_nome = estadoNome;
        }
    }
}