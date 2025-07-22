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
    public partial class frmTemaView : Form
    {
        String mensagem = "";

        public frmTemaView()
        {
            InitializeComponent();
            txtTema.Enabled = false;
            CarregarDados();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtTema.Enabled = true;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            txtTema.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtTema.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                if (temaIdSelecionado.HasValue)
                {
                    // Atualizar o tema existente
                    Tema temaAtualizado = new Tema()
                    {
                        IdTema = temaIdSelecionado.Value,
                        Tema_nome = descricao
                    };

                    temaDAO.Update(temaAtualizado);
                    MessageBox.Show("Tema atualizado com sucesso!");
                }
                else
                {
                    // Adicionar novo tema
                    Tema novoTema = new Tema()
                    {
                        Tema_nome = descricao
                    };

                    temaDAO.Add(novoTema);
                    MessageBox.Show("Tema salvo com sucesso!");
                }

                // Limpar o TextBox
                txtTema.Text = string.Empty;
                txtTema.Enabled = false;
                temaIdSelecionado = null;

                // Recarregar os dados no DataGridView após salvar
                CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar tema: {ex.Message}");
            }
        }

        private int? temaIdSelecionado = null;

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtTema.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                if (temaIdSelecionado.HasValue)
                {
                    // Excluir o Tema
                    Tema temaAtualizado = new Tema()
                    {
                        IdTema = temaIdSelecionado.Value,
                        Tema_nome = descricao
                    };

                    temaDAO.Delete(temaAtualizado);
                    MessageBox.Show("Tema Excluído com sucesso!");

                    // Limpar o TextBox
                    txtTema.Text = string.Empty;
                    txtTema.Enabled = false;
                    temaIdSelecionado = null;

                    // Recarregar os dados no DataGridView após salvar
                    CarregarDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Excluir tema: {ex.Message}");
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtTema.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                var tema = temaDAO.GetByTema(descricao);

                if (tema != null)
                {
                    // Se o tema for encontrado, mostrar os dados no DataGridView
                    DataTable dataTable = temaDAO.GetTemaAsDataTable(descricao);
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Tema não encontrado.");
                }

                txtTema.Text = string.Empty;
                txtTema.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar tema: {ex.Message}");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTema.Clear();
            txtTema.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private TemaDAO temaDAO = new TemaDAO();
        private void CarregarDados()
        {
            try
            {
                DataTable dataTable = temaDAO.GetAll();
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
                // Obter o ID do tema selecionado no DataGridView
                temaIdSelecionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Obter a descrição do tema e carregar no TextBox
                string descricao = dataGridView1.SelectedRows[0].Cells["Tema"].Value.ToString();
                txtTema.Text = descricao;

                txtTema.Enabled = true;
            }
            else
            {
                MessageBox.Show("Selecione um tema para editar.");
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
