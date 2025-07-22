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
    public class BairroDAO
    {
        private DbContext dbContext = new DbContext();

        public object MessageBox { get; private set; }

        //Carregar todos os dados
        public DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();


                string query = "SELECT \r\n" +
                    "   bairro.id_bairro AS Id, \r\n" +
                    "   bairro.bairro_nome AS Bairro, \r\n" +
                    "   cidade.cidade_nome AS Cidade, \r\n" +
                    "   estado.estado_nome AS Estado \r\n" +
                    "FROM \r\n" +
                    "   bairro \r\n" +
                    "INNER JOIN \r\n" +
                    "   cidade ON cidade.id_cidade = bairro.id_cidade \r\n" +
                    "INNER JOIN \r\n" +
                    "   estado ON estado.id_estado = cidade.id_estado \r\n" +
                    "ORDER BY \r\n" +
                    "   bairro.bairro_nome \r\n";


                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        // Carregar dados no Grid
        public DataTable GetBairroAsDataTable(string descricao)
        {

            string query = "SELECT \r\n" +
                "   bairro.id_bairro AS Id, \r\n" +
                "   bairro.bairro_nome AS Bairro, \r\n" +
                "   cidade.cidade_nome AS Cidade, \r\n" +
                "   estado.estado_nome AS Estado \r\n" +
                "FROM \r\n" +
                "    bairro \r\n" +
                "INNER JOIN \r\n" +
                    "   cidade ON cidade.id_cidade = bairro.id_cidade \r\n" +
                "INNER JOIN \r\n" +
                    "   estado ON estado.id_estado = cidade.id_estado \r\n" +
                "WHERE \r\n" +
                "    bairro.bairro_nome LIKE CONCAT('%',@bairro_nome,'%') \r\n" +
                "ORDER BY \r\n" +
                "    bairro.bairro_nome";


            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@bairro_nome", descricao);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Carregar dados da Pesquisa
        public Bairro GetByBairro(string Descricao)
        {
            Bairro bairro = null;

            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();


                string query = "SELECT \r\n" +
                    "    bairro.id_bairro AS Id, \r\n" +
                    "    bairro.bairro_nome AS Bairro, \r\n" +
                    "    cidade.cidade_nome AS Cidade, \r\n" +
                    "   estado.estado_nome AS Estado \r\n" +
                    "FROM \r\n" +
                    "    bairro \r\n" +
                    "INNER JOIN \r\n" +
                    "   cidade ON cidade.id_cidade = bairro.id_cidade \r\n" +
                    "INNER JOIN \r\n" +
                    "   estado ON estado.id_estado = cidade.id_estado \r\n" +
                    "WHERE \r\n" +
                    "    bairro.bairro_nome LIKE CONCAT('%', @bairro_nome, '%') \r\n" +
                    "ORDER BY \r\n" +
                    "    bairro.bairro_nome;";


                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@bairro_nome", Descricao);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        bairro = new Bairro()
                        {
                            IdBairro = reader.GetInt32("Id"),
                            Bairro_nome = reader.GetString("Bairro"),

                            // necessário adionar esse campo no Model para que o objeto traga o nome do cidade
                            Cidade_nome = reader.GetString("Cidade"),
                            Estado_nome = reader.GetString("Estado")
                        };
                    }
                }
            }

            return bairro;
        }

        // Carrega Lista CidadeEstado
        public List<CidadeEstado> ObterCidadesEEstadoes(object messageBox)
        {
            List<CidadeEstado> listaDeCidades = new List<CidadeEstado>();

            // Conexão com o banco de dados (ajuste a string de conexão conforme necessário)
            string connectionString = "sua_string_de_conexao";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT cidade.id_cidade, cidade.cidade_nome, estado.estado_nome
                                FROM cidade
                                JOIN estado ON cidade.id_estado = estado.id_estado";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int IdCidade = reader.GetInt32(0);
                            string Cidade_nome = reader.GetString(1);
                            string Estado_nome = reader.GetString(2);

                            // Adiciona os dados à lista
                            listaDeCidades.Add(new CidadeEstado(IdCidade, Cidade_nome, Estado_nome));
                        }
                    }
                }
            }

            return listaDeCidades;
        }

        // Adicionar novo dado
        public void Add(Bairro bairro)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();


                // Insere na tabela bairro
                string query = "INSERT INTO \r\n" +
                    "   bairro (bairro.bairro_nome, bairro.id_cidade) \r\n" +
                    "VALUES \r\n" +
                    "   (@bairro_nome, @id_cidade);";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@bairro_nome", bairro.Bairro_nome);
                cmd.Parameters.AddWithValue("@id_cidade", bairro.IdCidade);
                cmd.ExecuteNonQuery();
            }
        }

        // Atualizar/editar dados
        public void Update(Bairro bairro)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();


                string query = "UPDATE \r\n" +
                    "   bairro \r\n" +
                    "SET \r\n" +
                    "   bairro.bairro_nome = @bairro_nome, \r\n" +
                    "   bairro.id_cidade = @id_cidade \r\n" +
                    "WHERE \r\n" +
                    "   bairro.id_bairro = @id_bairro";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@bairro_nome", bairro.Bairro_nome);
                cmd.Parameters.AddWithValue("@id_cidade", bairro.IdCidade);
                cmd.Parameters.AddWithValue("@id_bairro", bairro.IdBairro);

                cmd.ExecuteNonQuery();
            }
        }

        // Excluir Dados
        public void Delete(Bairro bairro)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();


                string query = "DELETE \r\n" +
                    "FROM \r\n" +
                    "   bairro \r\n" +
                    "WHERE \r\n" +
                    "   id_bairro = @id";


                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", bairro.IdBairro);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
