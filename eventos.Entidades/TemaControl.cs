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
    public class TemaControl
    {
        private TemaDAO temaDAO = new TemaDAO();

        public DataTable GetAllTemas()
        {
            return temaDAO.GetAll();
        }

        public DataTable GetTemaAsDataTable(string descricao)
        {
            return temaDAO.GetTemaAsDataTable(descricao);
        }

        public Tema GetTemaByTema(string nome)
        {
            return temaDAO.GetByTema(nome);
        }

        public void AddTema(Tema tema)
        {
            temaDAO.Add(tema);
        }

        public void UpdateTema(Tema tema)
        {
            temaDAO.Update(tema);
        }

        public void DeleteTema(Tema tema)
        {
            temaDAO.Delete(tema);
        }
    }
}
