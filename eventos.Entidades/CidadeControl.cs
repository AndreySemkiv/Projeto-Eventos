using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventos.DAO;
using Eventos.Model;


namespace Eventos.Control
{
    public class CidadeControl
    {
        private CidadeDAO cidadeDAO = new CidadeDAO();

        public DataTable GetAllCidades()
        {
            return cidadeDAO.GetAll();
        }

        public DataTable GetCidadeAsDataTable(string descricao)
        {
            return cidadeDAO.GetCidadeAsDataTable(descricao);
        }

        public Cidade GetCidadeByCidade(string nome)
        {
            return cidadeDAO.GetByCidade(nome);
        }

        public void AddCidade(Cidade cidade)
        {
            cidadeDAO.Add(cidade);
        }

        public void UpdateCidade(Cidade cidade)
        {
            cidadeDAO.Update(cidade);
        }

        public void DeleteCidade(Cidade cidade)
        {
            cidadeDAO.Delete(cidade);
        }
    }
}
