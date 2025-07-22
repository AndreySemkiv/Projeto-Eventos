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
    public partial class frmTema : Form
    {
        public frmTema()
        {
            InitializeComponent();

            txtTema.Enabled = false;
        }

        ConexaoModel conexao = new ConexaoModel();
        MySqlCommand cmd = new MySqlCommand();
        public String mensagem = ""; 

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtTema.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Conectar Banco
            cmd.Connection = conexao.conectar();
            
            // Comando para Inserir, Update, Delete
            cmd.CommandText = "INSERT INTO tema (descricao) VALUES (?)";

            //Parametros
            cmd.Parameters.AddWithValue("@descricao", txtTema.Text);

            // Executar a Query inserir
            cmd.ExecuteNonQuery();

            // Fechar Conexão
            conexao.desconectar();

            //Limpar Campo
            txtTema.Clear();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtTema.Clear();
            txtTema.Enabled = true;
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {   
            //Conectar Banco
            cmd.Connection = conexao.conectar();

            // Comando para Ler os Dados
            cmd.CommandText = "SELECT * FROM tema WHERE descricao LIKE CONCAT('%',?,'%')";

            //Parametros
            cmd.Parameters.AddWithValue("@descricao", txtTema.Text);

            // Executar a Query leitura do banco
            cmd.ExecuteReader();

            // Fechar Conexão
            conexao.desconectar();

            // Limpar Campo
            txtTema.Enabled=false;
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar Campo
            txtTema.Clear();
        }
    }
}
