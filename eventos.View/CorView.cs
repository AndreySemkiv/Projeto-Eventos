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

namespace Eventos.View
{
    public partial class frmCorView : Form
    {
        String mensagem = "";

        public frmCorView()
        {
            InitializeComponent();
            txtCor.Enabled = false;
            cbbPais.Enabled = false;
            CarregarDados();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtCor.Enabled = true;
            cbbPais.Enabled = true;
            CarregarPais();
            cbbPais.ResetText();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            txtCor.Enabled = true;
            cbbPais.Enabled = false;
            cbbPais.ResetText();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtCor.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                if (corIdSelecionado.HasValue)
                {
                    // Atualizar o cor existente
                    Cor corAtualizado = new Cor()
                    {
                        IdCor = corIdSelecionado.Value,
                        Cor_nome = descricao,
                        IdPais = cbbPais.SelectedValue.GetHashCode()
                    };

                    corDAO.Update(corAtualizado);
                    MessageBox.Show("Cor atualizado com sucesso!");
                }
                else
                {
                    // Adicionar novo cor
                    Cor novoCor = new Cor()
                    {
                        Cor_nome = descricao,
                        IdPais = cbbPais.SelectedValue.GetHashCode()
                    };

                    corDAO.Add(novoCor);
                    MessageBox.Show("Cor salvo com sucesso!");
                }

                // Limpar o TextBox
                txtCor.Text = string.Empty;
                txtCor.Enabled = false;
                cbbPais.Enabled = false;
                cbbPais.ResetText();
                corIdSelecionado = null;

                // Recarregar os dados no DataGridView após salvar
                CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar cor: {ex.Message}");
            }
        }

        private int? corIdSelecionado = null;

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtCor.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                if (corIdSelecionado.HasValue)
                {
                    // Excluir o Cor
                    Cor corAtualizado = new Cor()
                    {
                        IdCor = corIdSelecionado.Value,
                        Cor_nome = descricao,
                        IdPais = corIdSelecionado.Value
                    };

                    corDAO.Delete(corAtualizado);
                    MessageBox.Show("Cor Excluído com sucesso!");

                    // Limpar o TextBox
                    txtCor.Text = string.Empty;
                    txtCor.Enabled = false;
                    cbbPais.Enabled = false;
                    cbbPais.ResetText();
                    corIdSelecionado = null;

                    // Recarregar os dados no DataGridView após salvar
                    CarregarDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Excluir cor: {ex.Message}");
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtCor.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                var cor = corDAO.GetByCor(descricao);

                if (cor != null)
                {
                    // Se o cor for encontrado, mostrar os dados no DataGridView
                    DataTable dataTable = corDAO.GetCorAsDataTable(descricao);
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Cor não encontrado.");
                }

                txtCor.Text = string.Empty;
                txtCor.Enabled = false;
                cbbPais.Enabled = false;
                cbbPais.ResetText();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar cor: {ex.Message}");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCor.Clear();
            txtCor.Enabled = false;
            cbbPais.ResetText();
            cbbPais.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Carrega dados no GRID
        private CorDAO corDAO = new CorDAO();
        private void CarregarDados()
        {
            try
            {
                DataTable dataTable = corDAO.GetAll();
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}");
            }
        }

        // Carrega dados no ComboBox
        private PaisDAO paisDAO = new PaisDAO();
        private void CarregarPais()
        {
            try
            {
                // Obtém os dados do banco de dados usando o CorDAO
                DataTable dataTable = paisDAO.GetAll();

                // Verifica se as colunas necessárias estão presentes
                if (dataTable.Columns.Contains("País") && dataTable.Columns.Contains("Id"))
                {
                    cbbPais.DataSource = dataTable;
                    cbbPais.DisplayMember = "País";
                    cbbPais.ValueMember = "Id";
                }
                else 
                {
                    MessageBox.Show("Não Localizado!!!");
                }
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
                // Obter o ID do cor selecionado no DataGridView
                corIdSelecionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Obter a descrição do cor e carregar no TextBox
                string descricao = dataGridView1.SelectedRows[0].Cells["Cor"].Value.ToString();
                txtCor.Text = descricao;

                // Obter o ID do pais selecionado no DataGridView
                CarregarPais();
                cbbPais.Text = dataGridView1.SelectedRows[0].Cells["País"].Value.ToString();

                txtCor.Enabled = true;
                cbbPais.Enabled = true;

            }
            else
            {
                MessageBox.Show("Selecione um cor para editar.");
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnAddPais_Click(object sender, EventArgs e)
        {
            txtCor.Clear();
            txtCor.Enabled = false;
            cbbPais.ResetText();
            cbbPais.Enabled = false;
            frmPaisView add = new frmPaisView();
            add.ShowDialog();
        }
    }
}