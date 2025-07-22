using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Eventos.Model
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public string Tamanho { get; set; }
        public double Quantidade { get; set; }
        public double Valor { get; set; }
        public double Custo { get; set; }
        public int IdCor { get; set; }
        public string CorNome { get; set; }
        public string Cod_rgb_hexa_cmyk { get; set; }
        public int IdTema { get; set; }
        public string TemaNome { get; set; }
        public int IdCategoria { get; set; }
        public string CategoriaNome { get; set; }
    }
}