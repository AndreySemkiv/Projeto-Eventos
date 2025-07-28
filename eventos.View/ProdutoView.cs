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
using Google.Protobuf.WellKnownTypes;

namespace Eventos.View
{
    public partial class frmProdutoView : Form
    {
        String mensagem = "";

        public frmProdutoView()
        {
            InitializeComponent();
            txtProduto.Enabled = false;
            txtTamanho.Enabled = false;
            txtAluguel.Enabled = false;
            txtQuantidade.Enabled = false;
            txtCusto.Enabled = false;
            cbbCategoria.Enabled = false;
            cbbCor.Enabled = false;
            cbbTema.Enabled = false;

            CarregarDados();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtProduto.Enabled = true;
            txtTamanho.Enabled = true;
            txtAluguel.Enabled = true;
            txtQuantidade.Enabled = true;
            txtCusto.Enabled = true;
            cbbCategoria.Enabled = true;
            CarregarCategoria();
            CarregarCor();
            cbbCor.Enabled = true;
            cbbTema.Enabled = true;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            txtProduto.Enabled = true;
            txtTamanho.Enabled = false;
            txtAluguel.Enabled = false;
            txtQuantidade.Enabled = false;
            txtCusto.Enabled = false;
            cbbCategoria.Enabled = false;
            cbbCor.Enabled = false;
            cbbTema.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtProduto.Text;
                string tamanho = txtTamanho.Text;
                string aluguel = txtAluguel.Text;
                string quantidade = txtQuantidade.Text;
                string custo = txtCusto.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A Descrição é obrigatória.");
                    return;
                }

                if (string.IsNullOrEmpty(tamanho))
                {
                    MessageBox.Show("O Tamanho é obrigatório.");
                    return;
                }

                if (string.IsNullOrEmpty(aluguel))
                {
                    MessageBox.Show("O Valor do Aluguel é obrigatório.");
                    return;
                }

                if (string.IsNullOrEmpty(quantidade))
                {
                    MessageBox.Show("A Quantidade é obrigatória.");
                    return;
                }

                if (string.IsNullOrEmpty(custo))
                {
                    MessageBox.Show("O Custo é obrigatório.");
                    return;
                }

                if (produtoIdSelecionado.HasValue)
                {
                    // Atualizar o produto existente
                    Produto produtoAtualizado = new Produto()
                    {
                        IdProduto = produtoIdSelecionado.Value,
                        Descricao = descricao,
                        Tamanho = tamanho,
                        Valor = Convert.ToDouble(aluguel),
                        Quantidade = Convert.ToDouble(quantidade),
                        Custo = Convert.ToDouble(custo),
                        IdCategoria = cbbCategoria.SelectedValue.GetHashCode(),
                        IdCor = cbbCor.SelectedValue.GetHashCode(),
                        IdTema = cbbTema.SelectedValue.GetHashCode()
                    };

                    produtoDAO.Update(produtoAtualizado);
                    MessageBox.Show("Produto atualizado com sucesso!");
                }
                else
                {
                    // Adicionar novo produto
                    Produto novoProduto = new Produto()
                    {
                        Descricao = descricao,
                        Tamanho = tamanho,
                        Valor = Convert.ToDouble(aluguel),
                        Quantidade = Convert.ToDouble(quantidade),
                        Custo = Convert.ToDouble(custo),
                        IdCategoria = cbbCategoria.SelectedValue.GetHashCode(),
                        IdCor = cbbCor.SelectedValue.GetHashCode(),
                        IdTema = cbbTema.SelectedValue.GetHashCode()
                    };

                    produtoDAO.Add(novoProduto);
                    MessageBox.Show("Produto salvo com sucesso!");
                }

                // Limpar o TextBox
                txtProduto.Enabled = false;
                txtProduto.Text = string.Empty;
                txtTamanho.Enabled = false;
                txtTamanho.Text = string.Empty;
                txtAluguel.Enabled = false;
                txtAluguel.Text = string.Empty;
                txtQuantidade.Enabled = false;
                txtQuantidade.Text = string.Empty;
                txtCusto.Enabled = false;
                txtCusto.Text = string.Empty;
                cbbCategoria.Enabled = false;
                cbbCategoria.Text = string.Empty;
                cbbCor.Enabled = false;
                cbbCor.Text = string.Empty;
                cbbTema.Enabled = false;
                cbbTema.Text = string.Empty;
                produtoIdSelecionado = null;

                // Recarregar os dados no DataGridView após salvar
                CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar produto: {ex.Message}");
            }
        }

        private int? produtoIdSelecionado = null;

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtProduto.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                if (produtoIdSelecionado.HasValue)
                {
                    // Excluir o Produto
                    Produto produtoAtualizado = new Produto()
                    {
                        IdProduto = produtoIdSelecionado.Value,
                        Descricao = descricao,
                    };

                    produtoDAO.Delete(produtoAtualizado);
                    MessageBox.Show("Produto Excluído com sucesso!");

                    // Limpar o TextBox
                    txtProduto.Enabled = false;
                    txtProduto.Text = string.Empty;
                    txtTamanho.Enabled = false;
                    txtTamanho.Text = string.Empty;
                    txtAluguel.Enabled = false;
                    txtAluguel.Text = string.Empty;
                    txtQuantidade.Enabled = false;
                    txtQuantidade.Text = string.Empty;
                    txtCusto.Enabled = false;
                    txtCusto.Text = string.Empty;
                    cbbCategoria.Enabled = false;
                    cbbCategoria.Text = string.Empty;
                    cbbCor.Enabled = false;
                    cbbCor.Text = string.Empty;
                    cbbTema.Enabled = false;
                    cbbTema.Text = string.Empty;
                    produtoIdSelecionado = null;

                    // Recarregar os dados no DataGridView após salvar
                    CarregarDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Excluir produto: {ex.Message}");
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtProduto.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                var produto = produtoDAO.GetByProduto(descricao);

                if (produto != null)
                {
                    // Se o produto for encontrado, mostrar os dados no DataGridView
                    DataTable dataTable = produtoDAO.GetProdutoAsDataTable(descricao);
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.");
                }

                // Limpar o TextBox
                txtProduto.Enabled = false;
                txtProduto.Text = string.Empty;
                txtTamanho.Enabled = false;
                txtTamanho.Text = string.Empty;
                txtAluguel.Enabled = false;
                txtAluguel.Text = string.Empty;
                txtQuantidade.Enabled = false;
                txtQuantidade.Text = string.Empty;
                txtCusto.Enabled = false;
                txtCusto.Text = string.Empty;
                cbbCategoria.Enabled = false;
                cbbCategoria.Text = string.Empty;
                cbbCor.Enabled = false;
                cbbCor.Text = string.Empty;
                cbbTema.Enabled = false;
                cbbTema.Text = string.Empty;
                produtoIdSelecionado = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produto: {ex.Message}");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar o TextBox
            txtProduto.Enabled = false;
            txtProduto.Text = string.Empty;
            txtTamanho.Enabled = false;
            txtTamanho.Text = string.Empty;
            txtAluguel.Enabled = false;
            txtAluguel.Text = string.Empty;
            txtQuantidade.Enabled = false;
            txtQuantidade.Text = string.Empty;
            txtCusto.Enabled = false;
            txtCusto.Text = string.Empty;
            cbbCategoria.Enabled = false;
            cbbCategoria.Text = string.Empty;
            cbbCor.Enabled = false;
            cbbCor.Text = string.Empty;
            cbbTema.Enabled = false;
            cbbTema.Text = string.Empty;
            produtoIdSelecionado = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Carrega dados no GRID
        private ProdutoDAO produtoDAO = new ProdutoDAO();
        private void CarregarDados()
        {
            try
            {
                DataTable dataTable = produtoDAO.GetAll();
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}");
            }
        }

        // Carrega dados no ComboBox
        private CategoriaDAO categoriaDAO = new CategoriaDAO();
        private void CarregarCategoria()
        {
            try
            {
                // Obtém os dados do banco de dados usando o EstadoDAO
                DataTable dataTable = corDAO.GetAll();

                // Verifica se as colunas necessárias estão presentes
                if (dataTable.Columns.Contains("Categoria") && dataTable.Columns.Contains("Id"))
                {
                    cbbCategoria.DataSource = dataTable;
                    cbbCategoria.DisplayMember = "Categoria";
                    cbbCategoria.ValueMember = "Id";
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

        // aguardando criar as classes de cor
        //paramos aqui

        // Carrega dados no ComboBox
        private CorDAO corDAO = new CorDAO();
        private void CarregarCor()
        {
            try
            {
                // Obtém os dados do banco de dados usando o corDAO
                DataTable dataTable = corDAO.GetAll();

                // Verifica se as colunas necessárias estão presentes
                if (dataTable.Columns.Contains("Cor") && dataTable.Columns.Contains("Id") && dataTable.Columns.Contains("Cod_Cor"))
                {
                    cbbCor.DataSource = dataTable;
                    cbbCor.DisplayMember = "Cor";
                    cbbCor.ValueMember = "Id";
                    cbbCor.DisplayMember = "Cod_Cor";
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
                // Obter o ID do produto selecionado no DataGridView
                produtoIdSelecionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Obter a descrição do produto e carregar no TextBox
                string descricao = dataGridView1.SelectedRows[0].Cells["Descrição"].Value.ToString();
                string tamanho = dataGridView1.SelectedRows[0].Cells["Tamanho"].Value.ToString();
                string valor = dataGridView1.SelectedRows[0].Cells["R$ Aluguel"].Value.ToString();
                string quantidade = dataGridView1.SelectedRows[0].Cells["Quantidade"].Value.ToString();
                string custo = dataGridView1.SelectedRows[0].Cells["R$ Custo"].Value.ToString();
                string categoria = dataGridView1.SelectedRows[0].Cells["Categoria"].Value.ToString();
                string cor = dataGridView1.SelectedRows[0].Cells["Cor"].Value.ToString();
                string tema = dataGridView1.SelectedRows[0].Cells["Tema"].Value.ToString();

                txtProduto.Text = descricao;
                txtTamanho.Text = tamanho;
                txtAluguel.Text = valor;
                txtQuantidade.Text = quantidade;
                txtCusto.Text = custo;
                cbbCategoria.Text = categoria;
                cbbCor.Text = cor;
                cbbTema.Text = tema;

                txtProduto.Enabled = true;
                txtTamanho.Enabled = true;
                txtAluguel.Enabled = true;
                txtQuantidade.Enabled = true;
                txtCusto.Enabled = true;
                cbbCategoria.Enabled = true;
                cbbCor.Enabled = true;
                cbbTema.Enabled = true;
            }
            else
            {
                MessageBox.Show("Selecione um produto para editar.");
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            txtProduto.Clear();
            txtProduto.Enabled = false;

            frmProdutoView add = new frmProdutoView();
            add.ShowDialog();
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            frmCategoriaView add = new frmCategoriaView();
            add.ShowDialog();
        }

        private void btnAddTema_Click(object sender, EventArgs e)
        {
            frmTemaView add = new frmTemaView();
            add.ShowDialog();
        }

        private void btnAddCor_Click(object sender, EventArgs e)
        {
            frmCorView add = new frmCorView();
            add.ShowDialog();
        }
    }
}