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
    public partial class frmBairroView : Form
    {
        String mensagem = "";

        public frmBairroView()
        {
            InitializeComponent();
            txtBairro.Enabled = false;
            cbbCidade.Enabled = false;
            CarregarDados();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtBairro.Enabled = true;
            cbbCidade.Enabled = true;
            CarregarCidade();
            cbbCidade.ResetText();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            txtBairro.Enabled = true;
            cbbCidade.Enabled = false;
            CarregarCidade();
            cbbCidade.ResetText();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtBairro.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                if (bairroIdSelecionado.HasValue)
                {

                    // Atualizar o bairro existente
                    Bairro bairroAtualizado = new Bairro()
                    {
                        IdBairro = bairroIdSelecionado.Value,
                        Bairro_nome = descricao,
                        IdCidade = cbbCidade.SelectedValue.GetHashCode()

                    };

                    bairroDAO.Update(bairroAtualizado);
                    MessageBox.Show("Bairro atualizado com sucesso!");
                }
                else
                {
                    // Adicionar novo bairro
                    Bairro novoBairro = new Bairro()
                    {
                        Bairro_nome = descricao,
                        IdCidade = Convert.ToInt32(cbbCidade.SelectedValue)
                    };

                    bairroDAO.Add(novoBairro);
                    MessageBox.Show("Bairro salvo com sucesso!");
                }

                // Limpar o TextBox
                txtBairro.Text = string.Empty;
                txtBairro.Enabled = false;
                cbbCidade.Enabled = false;
                cbbCidade.ResetText();
                bairroIdSelecionado = null;

                // Recarregar os dados no DataGridView após salvar
                CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar bairro: {ex.Message}");
            }
        }

        private int? bairroIdSelecionado = null;

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtBairro.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                if (bairroIdSelecionado.HasValue)
                {
                    // Excluir o Bairro
                    Bairro bairroAtualizado = new Bairro()
                    {
                        IdBairro = bairroIdSelecionado.Value,
                        Bairro_nome = descricao,
                        IdCidade = bairroIdSelecionado.Value
                    };

                    bairroDAO.Delete(bairroAtualizado);
                    MessageBox.Show("Bairro Excluído com sucesso!");

                    // Limpar o TextBox
                    txtBairro.Text = string.Empty;
                    txtBairro.Enabled = false;
                    cbbCidade.Enabled = false;
                    cbbCidade.ResetText();
                    bairroIdSelecionado = null;

                    // Recarregar os dados no DataGridView após salvar
                    CarregarDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Excluir bairro: {ex.Message}");
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtBairro.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                var bairro = bairroDAO.GetByBairro(descricao);

                if (bairro != null)
                {
                    // Se o bairro for encontrado, mostrar os dados no DataGridView
                    DataTable dataTable = bairroDAO.GetBairroAsDataTable(descricao);
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Bairro não encontrado.");
                }

                txtBairro.Text = string.Empty;
                txtBairro.Enabled = false;
                cbbCidade.Enabled = false;
                cbbCidade.ResetText();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar bairro: {ex.Message}");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBairro.Clear();
            txtBairro.Enabled = false;
            cbbCidade.ResetText();
            cbbCidade.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }


        private BairroDAO bairroDAO = new BairroDAO();
        private void CarregarDados()
        {
            try
            {
                DataTable dataTable = bairroDAO.GetAll();
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}");
            }
        }

        // Carrega dados no ComboBox
        private CidadeDAO cidadeDAO = new CidadeDAO();
        public void CarregarCidade()
        {
            try
            {
                // Obtém os dados do banco de dados usando o CidadeDAO
                DataTable dataTable = cidadeDAO.GetAll();

                // Verifica se as colunas necessárias estão presentes
                if (!dataTable.Columns.Contains("Cidade") || !dataTable.Columns.Contains("Id") || !dataTable.Columns.Contains("Estado"))
                {
                    MessageBox.Show("Não foram encontrados os dados de cidade e estado!");
                    return;
                }

                // Cria uma lista de objetos CidadeEstado a partir do DataTable
                List<CidadeEstado> listaDeCidades = new List<CidadeEstado>();
                foreach (DataRow row in dataTable.Rows)
                {
                    // Obtém os valores das colunas Cidade, Id e Estado
                    int IdCidade = Convert.ToInt32(row["Id"]);
                    string Cidade_nome = row["Cidade"].ToString();
                    string Estado_nome = row["Estado"].ToString();

                    // Adiciona o objeto CidadeEstado à lista
                    listaDeCidades.Add(new CidadeEstado(IdCidade, Cidade_nome, Estado_nome));
                }

                // Limpa os itens anteriores do ComboBox e define a nova fonte de dados
                cbbCidade.DataSource = null;
                cbbCidade.Items.Clear();

                // Define a fonte de dados do ComboBox, exibindo o cidade e estado com o id como valor
                cbbCidade.DataSource = listaDeCidades;
                cbbCidade.DisplayMember = "CidadeEstadoConcatenado";  // Exibirá o nome do cidade e do Estado no ComboBox
                cbbCidade.ValueMember = "IdCidade";       // Associará o IdCidade como valor

                // Acessa o id_cidade selecionado diretamente pelo SelectedValue
                int cidadeSelecionado = Convert.ToInt32(cbbCidade.SelectedValue);
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
                // Obter o ID do bairro selecionado no DataGridView
                bairroIdSelecionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Obter a descrição do bairro e carregar no TextBox
                string descricao = dataGridView1.SelectedRows[0].Cells["Bairro"].Value.ToString();
                txtBairro.Text = descricao;

                // Obter o ID do cidade selecionado no DataGridView
                CarregarCidade();
                cbbCidade.Text = dataGridView1.SelectedRows[0].Cells["Cidade"].Value.ToString();

                txtBairro.Enabled = true;
                cbbCidade.Enabled = true;

            }
            else
            {
                MessageBox.Show("Selecione um bairro para editar.");
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnAddCidade_Click(object sender, EventArgs e)
        {
            txtBairro.Clear();
            txtBairro.Enabled = false;
            cbbCidade.ResetText();
            cbbCidade.Enabled = false;
            frmCidadeView add = new frmCidadeView();
            add.ShowDialog();
        }
    }
}