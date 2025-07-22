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
    public class TemaDAO
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
                    "   tema.id_tema AS Id, \r\n" +
                    "   tema.tema_nome AS Tema\r\n" +
                    "FROM\r\n" +
                    "   tema";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        // Carregar dados no Grid
        public DataTable GetTemaAsDataTable(string descricao)
        {
            
            string query = "SELECT \r\n" +
                "   tema.id_tema AS Id, \r\n" +
                "   tema.tema_nome AS Tema \r\n" +
                "FROM \r\n" +
                "   tema \r\n" +
                "WHERE \r\n" +
                "   tema_nome \r\n" +
                "LIKE CONCAT('%',@tema_nome,'%')";

            
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tema_nome", descricao);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Carregar dados da Pesquisa
        public Tema GetByTema(string Descricao)
        {
            Tema tema = null;

            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "SELECT \r\n" +
                    "   tema.id_tema AS Id, \r\n" +
                    "   tema.tema_nome AS Tema \r\n" +
                    "FROM \r\n" +
                    "   tema \r\n" +
                    "WHERE \r\n" +
                    "   tema.tema_nome \r\n" +
                    "LIKE CONCAT('%',@tema_nome,'%')";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tema_nome", Descricao);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tema = new Tema()
                        {
                            IdTema = reader.GetInt32("Id"),
                            Tema_nome = reader.GetString("Tema")
                        };
                    }
                }
            }

            return tema;
        }

        // Adicionar novo dado
        public void Add(Tema tema)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "INSERT INTO \r\n" +
                    "   tema (tema_nome) \r\n" +
                    "VALUES \r\n" +
                    "   (@tema_nome)";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tema_nome", tema.Tema_nome);
                cmd.ExecuteNonQuery();
            }
        }

        // Atualizar/editar dados
        public void Update(Tema tema)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "UPDATE \r\n" +
                    "   tema \r\n" +
                    "SET \r\n" +
                    "   tema.tema_nome = @tema_nome \r\n" +
                    "WHERE \r\n" +
                    "   tema.id_tema = @id";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tema_nome", tema.Tema_nome);
                cmd.Parameters.AddWithValue("@id", tema.IdTema);
                cmd.ExecuteNonQuery();
            }
        }

        // Excluir Dados
        public void Delete(Tema tema)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                string query = "DELETE \r\n" +
                    "FROM \r\n" +
                    "   tema \r\n" +
                    "WHERE \r\n" +
                    "   tema.id_tema = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", tema.IdTema);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
