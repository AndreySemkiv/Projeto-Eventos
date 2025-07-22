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
    public class ClienteControl
    {
        private ClienteDAO clienteDAO = new ClienteDAO();

        public DataTable GetAllClientes()
        {
            return clienteDAO.GetAll();
        }

        public DataTable GetClienteAsDataTable(string descricao)
        {
            return clienteDAO.GetClienteAsDataTable(descricao);
        }

        public Cliente GetClienteByCliente(string nome)
        {
            return clienteDAO.GetByCliente(nome);
        }

        public void AddCliente(Cliente cliente)
        {
            clienteDAO.Add(cliente);
        }

        public void UpdateCliente(Cliente cliente)
        {
            clienteDAO.Update(cliente);
        }

        public void DeleteCliente(Cliente cliente)
        {
            clienteDAO.Delete(cliente);
        }
    }
}
