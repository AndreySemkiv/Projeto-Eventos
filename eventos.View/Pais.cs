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
    public partial class frmPais : Form
    {
        public frmPais()
        {
            InitializeComponent();

            txtPais.Enabled = false;
        }

        ConexaoModel conexao = new ConexaoModel();
        MySqlCommand cmd = new MySqlCommand();
        public String mensagem = ""; 

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtPais.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Conectar Banco
            cmd.Connection = conexao.conectar();
            
            // Comando para Inserir, Update, Delete
            cmd.CommandText = "INSERT INTO pais (descricao) VALUES (?)";

            //Parametros
            cmd.Parameters.AddWithValue("@descricao", txtPais.Text);

            // Executar a Query
            cmd.ExecuteNonQuery();
            
            // Fechar Conexão
            conexao.desconectar();

            //Limpar Campo
            txtPais.Clear();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtPais.Clear();
            txtPais.Enabled = true;
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {   
            //Conectar Banco
            cmd.Connection = conexao.conectar();

            // Comando para Inserir, Update, Delete
            cmd.CommandText = "SELECT * FROM pais WHERE descricao LIKE CONCAT('%',?,'%')";

            //Parametros
            cmd.Parameters.AddWithValue("@descricao", txtPais.Text);

            // Executar a Query
            cmd.ExecuteNonQuery();

            // Fechar Conexão
            conexao.desconectar();

            // Limpar Campo
            txtPais.Enabled=false;
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar Campo
            txtPais.Clear();
        }
    }
}
