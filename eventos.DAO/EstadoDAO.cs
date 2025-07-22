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
    public class EstadoDAO
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
                    "   estado.id_estado AS Id,\r\n" +
                    "   estado.estado_nome AS Estado,\r\n" +
                    "   pais.pais_nome AS País\r\n" +
                    "FROM\r\n" +
                    "   estado\r\n" +
                    "INNER JOIN\r\n" +
                    "   pais ON estado.id_pais = pais.id_pais\r\n" +
                    "ORDER BY\r\n" +
                    "   estado.estado_nome";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        // Carregar dados no Grid
        public DataTable GetEstadoAsDataTable(string descricao)
        {
            
            string query = "SELECT \r\n" +
                "   estado.id_estado AS Id, \r\n" +
                "   estado.estado_nome AS Estado, \r\n" +
                "   pais.pais_nome AS País \r\n" +
                "FROM \r\n" +
                "   estado \r\n" +
                "INNER JOIN \r\n" +
                "   pais ON estado.id_pais = pais.id_pais \r\n" +
                "WHERE \r\n" +
                "   estado_nome \r\n" +
                "LIKE CONCAT('%',@estado_nome,'%')";

            
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@estado_nome", descricao);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Carregar dados da Pesquisa
        public Estado GetByEstado(string Descricao)
        {
            Estado estado = null;

            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "SELECT \r\n" +
                    "   estado.id_estado AS Id, \r\n" +
                    "   estado.estado_nome AS Estado, \r\n" +
                    "   pais.pais_nome AS País \r\n" +
                    "FROM \r\n" +
                    "   estado \r\n" +
                    "INNER JOIN \r\n" +
                    "   pais ON estado.id_pais = pais.id_pais \r\n" +
                    "WHERE \r\n" +
                    "   estado_nome \r\n" +
                    "LIKE CONCAT('%',@estado_nome,'%')";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@estado_nome", Descricao);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        estado = new Estado()
                        {
                            IdEstado = reader.GetInt32("Id"),
                            Estado_nome = reader.GetString("Estado"),
                            // necessário adicionar esse campo no Model para que o objeto traga o nome do país
                            Pais_nome = reader.GetString("País")
                        };
                    }
                }
            }

            return estado;
        }

        // Adicionar novo dado
        public void Add(Estado estado)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                // Insere na tabela estado
                string query = "INSERT INTO \r\n" +
                    "estado \r\n" +
                        "(estado_nome, id_pais) \r\n" +
                    "VALUES \r\n" +
                        "(@estado_nome, @id_pais)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@estado_nome", estado.Estado_nome);
                cmd.Parameters.AddWithValue("@id_pais", estado.IdPais);
                cmd.ExecuteNonQuery();
            }
        }

        // Atualizar/editar dados
        public void Update(Estado estado)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "UPDATE \r\n" +
                    "   estado \r\n" +
                    "SET \r\n" +
                    "   estado.estado_nome = @estado_nome, \r\n" +
                    "   estado.id_pais = @id_pais \r\n" +
                    "WHERE \r\n" +
                    "   estado.id_estado = @id_estado";
                               
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@estado_nome", estado.Estado_nome);
                cmd.Parameters.AddWithValue("@id_pais", estado.IdPais);
                cmd.Parameters.AddWithValue("@id_estado", estado.IdEstado);
                cmd.ExecuteNonQuery();
            }
        }

        // Excluir Dados
        public void Delete(Estado estado)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "DELETE \r\n" +
                    "FROM \r\n" +
                    "   estado \r\n" +
                    "WHERE \r\n" +
                    "   estado.id_estado = @id";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", estado.IdEstado);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
