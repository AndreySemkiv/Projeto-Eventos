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

namespace Eventos.View
{
    public partial class frmPaisView : Form
    {
        String mensagem = "";

        public frmPaisView()
        {
            InitializeComponent();
            txtPais.Enabled = false;
            CarregarDados();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtPais.Enabled = true;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            txtPais.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtPais.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                if (paisIdSelecionado.HasValue)
                {
                    // Atualizar o pais existente
                    Pais paisAtualizado = new Pais()
                    {
                        IdPais = paisIdSelecionado.Value,
                        Pais_nome = descricao
                    };

                    paisDAO.Update(paisAtualizado);
                    MessageBox.Show("Pais atualizado com sucesso!");
                }
                else
                {
                    // Adicionar novo pais
                    Pais novoPais = new Pais()
                    {
                        Pais_nome = descricao
                    };

                    paisDAO.Add(novoPais);
                    MessageBox.Show("Pais salvo com sucesso!");
                }

                // Limpar o TextBox
                txtPais.Text = string.Empty;
                txtPais.Enabled = false;
                paisIdSelecionado = null;

                // Recarregar os dados no DataGridView após salvar
                CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar pais: {ex.Message}");
            }
        }

        private int? paisIdSelecionado = null;

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtPais.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                if (paisIdSelecionado.HasValue)
                {
                    // Excluir o Pais
                    Pais paisAtualizado = new Pais()
                    {
                        IdPais = paisIdSelecionado.Value,
                        Pais_nome = descricao
                    };

                    paisDAO.Delete(paisAtualizado);
                    MessageBox.Show("Pais Excluído com sucesso!");

                    // Limpar o TextBox
                    txtPais.Text = string.Empty;
                    txtPais.Enabled = false;
                    paisIdSelecionado = null;

                    // Recarregar os dados no DataGridView após salvar
                    CarregarDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Excluir pais: {ex.Message}");
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtPais.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                var pais = paisDAO.GetByPais(descricao);

                if (pais != null)
                {
                    // Se o pais for encontrado, mostrar os dados no DataGridView
                    DataTable dataTable = paisDAO.GetPaisAsDataTable(descricao);
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("País não encontrado.");
                }

                txtPais.Text = string.Empty;
                txtPais.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar pais: {ex.Message}");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPais.Clear();
            txtPais.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private PaisDAO paisDAO = new PaisDAO();
        private void CarregarDados()
        {
            try
            {
                DataTable dataTable = paisDAO.GetAll();
                dataGridView1.DataSource = dataTable;
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
                // Obter o ID do pais selecionado no DataGridView
                paisIdSelecionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Obter a descrição do pais e carregar no TextBox
                string descricao = dataGridView1.SelectedRows[0].Cells["País"].Value.ToString();
                txtPais.Text = descricao;

                txtPais.Enabled = true;
            }
            else
            {
                MessageBox.Show("Selecione um país para editar.");
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
