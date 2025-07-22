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
    public class CorControl
    {
        private CorDAO corDAO = new CorDAO();

        public DataTable GetAllCors()
        {
            return corDAO.GetAll();
        }

        public DataTable GetCorAsDataTable(string cod_cor)
        {
            return corDAO.GetCorAsDataTable(cod_cor);
        }

        public Cor GetCorByCor(string nome)
        {
            return corDAO.GetByCor(nome);
        }

        public void AddCor(Cor cor)
        {
            corDAO.Add(cor);
        }

        public void UpdateCor(Cor cor)
        {
            corDAO.Update(cor);
        }

        public void DeleteCor(Cor cor)
        {
            corDAO.Delete(cor);
        }
    }
}
