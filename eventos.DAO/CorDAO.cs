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
    public class CorDAO
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
                    "   cor.id_cor AS Id,\r\n" +
                    "   cor.cor_nome AS Cor,\r\n" +
                    "   cor.cod_rgb_hexa_cmyk AS Cod_Cor\r\n" +
                    "FROM\r\n" +
                    "   cor\r\n" +
                    "ORDER BY\r\n" +
                    "   cor.cor_nome";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        // Carregar dados no Grid
        public DataTable GetCorAsDataTable(string cod_cor)
        {
            
            string query = "SELECT \r\n" +
                "   cor.id_cor AS Id, \r\n" +
                "   cor.cor_nome AS Cor, \r\n" +
                "   cor.cod_rgb_hexa_cmyk AS Cod_Cor\r\n" +
                "FROM \r\n" +
                "   cor \r\n" +
                "WHERE \r\n" +
                "   cor.cod_rgb_hexa_cmyk \r\n" +
                "LIKE CONCAT('%',@cor.cod_rgb_hexa_cmyk,'%')";

            
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cor.cod_rgb_hexa_cmyk", cod_cor);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Carregar dados da Pesquisa
        public Cor GetByCor(string Cod_cor)
        {
            Cor cor = null;

            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "SELECT \r\n" +
                    "   cor.id_cor AS Id, \r\n" +
                    "   cor.cor_nome AS Cor, \r\n" +
                    "   cor.cod_rgb_hexa_cmyk AS Cod_Cor\r\n" +
                    "FROM \r\n" +
                    "   cor \r\n" +
                    "WHERE \r\n" +
                    "   cod_rgb_hexa_cmyk \r\n" +
                    "LIKE CONCAT('%',@cod_rgb_hexa_cmyk,'%')";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cod_rgb_hexa_cmyk", Cod_cor);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cor = new Cor()
                        {
                            IdCor = reader.GetInt32("Id"),
                            CorNome = reader.GetString("Cor"),
                            CodCor = reader.GetString("Cod_Cor")
                        };
                    }
                }
            }

            return cor;
        }

        // Adicionar novo dado
        public void Add(Cor cor)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                // Insere na tabela cor
                string query = "INSERT INTO \r\n" +
                    "cor \r\n" +
                        "(cor_nome, cod_rgb_hexa_cmyk) \r\n" +
                    "VALUES \r\n" +
                        "(@cor_nome, @cod_rgb_hexa_cmyk)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cor_nome", cor.CorNome);
                cmd.Parameters.AddWithValue("@cod_rgb_hexa_cmyk", cor.CodCor);
                cmd.ExecuteNonQuery();
            }
        }

        // Atualizar/editar dados
        public void Update(Cor cor)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "UPDATE \r\n" +
                    "   cor \r\n" +
                    "SET \r\n" +
                    "   cor.cor_nome = @cor_nome, \r\n" +
                    "   cor.cod_rgb_hexa_cmyk = @cod_rgb_hexa_cmyk \r\n" +
                    "WHERE \r\n" +
                    "   cor.id_cor = @id_cor";
                               
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cor_nome", cor.CorNome);
                cmd.Parameters.AddWithValue("@cod_rgb_hexa_cmyk", cor.CodCor);
                cmd.Parameters.AddWithValue("@id_cor", cor.IdCor);
                cmd.ExecuteNonQuery();
            }
        }

        // Excluir Dados
        public void Delete(Cor cor)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "DELETE \r\n" +
                    "FROM \r\n" +
                    "   cor \r\n" +
                    "WHERE \r\n" +
                    "   cor.id_cor = @id";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", cor.IdCor);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
