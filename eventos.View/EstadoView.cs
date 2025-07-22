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
    public partial class frmEstadoView : Form
    {
        String mensagem = "";

        public frmEstadoView()
        {
            InitializeComponent();
            txtEstado.Enabled = false;
            cbbPais.Enabled = false;
            CarregarDados();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtEstado.Enabled = true;
            cbbPais.Enabled = true;
            CarregarPais();
            cbbPais.ResetText();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            txtEstado.Enabled = true;
            cbbPais.Enabled = false;
            cbbPais.ResetText();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtEstado.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                if (estadoIdSelecionado.HasValue)
                {
                    // Atualizar o estado existente
                    Estado estadoAtualizado = new Estado()
                    {
                        IdEstado = estadoIdSelecionado.Value,
                        Estado_nome = descricao,
                        IdPais = cbbPais.SelectedValue.GetHashCode()
                    };

                    estadoDAO.Update(estadoAtualizado);
                    MessageBox.Show("Estado atualizado com sucesso!");
                }
                else
                {
                    // Adicionar novo estado
                    Estado novoEstado = new Estado()
                    {
                        Estado_nome = descricao,
                        IdPais = cbbPais.SelectedValue.GetHashCode()
                    };

                    estadoDAO.Add(novoEstado);
                    MessageBox.Show("Estado salvo com sucesso!");
                }

                // Limpar o TextBox
                txtEstado.Text = string.Empty;
                txtEstado.Enabled = false;
                cbbPais.Enabled = false;
                cbbPais.ResetText();
                estadoIdSelecionado = null;

                // Recarregar os dados no DataGridView após salvar
                CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar estado: {ex.Message}");
            }
        }

        private int? estadoIdSelecionado = null;

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtEstado.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                if (estadoIdSelecionado.HasValue)
                {
                    // Excluir o Estado
                    Estado estadoAtualizado = new Estado()
                    {
                        IdEstado = estadoIdSelecionado.Value,
                        Estado_nome = descricao,
                        IdPais = estadoIdSelecionado.Value
                    };

                    estadoDAO.Delete(estadoAtualizado);
                    MessageBox.Show("Estado Excluído com sucesso!");

                    // Limpar o TextBox
                    txtEstado.Text = string.Empty;
                    txtEstado.Enabled = false;
                    cbbPais.Enabled = false;
                    cbbPais.ResetText();
                    estadoIdSelecionado = null;

                    // Recarregar os dados no DataGridView após salvar
                    CarregarDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Excluir estado: {ex.Message}");
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtEstado.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                var estado = estadoDAO.GetByEstado(descricao);

                if (estado != null)
                {
                    // Se o estado for encontrado, mostrar os dados no DataGridView
                    DataTable dataTable = estadoDAO.GetEstadoAsDataTable(descricao);
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Estado não encontrado.");
                }

                txtEstado.Text = string.Empty;
                txtEstado.Enabled = false;
                cbbPais.Enabled = false;
                cbbPais.ResetText();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar estado: {ex.Message}");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEstado.Clear();
            txtEstado.Enabled = false;
            cbbPais.ResetText();
            cbbPais.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Carrega dados no GRID
        private EstadoDAO estadoDAO = new EstadoDAO();
        private void CarregarDados()
        {
            try
            {
                DataTable dataTable = estadoDAO.GetAll();
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
                // Obtém os dados do banco de dados usando o EstadoDAO
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
                // Obter o ID do estado selecionado no DataGridView
                estadoIdSelecionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Obter a descrição do estado e carregar no TextBox
                string descricao = dataGridView1.SelectedRows[0].Cells["Estado"].Value.ToString();
                txtEstado.Text = descricao;

                // Obter o ID do pais selecionado no DataGridView
                CarregarPais();
                cbbPais.Text = dataGridView1.SelectedRows[0].Cells["País"].Value.ToString();

                txtEstado.Enabled = true;
                cbbPais.Enabled = true;

            }
            else
            {
                MessageBox.Show("Selecione um estado para editar.");
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnAddPais_Click(object sender, EventArgs e)
        {
            txtEstado.Clear();
            txtEstado.Enabled = false;
            cbbPais.ResetText();
            cbbPais.Enabled = false;
            frmPaisView add = new frmPaisView();
            add.ShowDialog();
        }
    }
}