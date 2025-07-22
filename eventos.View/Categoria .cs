using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Eventos
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();

            txtCategoria.Enabled = false;
        }

        ConexaoModel conexao = new ConexaoModel();
        MySqlCommand cmd = new MySqlCommand();
        public String mensagem = ""; 

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtCategoria.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Conectar Banco
            cmd.Connection = conexao.conectar();
            
            // Comando para Inserir, Update, Delete
            cmd.CommandText = "INSERT INTO categoria (descricao) VALUES (?)";

            //Parametros
            cmd.Parameters.AddWithValue("@descricao", txtCategoria.Text);

            // Executar a Query
            cmd.ExecuteNonQuery();
            
            // Fechar Conexão
            conexao.desconectar();

            //Limpar Campo
            txtCategoria.Clear();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtCategoria.Clear();
            txtCategoria.Enabled = true;
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {   
            //Conectar Banco
            cmd.Connection = conexao.conectar();

            // Comando para Inserir, Update, Delete
            cmd.CommandText = "SELECT * FROM categoria WHERE descricao LIKE CONCAT('%',?,'%')";

            //Parametros
            cmd.Parameters.AddWithValue("@descricao", txtCategoria.Text);

            // Executar a Query
            cmd.ExecuteNonQuery();

            // Fechar Conexão
            conexao.desconectar();

            // Limpar Campo
            txtCategoria.Enabled=false;
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar Campo
            txtCategoria.Clear();
        }
    }
}
