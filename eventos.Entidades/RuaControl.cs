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
    public class RuaControl
    {
        private RuaDAO ruaDAO = new RuaDAO();

        public DataTable GetAllRuas()
        {
            return ruaDAO.GetAll();
        }

        public DataTable GetRuaAsDataTable(string descricao)
        {
            return ruaDAO.GetRuaAsDataTable(descricao);
        }

        public Rua GetRuaByRua(string nome)
        {
            return ruaDAO.GetByRua(nome);
        }

        public void AddRua(Rua rua)
        {
            ruaDAO.Add(rua);
        }

        public void UpdateRua(Rua rua)
        {
            ruaDAO.Update(rua);
        }

        public void DeleteRua(Rua rua)
        {
            ruaDAO.Delete(rua);
        }
    }
}
