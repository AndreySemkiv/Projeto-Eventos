using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Eventos.Model
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Cep { get; set; }
        public int NumResidencia { get; set; }
        public int IdRua { get; set; }
        public string RuaNome { get; set; }
        public int IdBairro { get; set; }
        public string BairroNome { get; set; }
        public int IdCidade { get; set; }
        public string CidadeNome { get; set; }
    }
}