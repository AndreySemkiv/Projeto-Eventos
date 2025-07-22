using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventos.Model;


namespace Eventos.DAO
{
    public class PaisDAO
    {
        private DbContext dbContext = new DbContext();

        //Carregar todos os dados
        public DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "SELECT \r\n" +
                    "   pais.id_pais AS Id,\r\n" +
                    "   pais.pais_nome AS País\r\n" +
                    "FROM\r\n" +
                    "   pais";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        // Carregar dados no Grid
        public DataTable GetPaisAsDataTable(string descricao)
        {
            
            string query = "SELECT \r\n" +
                "   pais.id_pais, \r\n" +
                "   pais.pais_nome \r\n" +
                "FROM \r\n" +
                "   pais \r\n" +
                "WHERE \r\n" +
                "   pais.pais_nome \r\n" +
                "LIKE CONCAT('%',@pais_nome,'%')";


            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pais_nome", descricao);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Carregar dados da Pesquisa
        public Pais GetByPais(string Descricao)
        {
            Pais pais = null;

            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "SELECT \r\n" +
                    "   pais.id_pais AS Id, \r\n" +
                    "   pais.pais_nome AS País \r\n" +
                    "FROM \r\n" +
                    "   pais \r\n" +
                    "WHERE \r\n" +
                    "   pais.pais_nome \r\n" +
                    "LIKE CONCAT('%',@pais_nome,'%')";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pais_nome", Descricao);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        pais = new Pais()
                        {
                            IdPais = reader.GetInt32("Id"),
                            Pais_nome = reader.GetString("País")
                        };
                    }
                }
            }

            return pais;
        }

        // Adicionar novo dado
        public void Add(Pais pais)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "INSERT INTO \r\n" +
                    "   pais (pais_nome) \r\n" +
                    "VALUES \r\n" +
                    "   (@pais_nome)";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pais_nome", pais.Pais_nome);
                cmd.ExecuteNonQuery();
            }
        }

        // Atualizar/editar dados
        public void Update(Pais pais)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "UPDATE \r\n" +
                    "   pais \r\n" +
                    "SET \r\n" +
                    "   pais.pais_nome = @pais_nome \r\n" +
                    "WHERE \r\n" +
                    "   pais.id_pais = @id";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pais_nome", pais.Pais_nome);
                cmd.Parameters.AddWithValue("@id", pais.IdPais);
                cmd.ExecuteNonQuery();
            }
        }

        // Excluir Dados
        public void Delete(Pais pais)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "DELETE \r\n" +
                    "FROM \r\n" +
                    "   pais \r\n" +
                    "WHERE \r\n" +
                    "   pais.id_pais = @id";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", pais.IdPais);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
