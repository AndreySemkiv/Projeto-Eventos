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
    public class EstadoControl
    {
        private EstadoDAO estadoDAO = new EstadoDAO();

        public DataTable GetAllEstados()
        {
            return estadoDAO.GetAll();
        }

        public DataTable GetEstadoAsDataTable(string descricao)
        {
            return estadoDAO.GetEstadoAsDataTable(descricao);
        }

        public Estado GetEstadoByEstado(string nome)
        {
            return estadoDAO.GetByEstado(nome);
        }

        public void AddEstado(Estado estado)
        {
            estadoDAO.Add(estado);
        }

        public void UpdateEstado(Estado estado)
        {
            estadoDAO.Update(estado);
        }

        public void DeleteEstado(Estado estado)
        {
            estadoDAO.Delete(estado);
        }
    }
}
