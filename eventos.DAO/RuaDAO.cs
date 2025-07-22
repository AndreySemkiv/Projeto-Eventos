using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventos.Model;
using Org.BouncyCastle.Utilities.Collections;


namespace Eventos.DAO
{
    public class RuaDAO
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
                    "   rua.id_rua AS Id, \r\n" +
                    "   rua.rua_nome AS Rua, \r\n" +
                    "   rua.cep_rua AS CEP, \r\n" +
                    "   bairro.bairro_nome AS Bairro, \r\n" +
                    "   cidade.cidade_nome AS Cidade, \r\n" +
                    "   estado.estado_nome AS Estado \r\n" +
                    "FROM \r\n" +
                    "   rua \r\n" +
                    "INNER JOIN \r\n" +
                    "   bairro ON bairro.id_bairro = rua.id_bairro \r\n" +
                    "INNER JOIN \r\n" +
                    "   cidade ON cidade.id_cidade = bairro.id_cidade \r\n" +
                    "INNER JOIN \r\n" +
                    "   estado ON estado.id_estado = cidade.id_estado \r\n" +
                    "ORDER BY \r\n" +
                    "   rua.rua_nome \r\n";


                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        // Carregar dados no Grid
        public DataTable GetRuaAsDataTable(string descricao)
        {

            string query = "SELECT \r\n" +
                    "   rua.id_rua AS Id, \r\n" +
                    "   rua.rua_nome AS Rua, \r\n" +
                    "   rua.cep_rua AS CEP, \r\n" +
                    "   bairro.bairro_nome AS Bairro, \r\n" +
                    "   cidade.cidade_nome AS Cidade, \r\n" +
                    "   estado.estado_nome AS Estado \r\n" +
                    "FROM \r\n" +
                    "   rua \r\n" +
                    "INNER JOIN \r\n" +
                    "   bairro ON bairro.id_bairro = rua.id_bairro \r\n" +
                    "INNER JOIN \r\n" +
                    "   cidade ON cidade.id_cidade = bairro.id_cidade \r\n" +
                    "INNER JOIN \r\n" +
                    "   estado ON estado.id_estado = cidade.id_estado \r\n" +
                "WHERE \r\n" +
                "    rua.rua_nome LIKE CONCAT('%',@rua_nome,'%') \r\n" +
                "ORDER BY \r\n" +
                "    rua.rua_nome";


            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rua_nome", descricao);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Carregar dados da Pesquisa
        public Rua GetByRua(string Descricao)
        {
            Rua rua = null;

            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();


                string query = "SELECT \r\n" +
                    "   rua.id_rua AS Id, \r\n" +
                    "   rua.rua_nome AS Rua, \r\n" +
                    "   rua.cep_rua AS CEP, \r\n" +
                    "   bairro.bairro_nome AS Bairro, \r\n" +
                    "   cidade.cidade_nome AS Cidade, \r\n" +
                    "   estado.estado_nome AS Estado \r\n" +
                    "FROM \r\n" +
                    "   rua \r\n" +
                    "INNER JOIN \r\n" +
                    "   bairro ON bairro.id_bairro = rua.id_bairro \r\n" +
                    "INNER JOIN \r\n" +
                    "   cidade ON cidade.id_cidade = bairro.id_cidade \r\n" +
                    "INNER JOIN \r\n" +
                    "   estado ON estado.id_estado = cidade.id_estado \r\n" +
                "WHERE \r\n" +
                "    rua.rua_nome LIKE CONCAT('%',@rua_nome,'%') \r\n" +
                "ORDER BY \r\n" +
                "    rua.rua_nome";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rua_nome", Descricao);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rua = new Rua()
                        {
                            IdRua = reader.GetInt32("Id"),
                            Rua_nome = reader.GetString("Rua"),
                            Cep_rua = reader.GetString("CEP"),

                            // necessário adionar esse campo no Model para que o objeto traga o nome do bairro
                            Bairro_nome = reader.GetString("Bairro"),
                            Cidade_nome = reader.GetString("Cidade"),
                            Estado_nome = reader.GetString("Estado")
                        };
                    }
                }
            }
            return rua;
        }

        // Carregar dados da Pesquisa
        public Rua GetByCep(string Cep)
        {
            Rua rua = null;

            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();


                string query = "SELECT \r\n" +
                    "   rua.id_rua AS Id, \r\n" +
                    "   rua.rua_nome AS Rua, \r\n" +
                    "   rua.cep_rua AS CEP, \r\n" +
                    "   bairro.bairro_nome AS Bairro, \r\n" +
                    "   cidade.cidade_nome AS Cidade \r\n" +
                    "FROM \r\n" +
                    "   rua \r\n" +
                    "INNER JOIN \r\n" +
                    "   bairro ON bairro.id_bairro = rua.id_bairro \r\n" +
                    "INNER JOIN \r\n" +
                    "   cidade ON cidade.id_cidade = bairro.id_cidade \r\n" +
                "WHERE \r\n" +
                "    rua.cep_rua LIKE CONCAT('%',@cep_rua,'%') \r\n" +
                "ORDER BY \r\n" +
                "    rua.rua_nome";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cep_rua", Cep);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        rua = new Rua()
                        {
                            IdRua = reader.GetInt32("Id"),
                            Rua_nome = reader.GetString("Rua"),
                            Cep_rua = reader.GetString("CEP"),

                            // necessário adionar esse campo no Model para que o objeto traga o nome do bairro
                            Bairro_nome = reader.GetString("Bairro"),
                            Cidade_nome = reader.GetString("Cidade")
                        };
                    }
                }
            }
            return rua;
        }

        // Carrega Lista BairroCidade
        public List<BairroCidade> ObterBairrosECidadees(object messageBox)
        {
            List<BairroCidade> listaDeBairros = new List<BairroCidade>();

            // Conexão com o banco de dados (ajuste a string de conexão conforme necessário)
            string connectionString = "sua_string_de_conexao";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT bairro.id_bairro, bairro.bairro_nome, cidade.cidade_nome, estado.estado_nome
                                FROM bairro
                                JOIN cidade ON bairro.id_cidade = cidade.id_cidade
                                    JOIN estado ON cidade.id_estado = estado.id_estado";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int IdBairro = reader.GetInt32(0);
                            string Bairro_nome = reader.GetString(1);
                            string Cidade_nome = reader.GetString(2);
                            string Estado_nome = reader.GetString(3);

                            // Adiciona os dados à lista
                            listaDeBairros.Add(new BairroCidade(IdBairro, Bairro_nome, Cidade_nome, Estado_nome));
                        }
                    }
                }
            }

            return listaDeBairros;
        }

        // Adicionar novo dado
        public void Add(Rua rua)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();


                // Insere na tabela rua
                string query = "INSERT INTO \r\n" +
                    "   rua (rua.rua_nome, rua.cep_rua, rua.id_bairro) \r\n" +
                    "VALUES \r\n" +
                    "   (@rua_nome, @cep_rua, @id_bairro); \r\n" +
                    "UPDATE rua \r\n" +
                        "SET cep_rua = CONCAT(SUBSTRING(cep_rua, 1, 2), \r\n" +
                        " '.', SUBSTRING(cep_rua, 3, 3), '-', \r\n" +
                        " SUBSTRING(cep_rua, 6, 3)) \r\n" +
                        "WHERE LENGTH(cep_rua) = 8;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rua_nome", rua.Rua_nome);
                cmd.Parameters.AddWithValue("@cep_rua", rua.Cep_rua);
                cmd.Parameters.AddWithValue("@id_bairro", rua.IdBairro);
                cmd.ExecuteNonQuery();
            }
        }

        // Atualizar/editar dados
        public void Update(Rua rua)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();


                string query = "UPDATE \r\n" +
                    "   rua \r\n" +
                    "SET \r\n" +
                    "   rua.rua_nome = @rua_nome, \r\n" +
                    "   rua.cep_rua = @cep_rua, \r\n" +
                    "   rua.id_bairro = @id_bairro \r\n" +
                    "WHERE \r\n" +
                    "   rua.id_rua = @id_rua; \r\n" +
                    "UPDATE rua \r\n" +
                        "SET cep_rua = CONCAT(SUBSTRING(cep_rua, 1, 2), \r\n" +
                        " '.', SUBSTRING(cep_rua, 3, 3), '-', \r\n" +
                        " SUBSTRING(cep_rua, 6, 3)) \r\n" +
                        "WHERE LENGTH(cep_rua) = 8;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rua_nome", rua.Rua_nome);
                cmd.Parameters.AddWithValue("@cep_rua", rua.Cep_rua);
                cmd.Parameters.AddWithValue("@id_bairro", rua.IdBairro);
                cmd.Parameters.AddWithValue("@id_rua", rua.IdRua);

                cmd.ExecuteNonQuery();
            }
        }

        // Excluir Dados
        public void Delete(Rua rua)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();


                string query = "DELETE \r\n" +
                    "FROM \r\n" +
                    "   rua \r\n" +
                    "WHERE \r\n" +
                    "   id_rua = @id";


                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", rua.IdRua);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
