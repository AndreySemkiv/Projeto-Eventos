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
            txtCodCor.Enabled = false;
            CarregarDados();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtCor.Enabled = true;
            txtCodCor.Enabled = true;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            txtCor.Enabled = false;
            txtCodCor.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtCor.Text;
                string cod_cor = txtCodCor.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("O Nome da Cor é obrigatório.");
                    return;
                }

                if (string.IsNullOrEmpty(cod_cor))
                {
                    MessageBox.Show("O Código da Cor é obrigatório.");
                    return;
                }

                if (corIdSelecionado.HasValue)
                {
                    // Atualizar o cor existente
                    Cor corAtualizado = new Cor()
                    {
                        IdCor = corIdSelecionado.Value,
                        CorNome = descricao,
                        CodCor = cod_cor
                    };

                    corDAO.Update(corAtualizado);
                    MessageBox.Show("Cor atualizada com sucesso!");
                }
                else
                {
                    // Adicionar nova cor
                    Cor novaCor = new Cor()
                    {
                        CorNome = descricao,
                        CodCor = cod_cor
                    };

                    corDAO.Add(novaCor);
                    MessageBox.Show("Cor salvo com sucesso!");
                }

                // Limpar o TextBox
                txtCor.Text = string.Empty;
                txtCor.Enabled = false;
                txtCodCor.Enabled = false;
                txtCodCor.ResetText();
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
                    txtCodCor.Enabled = false;
                    txtCodCor.ResetText();
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
                txtCodCor.Enabled = false;
                txtCodCor.ResetText();

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
            txtCodCor.ResetText();
            txtCodCor.Enabled = false;
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
                    txtCodCor.DataSource = dataTable;
                    txtCodCor.DisplayMember = "País";
                    txtCodCor.ValueMember = "Id";
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
                txtCodCor.Text = dataGridView1.SelectedRows[0].Cells["País"].Value.ToString();

                txtCor.Enabled = true;
                txtCodCor.Enabled = true;

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
            txtCodCor.ResetText();
            txtCodCor.Enabled = false;
            frmPaisView add = new frmPaisView();
            add.ShowDialog();
        }
    }
}