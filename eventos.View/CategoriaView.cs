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
    public partial class frmCategoriaView : Form
    {
        String mensagem = "";

        public frmCategoriaView()
        {
            InitializeComponent();
            txtCategoria.Enabled = false;
            CarregarDados();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtCategoria.Enabled = true;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            txtCategoria.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtCategoria.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                if (categoriaIdSelecionado.HasValue)
                {
                    // Atualizar o categoria existente
                    Categoria categoriaAtualizado = new Categoria()
                    {
                        IdCategoria = categoriaIdSelecionado.Value,
                        Categoria_nome = descricao
                    };

                    categoriaDAO.Update(categoriaAtualizado);
                    MessageBox.Show("Categoria atualizada com sucesso!");
                }
                else
                {
                    // Adicionar novo categoria
                    Categoria novoCategoria = new Categoria()
                    {
                        Categoria_nome = descricao
                    };

                    categoriaDAO.Add(novoCategoria);
                    MessageBox.Show("Categoria salvo com sucesso!");
                }

                // Limpar o TextBox
                txtCategoria.Text = string.Empty;
                txtCategoria.Enabled = false;
                categoriaIdSelecionado = null;

                // Recarregar os dados no DataGridView após salvar
                CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar categoria: {ex.Message}");
            }
        }

        private int? categoriaIdSelecionado = null;

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtCategoria.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                if (categoriaIdSelecionado.HasValue)
                {
                    // Excluir o Categoria
                    Categoria categoriaAtualizado = new Categoria()
                    {
                        IdCategoria = categoriaIdSelecionado.Value,
                        Categoria_nome = descricao
                    };

                    categoriaDAO.Delete(categoriaAtualizado);
                    MessageBox.Show("Categoria Excluído com sucesso!");

                    // Limpar o TextBox
                    txtCategoria.Text = string.Empty;
                    txtCategoria.Enabled = false;
                    categoriaIdSelecionado = null;

                    // Recarregar os dados no DataGridView após salvar
                    CarregarDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Excluir categoria: {ex.Message}");
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtCategoria.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                var categoria = categoriaDAO.GetByCategoria(descricao);

                if (categoria != null)
                {
                    // Se o categoria for encontrado, mostrar os dados no DataGridView
                    DataTable dataTable = categoriaDAO.GetCategoriaAsDataTable(descricao);
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Categoria não encontrado.");
                }

                txtCategoria.Text = string.Empty;
                txtCategoria.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar categoria: {ex.Message}");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCategoria.Clear();
            txtCategoria.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private CategoriaDAO categoriaDAO = new CategoriaDAO();
        private void CarregarDados()
        {
            try
            {
                DataTable dataTable = categoriaDAO.GetAll();
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
                // Obter o ID do categoria selecionado no DataGridView
                categoriaIdSelecionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Obter a descrição do categoria e carregar no TextBox
                string descricao = dataGridView1.SelectedRows[0].Cells["Categoria"].Value.ToString();
                txtCategoria.Text = descricao;

                txtCategoria.Enabled = true;
            }
            else
            {
                MessageBox.Show("Selecione um categoria para editar.");
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
