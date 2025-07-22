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
    public class CategoriaControl
    {
        private CategoriaDAO categoriaDAO = new CategoriaDAO();

        public DataTable GetAllCategorias()
        {
            return categoriaDAO.GetAll();
        }

        public DataTable GetCategoriaAsDataTable(string descricao)
        {
            return categoriaDAO.GetCategoriaAsDataTable(descricao);
        }

        public Categoria GetCategoriaByCategoria(string nome)
        {
            return categoriaDAO.GetByCategoria(nome);
        }

        public void AddCategoria(Categoria categoria)
        {
            categoriaDAO.Add(categoria);
        }

        public void UpdateCategoria(Categoria categoria)
        {
            categoriaDAO.Update(categoria);
        }

        public void DeleteCategoria(Categoria categoria)
        {
            categoriaDAO.Delete(categoria);
        }
    }
}