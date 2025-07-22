using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Eventos.Model
{
    public class Rua
    {
        public int IdRua { get; set; }
        public string Rua_nome { get; set; }
        public string Cep_rua { get; set; }
        public int IdBairro { get; set; }
        public string Bairro_nome { get; set; }
        public int IdCidade { get; set; }
        public string Cidade_nome { get; set; }
        public int IdEstado { get; set; }
        public string Estado_nome { get; set; }
    }

    public class BairroCidade
    {

        public int IdBairro { get; set; }
        public string Bairro_nome { get; set; }
        public int IdCidade { get; set; }
        public string Cidade_nome { get; set; }
        public int IdEstado { get; set; }
        public string Estado_nome { get; set; }

        // Propriedade para exibir bairro, cidade e estado juntos
        public string BairroCidadeConcatenado
        {
            get { return $"{Bairro_nome} - {Cidade_nome} - {Estado_nome}"; }
        }

        // Mostrar no Grid
        public BairroCidade(int idBairro, string bairroNome, string cidadeNome, string estadoNome)
        {
            IdBairro = idBairro;
            Bairro_nome = bairroNome;
            Cidade_nome = cidadeNome;
            Estado_nome = estadoNome;
        }
    }
}