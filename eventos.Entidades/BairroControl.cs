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
    public class BairroControl
    {
        private BairroDAO bairroDAO = new BairroDAO();

        public DataTable GetAllBairros()
        {
            return bairroDAO.GetAll();
        }

        public DataTable GetBairroAsDataTable(string descricao)
        {
            return bairroDAO.GetBairroAsDataTable(descricao);
        }

        public Bairro GetBairroByBairro(string nome)
        {
            return bairroDAO.GetByBairro(nome);
        }

        public void AddBairro(Bairro bairro)
        {
            bairroDAO.Add(bairro);
        }

        public void UpdateBairro(Bairro bairro)
        {
            bairroDAO.Update(bairro);
        }

        public void DeleteBairro(Bairro bairro)
        {
            bairroDAO.Delete(bairro);
        }
    }
}
