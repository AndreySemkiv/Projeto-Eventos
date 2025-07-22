using Eventos.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eventos.DAO;
using Eventos.Control;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Eventos.View
{
    public partial class frmRuaView : Form
    {
        String mensagem = "";

        public frmRuaView()
        {
            InitializeComponent();
            txtRua.Enabled = false;
            cbbBairro.Enabled = false;
            mskCepRua.Enabled = false;
            CarregarDados();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtRua.Enabled = true;
            cbbBairro.Enabled = true;
            mskCepRua.Enabled = true;
            CarregarBairro();
            cbbBairro.ResetText();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            txtRua.Enabled = true;
            cbbBairro.Enabled = false;
            mskCepRua.Enabled = false;
            CarregarBairro();
            cbbBairro.ResetText();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtRua.Text;
                string ceprua = mskCepRua.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                if (string.IsNullOrEmpty(ceprua))
                {
                    MessageBox.Show("A CEP é obrigatório.");
                    return;
                }

                if (ruaIdSelecionado.HasValue)
                {

                    // Atualizar a rua existente
                    Rua ruaAtualizado = new Rua()
                    {
                        IdRua = ruaIdSelecionado.Value,
                        Rua_nome = descricao,
                        Cep_rua = ceprua,
                        IdBairro = cbbBairro.SelectedValue.GetHashCode()

                    };

                    ruaDAO.Update(ruaAtualizado);
                    MessageBox.Show("Rua atualizada com sucesso!");
                }
                else
                {
                    // Adicionar novo rua
                    Rua novoRua = new Rua()
                    {
                        Rua_nome = descricao,
                        Cep_rua = ceprua,
                        IdBairro = Convert.ToInt32(cbbBairro.SelectedValue)
                    };

                    ruaDAO.Add(novoRua);
                    MessageBox.Show("Rua salva com sucesso!");
                }

                // Limpar o TextBox
                txtRua.Text = string.Empty;
                txtRua.Enabled = false;
                mskCepRua.Text = string.Empty;
                mskCepRua.Enabled = false;
                cbbBairro.Enabled = false;
                cbbBairro.ResetText();
                ruaIdSelecionado = null;

                // Recarregar os dados no DataGridView após salvar
                CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar rua: {ex.Message}");
            }
        }

        private int? ruaIdSelecionado = null;

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtRua.Text;
                string ceprua = mskCepRua.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                if (string.IsNullOrEmpty(ceprua))
                {
                    MessageBox.Show("A CEP é obrigatório.");
                    return;
                }

                if (ruaIdSelecionado.HasValue)
                {
                    // Excluir o Rua
                    Rua ruaAtualizado = new Rua()
                    {
                        IdRua = ruaIdSelecionado.Value,
                        Rua_nome = descricao,
                        Cep_rua = ceprua,
                        IdBairro = ruaIdSelecionado.Value
                    };

                    ruaDAO.Delete(ruaAtualizado);
                    MessageBox.Show("Rua Excluída com sucesso!");

                    // Limpar o TextBox
                    txtRua.Text = string.Empty;
                    txtRua.Enabled = false;
                    mskCepRua.Text = string.Empty;
                    mskCepRua.Enabled = false;
                    cbbBairro.Enabled = false;
                    cbbBairro.ResetText();
                    ruaIdSelecionado = null;

                    // Recarregar os dados no DataGridView após salvar
                    CarregarDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Excluir rua: {ex.Message}");
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtRua.Text;
                string ceprua = mskCepRua.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                /*if (string.IsNullOrEmpty(ceprua))
                {
                    MessageBox.Show("A CEP é obrigatório.");
                    return;
                }*/
                
                var rua = ruaDAO.GetByRua(descricao);

                if (rua != null)
                {
                    // Se a rua for encontrada, mostrar os dados no DataGridView
                    DataTable dataTable = ruaDAO.GetRuaAsDataTable(descricao);
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Rua não encontrado.");
                }

                txtRua.Text = string.Empty;
                txtRua.Enabled = false;
                cbbBairro.Enabled = false;
                cbbBairro.ResetText();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar rua: {ex.Message}");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRua.Clear();
            txtRua.Enabled = false;
            mskCepRua.Clear();
            mskCepRua.Enabled = false;
            cbbBairro.ResetText();
            cbbBairro.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }


        private RuaDAO ruaDAO = new RuaDAO();
        private void CarregarDados()
        {
            try
            {
                DataTable dataTable = ruaDAO.GetAll();
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}");
            }
        }

        // Carrega dados no ComboBox
        private BairroDAO bairroDAO = new BairroDAO();
        public void CarregarBairro()
        {
            try
            {
                // Obtém os dados do banco de dados usando o BairroDAO
                DataTable dataTable = bairroDAO.GetAll();

                // Verifica se as colunas necessárias estão presentes
                if (!dataTable.Columns.Contains("Id") || !dataTable.Columns.Contains("Bairro") || !dataTable.Columns.Contains("Cidade") || !dataTable.Columns.Contains("Estado"))
                {
                    MessageBox.Show("Não foram encontrados os dados de bairro, cidade e estado!");
                    return;
                }

                // Cria uma lista de objetos BairroCidade a partir do DataTable
                List<BairroCidade> listaDeBairros = new List<BairroCidade>();
                foreach (DataRow row in dataTable.Rows)
                {
                    // Obtém os valores das colunas Bairro, Id, Cidade e estado
                    int IdBairro = Convert.ToInt32(row["Id"]);
                    string Bairro_nome = row["Bairro"].ToString();
                    string Cidade_nome = row["Cidade"].ToString();
                    string Estado_nome = row["Estado"].ToString();

                    // Adiciona o objeto BairroCidade à lista
                    listaDeBairros.Add(new BairroCidade(IdBairro, Bairro_nome, Cidade_nome, Estado_nome));
                }

                // Limpa os itens anteriores do ComboBox e define a nova fonte de dados
                cbbBairro.DataSource = null;
                cbbBairro.Items.Clear();

                // Define a fonte de dados do ComboBox, exibindo o bairro e cidade com o id como valor
                cbbBairro.DataSource = listaDeBairros;
                cbbBairro.DisplayMember = "BairroCidadeConcatenado";  // Exibirá o nome do bairro da Cidade e do Estado no ComboBox
                cbbBairro.ValueMember = "IdBairro";       // Associará o IdBairro como valor

                // Acessa o id_bairro selecionado diretamente pelo SelectedValue
                int bairroSelecionado = Convert.ToInt32(cbbBairro.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obter o ID do rua selecionado no DataGridView
                ruaIdSelecionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Obter a descrição da rua e carregar no TextBox
                string descricao = dataGridView1.SelectedRows[0].Cells["Rua"].Value.ToString();
                txtRua.Text = descricao;

                // Obter a descrição da rua e carregar no TextBox
                string ceprua = dataGridView1.SelectedRows[0].Cells["CEP"].Value.ToString();
                mskCepRua.Text = ceprua;

                // Obter o ID do bairro selecionado no DataGridView
                CarregarBairro();
                cbbBairro.Text = dataGridView1.SelectedRows[0].Cells["Bairro"].Value.ToString();

                txtRua.Enabled = true;
                mskCepRua.Enabled = true;
                cbbBairro.Enabled = true;

            }
            else
            {
                MessageBox.Show("Selecione um rua para editar.");
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnAddBairro_Click(object sender, EventArgs e)
        {
            txtRua.Clear();
            txtRua.Enabled = false;
            cbbBairro.ResetText();
            cbbBairro.Enabled = false;
            frmBairroView add = new frmBairroView();
            add.ShowDialog();
        }
    }
}