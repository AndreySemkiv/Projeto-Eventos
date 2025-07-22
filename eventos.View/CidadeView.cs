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
    public partial class frmCidadeView : Form
    {
        String mensagem = "";

        public frmCidadeView()
        {
            InitializeComponent();
            txtCidade.Enabled = false;
            cbbEstado.Enabled = false;
            CarregarDados();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtCidade.Enabled = true;
            cbbEstado.Enabled = true;
            CarregarEstado();
            cbbEstado.ResetText();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            txtCidade.Enabled = true;
            cbbEstado.Enabled = false;
            CarregarEstado();
            cbbEstado.ResetText();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtCidade.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                if (cidadeIdSelecionado.HasValue)
                {
                    
                    // Atualizar o cidade existente
                    Cidade cidadeAtualizado = new Cidade()
                    {
                        IdCidade = cidadeIdSelecionado.Value,
                        Cidade_nome = descricao,
                        IdEstado = cbbEstado.SelectedValue.GetHashCode()

                    };

                    cidadeDAO.Update(cidadeAtualizado);
                    MessageBox.Show("Cidade atualizado com sucesso!");
                }
                else
                {
                    // Adicionar novo cidade
                    Cidade novoCidade = new Cidade()
                    {
                        Cidade_nome = descricao,
                        IdEstado = Convert.ToInt32(cbbEstado.SelectedValue)
                    };

                    cidadeDAO.Add(novoCidade);
                    MessageBox.Show("Cidade salvo com sucesso!");
                }

                // Limpar o TextBox
                txtCidade.Text = string.Empty;
                txtCidade.Enabled = false;
                cbbEstado.Enabled = false;
                cbbEstado.ResetText();
                cidadeIdSelecionado = null;

                // Recarregar os dados no DataGridView após salvar
                CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar cidade: {ex.Message}");
            }
        }

        private int? cidadeIdSelecionado = null;

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtCidade.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                if (cidadeIdSelecionado.HasValue)
                {
                    // Excluir o Cidade
                    Cidade cidadeAtualizado = new Cidade()
                    {
                        IdCidade = cidadeIdSelecionado.Value,
                        Cidade_nome = descricao,
                        IdEstado = cidadeIdSelecionado.Value
                    };

                    cidadeDAO.Delete(cidadeAtualizado);
                    MessageBox.Show("Cidade Excluído com sucesso!");

                    // Limpar o TextBox
                    txtCidade.Text = string.Empty;
                    txtCidade.Enabled = false;
                    cbbEstado.Enabled = false;
                    cbbEstado.ResetText();
                    cidadeIdSelecionado = null;

                    // Recarregar os dados no DataGridView após salvar
                    CarregarDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Excluir cidade: {ex.Message}");
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtCidade.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                var cidade = cidadeDAO.GetByCidade(descricao);

                if (cidade != null)
                {
                    // Se o cidade for encontrado, mostrar os dados no DataGridView
                    DataTable dataTable = cidadeDAO.GetCidadeAsDataTable(descricao);
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Cidade não encontrado.");
                }

                txtCidade.Text = string.Empty;
                txtCidade.Enabled = false;
                cbbEstado.Enabled = false;
                cbbEstado.ResetText();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar cidade: {ex.Message}");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCidade.Clear();
            txtCidade.Enabled = false;
            cbbEstado.ResetText();
            cbbEstado.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private CidadeDAO cidadeDAO = new CidadeDAO();
        private void CarregarDados()
        {
            try
            {
                DataTable dataTable = cidadeDAO.GetAll();
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}");
            }
        }

        // Carrega dados no ComboBox
        private EstadoDAO estadoDAO = new EstadoDAO();
        public void CarregarEstado()
        {
            try
            {
                // Obtém os dados do banco de dados usando o EstadoDAO
                DataTable dataTable = estadoDAO.GetAll();

                // Verifica se as colunas necessárias estão presentes
                if (!dataTable.Columns.Contains("Estado") || !dataTable.Columns.Contains("Id") || !dataTable.Columns.Contains("País"))
                {
                    MessageBox.Show("Não foram encontrados os dados de estado e país!");
                    return;
                }

                // Cria uma lista de objetos EstadoPais a partir do DataTable
                List<EstadoPais> listaDeEstados = new List<EstadoPais>();
                foreach (DataRow row in dataTable.Rows)
                {
                    // Obtém os valores das colunas Estado, Id e País
                    int IdEstado = Convert.ToInt32(row["Id"]);
                    string Estado_nome = row["Estado"].ToString();
                    string Pais_nome = row["País"].ToString();

                    // Adiciona o objeto EstadoPais à lista
                    listaDeEstados.Add(new EstadoPais(IdEstado, Estado_nome, Pais_nome));
                }

                // Limpa os itens anteriores do ComboBox e define a nova fonte de dados
                cbbEstado.DataSource = null;
                cbbEstado.Items.Clear();

                // Define a fonte de dados do ComboBox, exibindo o estado e país com o id como valor
                cbbEstado.DataSource = listaDeEstados;
                cbbEstado.DisplayMember = "EstadoPaisConcatenado";  // Exibirá o nome do estado e do País no ComboBox
                cbbEstado.ValueMember = "IdEstado";       // Associará o IdEstado como valor

                // Acessa o id_estado selecionado diretamente pelo SelectedValue
                int estadoSelecionado = Convert.ToInt32(cbbEstado.SelectedValue);
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
                // Obter o ID do cidade selecionado no DataGridView
                cidadeIdSelecionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Obter a descrição do cidade e carregar no TextBox
                string descricao = dataGridView1.SelectedRows[0].Cells["Cidade"].Value.ToString();
                txtCidade.Text = descricao;

                // Obter o ID do estado selecionado no DataGridView
                CarregarEstado();
                cbbEstado.Text = dataGridView1.SelectedRows[0].Cells["Estado"].Value.ToString();

                txtCidade.Enabled = true;
                cbbEstado.Enabled = true;

            }
            else
            {
                MessageBox.Show("Selecione um cidade para editar.");
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnAddEstado_Click(object sender, EventArgs e)
        {
            txtCidade.Clear();
            txtCidade.Enabled = false;
            cbbEstado.ResetText();
            cbbEstado.Enabled = false;
            frmEstadoView add = new frmEstadoView();
            add.ShowDialog();
        }
    }
}