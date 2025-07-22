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
    public class CidadeDAO
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
                    "   cidade.id_cidade AS Id, \r\n" +
                    "   cidade.cidade_nome AS Cidade, \r\n" +
                    "   estado.estado_nome AS Estado, \r\n" +
                    "   pais.pais_nome AS País \r\n" +
                    "FROM \r\n" +
                    "   cidade \r\n" +
                    "INNER JOIN \r\n" +
                    "   estado ON estado.id_estado = cidade.id_estado \r\n" +
                    "INNER JOIN \r\n" +
                    "   pais ON pais.id_pais = estado.id_pais \r\n" +
                    "ORDER BY \r\n" +
                    "   cidade.cidade_nome \r\n";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        // Carregar dados no Grid
        public DataTable GetCidadeAsDataTable(string descricao)
        {
            
            string query = "SELECT \r\n" +
                "   cidade.id_cidade AS Id, \r\n" +
                "   cidade.cidade_nome AS Cidade, \r\n" +
                "   estado.estado_nome AS Estado, \r\n" +
                "   pais.pais_nome AS País \r\n" +
                "FROM \r\n" +
                "    cidade \r\n" +
                "INNER JOIN \r\n" +
                    "   estado ON estado.id_estado = cidade.id_estado \r\n" +
                "INNER JOIN \r\n" +
                    "   pais ON pais.id_pais = estado.id_pais \r\n" +
                "WHERE \r\n" +
                "    cidade.cidade_nome LIKE CONCAT('%',@cidade_nome,'%') \r\n" +
                "ORDER BY \r\n" +
                "    cidade.cidade_nome";


            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cidade_nome", descricao);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Carregar dados da Pesquisa
        public Cidade GetByCidade(string Descricao)
        {
            Cidade cidade = null;

            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "SELECT \r\n" +
                    "    cidade.id_cidade AS Id, \r\n" +
                    "    cidade.cidade_nome AS Cidade, \r\n" +
                    "    estado.estado_nome AS Estado, \r\n" +
                    "   pais.pais_nome AS País \r\n" +
                    "FROM \r\n" +
                    "    cidade \r\n" +
                    "INNER JOIN \r\n" +
                    "   estado ON estado.id_estado = cidade.id_estado \r\n" +
                    "INNER JOIN \r\n" +
                    "   pais ON pais.id_pais = estado.id_pais \r\n" +
                    "WHERE \r\n" +
                    "    cidade.cidade_nome LIKE CONCAT('%', @cidade_nome, '%') \r\n" +
                    "ORDER BY \r\n" +
                    "    cidade.cidade_nome;";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cidade_nome", Descricao);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cidade = new Cidade()
                        {
                            IdCidade = reader.GetInt32("Id"),
                            Cidade_nome = reader.GetString("Cidade"),
                            
                            // necessário adionar esse campo no Model para que o objeto traga o nome do estado
                            Estado_nome = reader.GetString("Estado"),
                            Pais_nome = reader.GetString("País")
                        };
                    }
                }
            }

            return cidade;
        }

        // Carrega Lista EstadoPais
        public List<EstadoPais> ObterEstadosEPaises(object messageBox)
        {
            List<EstadoPais> listaDeEstados = new List<EstadoPais>();

            // Conexão com o banco de dados (ajuste a string de conexão conforme necessário)
            string connectionString = "sua_string_de_conexao";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT estado.id_estado, estado.estado_nome, pais.pais_nome
                                FROM estado
                                JOIN pais ON estado.id_pais = pais.id_pais";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int IdEstado = reader.GetInt32(0);
                            string Estado_nome = reader.GetString(1);
                            string Pais_nome = reader.GetString(2);

                            // Adiciona os dados à lista
                            listaDeEstados.Add(new EstadoPais(IdEstado, Estado_nome, Pais_nome));
                        }
                    }
                }
            }
            
            return listaDeEstados;
        }

        // Adicionar novo dado
        public void Add(Cidade cidade)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();


                // Insere na tabela cidade
                string query = "INSERT INTO \r\n" +
                    "   cidade (cidade.cidade_nome, cidade.id_estado) \r\n" +
                    "VALUES \r\n" +
                    "   (@cidade_nome, @id_estado);";
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cidade_nome", cidade.Cidade_nome);
                cmd.Parameters.AddWithValue("@id_estado", cidade.IdEstado);
                cmd.ExecuteNonQuery();
            }
        }

        // Atualizar/editar dados
        public void Update(Cidade cidade)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                

                string query = "UPDATE \r\n" +
                    "   cidade \r\n" +
                    "SET \r\n" +
                    "   cidade.cidade_nome = @cidade_nome, \r\n" +
                    "   cidade.id_estado = @id_estado \r\n" +
                    "WHERE \r\n" +
                    "   cidade.id_cidade = @id_cidade";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cidade_nome", cidade.Cidade_nome);
                cmd.Parameters.AddWithValue("@id_estado", cidade.IdEstado);
                cmd.Parameters.AddWithValue("@id_cidade", cidade.IdCidade);
                
                cmd.ExecuteNonQuery();
            }
        }

        // Excluir Dados
        public void Delete(Cidade cidade)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();


                string query = "DELETE \r\n" +
                    "FROM \r\n" +
                    "   cidade \r\n" +
                    "WHERE \r\n" +
                    "   id_cidade = @id";
                

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", cidade.IdCidade);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
