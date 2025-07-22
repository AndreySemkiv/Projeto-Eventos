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
    public class ProdutoDAO
    {
        private DbContext dbContext = new DbContext();

        //Carregar todos os dados
        public DataTable GetAll()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                string query = "SELECT produto.id_produto AS Id, \r\n" +
                    "   produto.descricao AS Descrição, \r\n" +
                    "   produto.tamanho AS Tamanho, \r\n" +
                    "   produto.quantidade AS Quant, \r\n" +
                    "   produto.valor AS R$_Aluguel, \r\n" +
                    "   produto.custo AS R$_Custo, \r\n" +
                    "   cor.cor_nome AS Cor, \r\n" +
                    "   cor.cod_rgb_hexa_cmyk AS Cod_da_Cor, \r\n" +
                    "   tema.tema_nome AS Tema, \r\n" +
                    "   categoria.categoria_nome AS Categoria \r\n" +
                    "FROM \r\n" +
                    "   produto \r\n" +
                    "INNER JOIN \r\n" +
                    "   cor ON produto.id_cor = cor.id_cor \r\n" +
                    "INNER JOIN \r\n" +
                    "   tema ON produto.id_tema = tema.id_tema \r\n" +
                    "INNER JOIN \r\n" +
                    "   categoria ON produto.id_categoria = categoria.id_categoria \r\n" +
                    "ORDER BY \r\n" +
                    "   produto.descricao";
                
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        // Carregar dados no Grid
        public DataTable GetProdutoAsDataTable(string descricao)
        {

            string query = "SELECT produto.id_produto AS Id, \r\n" +
                    "   produto.descricao AS Descrição, \r\n" +
                    "   produto.tamanho AS Tamanho, \r\n" +
                    "   produto.quantidade AS Quant, \r\n" +
                    "   produto.valor AS R$_Aluguel, \r\n" +
                    "   produto.custo AS R$_Custo, \r\n" +
                    "   cor.cor_nome AS Cor, \r\n" +
                    "   cor.cod_rgb_hexa_cmyk AS Cod_da_Cor, \r\n" +
                    "   tema.tema_nome AS Tema, \r\n" +
                    "   categoria.categoria_nome AS Categoria \r\n" +
                    "FROM \r\n" +
                    "   produto \r\n" +
                    "INNER JOIN \r\n" +
                    "   cor ON produto.id_cor = cor.id_cor \r\n" +
                    "INNER JOIN \r\n" +
                    "   tema ON produto.id_tema = tema.id_tema \r\n" +
                    "INNER JOIN \r\n" +
                    "   categoria ON produto.id_categoria = categoria.id_categoria \r\n" +
                    "WHERE \r\n" +
                    "   descricao \r\n" +
                    "LIKE CONCAT('%',@descricao,'%') \r\n" +
                    "ORDER BY \r\n" +
                    "   produto.descricao \r\n";


            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@descricao", descricao);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Carregar dados da Pesquisa pelo nome do produto
        public Produto GetByProduto(string Descricao)
        {
            Produto produto = null;

            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                
                string query = "SELECT produto.id_produto AS Id, \r\n" +
                    "   produto.descricao AS Descrição, \r\n" +
                    "   produto.tamanho AS Tamanho, \r\n" +
                    "   produto.quantidade AS Quant, \r\n" +
                    "   produto.valor AS R$_Aluguel, \r\n" +
                    "   produto.custo AS R$_Custo, \r\n" +
                    "   cor.cor_nome AS Cor, \r\n" +
                    "   cor.cod_rgb_hexa_cmyk AS Cod_da_Cor, \r\n" +
                    "   tema.tema_nome AS Tema, \r\n" +
                    "   categoria.categoria_nome AS Categoria \r\n" +
                    "FROM \r\n" +
                    "   produto \r\n" +
                    "INNER JOIN \r\n" +
                    "   cor ON produto.id_cor = cor.id_cor \r\n" +
                    "INNER JOIN \r\n" +
                    "   tema ON produto.id_tema = tema.id_tema \r\n" +
                    "INNER JOIN \r\n" +
                    "   categoria ON produto.id_categoria = categoria.id_categoria \r\n" +
                    "WHERE \r\n" +
                    "   descricao \r\n" +
                    "LIKE CONCAT('%',@descricao,'%') \r\n" +
                    "ORDER BY \r\n" +
                    "   produto.descricao \r\n";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@descricao", Descricao);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        produto = new Produto()
                        {
                            IdProduto = reader.GetInt32("Id"),
                            Descricao = reader.GetString("Descrição"),
                            Tamanho = reader.GetString("Tamanho"),
                            CategoriaNome = reader.GetString("Categoria"),
                            TemaNome = reader.GetString("Tema"),
                            CorNome = reader.GetString("Cor"),
                            Cod_rgb_hexa_cmyk = reader.GetString("Cod_Cor"),
                            Quantidade = reader.GetDouble("Quant"),
                            Custo = reader.GetDouble("R$_Custo"),
                            Valor = reader.GetDouble("R$_Aluguel")
                        };
                    }
                }
            }
            return produto;
        }

        // Adicionar novo Produto
        public void Add(Produto produto)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                // Insere na tabela produto
                string query = "INSERT INTO \r\n" +
                    "produto \r\n" +
                        "(descricao, tamanho, quantidade, valor, custo, \r\n" +
                        " id_cor, id_tema, id_categoria) \r\n" +
                    "VALUES \r\n" +
                        "(@descricao, @tamanho, @quantidade, @valor, @custo, \r\n" +
                        " @id_cor, @id_tema, @id_categoria);";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@tamanho", produto.Tamanho);
                cmd.Parameters.AddWithValue("@quantidade", produto.Quantidade);
                cmd.Parameters.AddWithValue("@valor", produto.Valor);
                cmd.Parameters.AddWithValue("@custo", produto.Custo);
                cmd.Parameters.AddWithValue("@id_cor", produto.IdCor);
                cmd.Parameters.AddWithValue("@id_tema", produto.IdTema);
                cmd.Parameters.AddWithValue("@id_categoria", produto.IdCategoria);

                cmd.ExecuteNonQuery();
            }
        }

        // Atualizar/editar dados
        public void Update(Produto produto)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();

                string query = "UPDATE \r\n" +
                    "   produto \r\n" +
                    "SET \r\n" +
                    "   produto.descricao = @descricao, \r\n" +
                    "   produto.tamanho = @tamanho, \r\n" +
                    "   produto.quantidade = @quantidade, \r\n" +
                    "   produto.valor = @valor, \r\n" +
                    "   produto.custo = @custo, \r\n" +
                    "   produto.id_cor = @id_cor, \r\n" +
                    "   produto.id_tema = @id_tema, \r\n" +
                    "   produto.id_categoria = @id_categoria \r\n" +
                    "WHERE \r\n" +
                    "   produto.id_produto = @id_produto;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@tamanho", produto.Tamanho);
                cmd.Parameters.AddWithValue("@quantidade", produto.Quantidade);
                cmd.Parameters.AddWithValue("@valor", produto.Valor);
                cmd.Parameters.AddWithValue("@custo", produto.Custo);
                cmd.Parameters.AddWithValue("@id_cor", produto.IdCor);
                cmd.Parameters.AddWithValue("@id_tema", produto.IdTema);
                cmd.Parameters.AddWithValue("@id_categoria", produto.IdCategoria);

                cmd.ExecuteNonQuery();
            }
        }

        // Excluir Dados
        public void Delete(Produto produto)
        {
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                conn.Open();
                
                string query = "DELETE \r\n" +
                    "FROM \r\n" +
                    "   produto \r\n" +
                    "WHERE \r\n" +
                    "   produto.id_produto = @id";
                
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", produto.IdProduto);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
