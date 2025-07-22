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
    public class CategoriaDAO
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
                    "   categoria.id_categoria AS Id,\r\n" +
                    "   categoria.categoria_nome AS Categoria\r\n" +
                    "FROM\r\n" +
                    "   categoria";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        // Carregar dados no Grid
        public DataTable GetCategoriaAsDataTable(string descricao)
        {
            
            string query = "SELECT \r\n" +
                "   categoria.id_categoria AS Id, \r\n" +
                "   categoria.categoria_nome AS Categoria \r\n" +
                "FROM \r\n" +
                "   categoria \r\n" +
                "WHERE \r\n" +
                "   categoria.categoria_nome \r\n" +
                "LIKE CONCAT('%',?,'%')";


            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@categoria_nome", descricao);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Carregar dados da Pesquisa
        public Categoria GetByCategoria(string Descricao)
        {
            Categoria categoria = null;

            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                string query = "SELECT categoria.id_categoria AS Id, categoria.categoria_nome AS Categoria FROM categoria WHERE categoria.categoria_nome LIKE CONCAT('%',?,'%')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@categoria_nome", Descricao);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        categoria = new Categoria()
                        {
                            IdCategoria = reader.GetInt32("Id"),
                            Categoria_nome = reader.GetString("Categoria")
                        };
                    }
                }
            }

            return categoria;
        }

        // Adicionar novo dado
        public void Add(Categoria categoria)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "INSERT INTO \r\n" +
                    "   categoria (categoria_nome) \r\n" +
                    "VALUES \r\n" +
                    "   (@categoria_nome)";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@categoria_nome", categoria.Categoria_nome);
                cmd.ExecuteNonQuery();
            }
        }

        // Atualizar/editar dados
        public void Update(Categoria categoria)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "UPDATE \r\n" +
                    "   categoria \r\n" +
                    "SET \r\n" +
                    "   categoria.categoria_nome = @categoria_nome \r\n" +
                    "WHERE \r\n" +
                    "   categoria.id_categoria = @id";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@categoria_nome", categoria.Categoria_nome);
                cmd.Parameters.AddWithValue("@id", categoria.IdCategoria);
                cmd.ExecuteNonQuery();
            }
        }

        // Excluir Dados
        public void Delete(Categoria categoria)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "DELETE \r\n" +
                    "FROM \r\n" +
                    "   categoria \r\n" +
                    "WHERE \r\n" +
                    "   categoria.id_categoria = @id";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", categoria.IdCategoria);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
