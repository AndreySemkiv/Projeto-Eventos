using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventos.Model;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;


namespace Eventos.DAO
{
    public class ClienteDAO
    {
        private DbContext dbContext = new DbContext();

        //Carregar todos os dados
        public DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                string query = "SELECT cliente.id_cliente AS Id, \r\n" +
                    "   cliente.nome AS Nome, \r\n" +
                    "   cliente.cpf AS CPF, \r\n" +
                    "   cliente.email AS E_mail, \r\n" +
                    "   cliente.celular AS Celular, \r\n" +
                    "   cliente.cep AS CEP, \r\n" +
                    "   cliente.num_residencia AS Nº, \r\n" +
                    "   rua.rua_nome AS Endereço, \r\n" +
                    "   bairro.bairro_nome AS Bairro, \r\n" +
                    "   cidade.cidade_nome AS Cidade, \r\n" +
                    "   rua.id_rua AS Id_Rua \r\n" +
                    "FROM \r\n" +
                    "   cliente \r\n" +
                    "INNER JOIN \r\n" +
                    "   rua ON cliente.cep = rua.cep_rua \r\n" +
                    "INNER JOIN \r\n" +
                    "   bairro ON rua.id_bairro = bairro.id_bairro \r\n" +
                    "INNER JOIN \r\n" +
                    "   cidade ON bairro.id_cidade = cidade.id_cidade \r\n" +
                    "ORDER BY \r\n" +
                    "   cliente.nome";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        // Carregar dados no Grid
        public DataTable GetClienteAsDataTable(string descricao)
        {

            string query = "SELECT cliente.id_cliente AS Id, \r\n" +
                    "   cliente.nome AS Nome, \r\n" +
                    "   cliente.cpf AS CPF, \r\n" +
                    "   cliente.email AS E_mail, \r\n" +
                    "   cliente.celular AS Celular, \r\n" +
                    "   cliente.cep AS CEP, \r\n" +
                    "   cliente.num_residencia AS Nº, \r\n" +
                    "   rua.rua_nome AS Endereço, \r\n" +
                    "   bairro.bairro_nome AS Bairro, \r\n" +
                    "   cidade.cidade_nome AS Cidade, \r\n" +
                    "   rua.id_rua AS Id_Rua \r\n" +
                    "FROM \r\n" +
                    "   cliente \r\n" +
                    "INNER JOIN \r\n" +
                    "   rua ON cliente.cep = rua.cep_rua \r\n" +
                    "INNER JOIN \r\n" +
                    "   bairro ON rua.id_bairro = bairro.id_bairro \r\n" +
                    "INNER JOIN \r\n" +
                    "   cidade ON bairro.id_cidade = cidade.id_cidade \r\n" +
                    "WHERE \r\n" +
                    "   nome \r\n" +
                    "LIKE CONCAT('%',@nome,'%') \r\n" +
                    "ORDER BY \r\n" +
                    "   cliente.nome \r\n";


            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", descricao);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Carregar dados da Pesquisa pelo nome do cliente
        public Cliente GetByCliente(string Descricao)
        {
            Cliente cliente = null;

            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();


                string query = "SELECT cliente.id_cliente AS Id, \r\n" +
                    "   cliente.nome AS Nome, \r\n" +
                    "   cliente.cpf AS CPF, \r\n" +
                    "   cliente.email AS E_mail, \r\n" +
                    "   cliente.celular AS Celular, \r\n" +
                    "   cliente.cep AS CEP, \r\n" +
                    "   cliente.num_residencia AS Nº, \r\n" +
                    "   rua.rua_nome AS Endereço, \r\n" +
                    "   bairro.bairro_nome AS Bairro, \r\n" +
                    "   cidade.cidade_nome AS Cidade \r\n" +
                    "FROM \r\n" +
                    "   cliente \r\n" +
                    "INNER JOIN \r\n" +
                    "   rua ON cliente.cep = rua.cep_rua \r\n" +
                    "INNER JOIN \r\n" +
                    "   bairro ON rua.id_bairro = bairro.id_bairro \r\n" +
                    "INNER JOIN \r\n" +
                    "   cidade ON bairro.id_cidade = cidade.id_cidade \r\n" +
                    "WHERE \r\n" +
                    "   nome \r\n" +
                    "LIKE CONCAT('%',@nome,'%') \r\n" +
                    "ORDER BY \r\n" +
                    "   cliente.nome \r\n";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", Descricao);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cliente = new Cliente()
                        {
                            IdCliente = reader.GetInt32("Id"),
                            Nome = reader.GetString("Nome"),
                            Cpf = reader.GetString("CPF"),
                            Email = reader.GetString("E_mail"),
                            Celular = reader.GetString("Celular"),
                            Cep = reader.GetString("CEP"),
                            NumResidencia = reader.GetInt32("Nº"),
                            RuaNome = reader.GetString("Endereço"),
                            BairroNome = reader.GetString("Bairro"),
                            CidadeNome = reader.GetString("Cidade")
                        };
                    }
                }
            }
            return cliente;
        }

        // Adicionar novo Cliente
        public void Add(Cliente cliente)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                // Insere na tabela cliente
                string query = "INSERT INTO \r\n" +
                    "cliente \r\n" +
                        "(nome, cpf, email, celular, cep, \r\n" +
                        " num_residencia, id_rua) \r\n" +
                    "VALUES \r\n" +
                        "(@nome, @cpf, @email, @celular, @cep, \r\n" +
                        " @num_residencia, @id_rua); \r\n" +
                    "UPDATE cliente \r\n" +
                        "SET cep = CONCAT(SUBSTRING(cep, 1, 2), \r\n" +
                        " '.', SUBSTRING(cep, 3, 3), '-', \r\n" +
                        " SUBSTRING(cep, 6, 3)) \r\n" +
                        "WHERE LENGTH(cep) = 8;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@email", cliente.Email);
                cmd.Parameters.AddWithValue("@celular", cliente.Celular);
                cmd.Parameters.AddWithValue("@cep", cliente.Cep);
                cmd.Parameters.AddWithValue("@num_residencia", cliente.NumResidencia);
                cmd.Parameters.AddWithValue("@id_rua", cliente.IdRua);
                cmd.ExecuteNonQuery();
            }
        }

        // Atualizar/editar dados
        public void Update(Cliente cliente)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                string query = "UPDATE \r\n" +
                    "   cliente \r\n" +
                    "SET \r\n" +
                    "   cliente.nome = @nome, \r\n" +
                    "   cliente.cpf = @cpf, \r\n" +
                    "   cliente.email = @email, \r\n" +
                    "   cliente.celular = @celular, \r\n" +
                    "   cliente.cep = @cep, \r\n" +
                    "   cliente.num_residencia = @num_residencia, \r\n" +
                    "   cliente.id_rua = @id_rua \r\n" +
                    "WHERE \r\n" +
                    "   cliente.id_cliente = @id_cliente;\r\n" +
                    "UPDATE cliente \r\n" +
                        "SET cep = CONCAT(SUBSTRING(cep, 1, 2), \r\n" +
                        " '.', SUBSTRING(cep, 3, 3), '-', \r\n" +
                        " SUBSTRING(cep, 6, 3)) \r\n" +
                        "WHERE LENGTH(cep) = 8;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@email", cliente.Email);
                cmd.Parameters.AddWithValue("@celular", cliente.Celular);
                cmd.Parameters.AddWithValue("@cep", cliente.Cep);
                cmd.Parameters.AddWithValue("@num_residencia", cliente.NumResidencia);
                cmd.Parameters.AddWithValue("@id_rua", cliente.IdRua);
                cmd.Parameters.AddWithValue("@id_cliente", cliente.IdCliente);
                cmd.ExecuteNonQuery();
            }
        }

        // Excluir Dados
        public void Delete(Cliente cliente)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                string query = "DELETE \r\n" +
                    "FROM \r\n" +
                    "   cliente \r\n" +
                    "WHERE \r\n" +
                    "   cliente.id_cliente = @id";


                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", cliente.IdCliente);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
