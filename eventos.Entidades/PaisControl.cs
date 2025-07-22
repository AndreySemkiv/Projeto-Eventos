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
    public class PaisControl
    {
        private PaisDAO paisDAO = new PaisDAO();

        public DataTable GetAllPaiss()
        {
            return paisDAO.GetAll();
        }

        public DataTable GetPaisAsDataTable(string descricao)
        {
            return paisDAO.GetPaisAsDataTable(descricao);
        }

        public Pais GetPaisByPais(string nome)
        {
            return paisDAO.GetByPais(nome);
        }

        public void AddPais(Pais pais)
        {
            paisDAO.Add(pais);
        }

        public void UpdatePais(Pais pais)
        {
            paisDAO.Update(pais);
        }

        public void DeletePais(Pais pais)
        {
            paisDAO.Delete(pais);
        }
    }
}
