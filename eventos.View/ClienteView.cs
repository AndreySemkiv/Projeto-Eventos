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
    public partial class frmClienteView : Form
    {
        String mensagem = "";

        public frmClienteView()
        {
            InitializeComponent();
            txtNome.Enabled = false;
            mskCpf.Enabled = false;
            txtEmail.Enabled = false;
            mskCelular.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            mskCep.Enabled = false;
            txtBairroCliente.Enabled = false;
            txtCidadeCliente.Enabled = false;
            txtIdRua.Enabled = false;
            CarregarDados();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            mskCpf.Enabled = true;
            txtEmail.Enabled = true;
            mskCelular.Enabled = true;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = true;
            mskCep.Enabled = true;
            txtBairroCliente.Enabled = false;
            txtCidadeCliente.Enabled = false;
            txtIdRua.Enabled = false;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            mskCpf.Enabled = false;
            txtEmail.Enabled = false;
            mskCelular.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            mskCep.Enabled = false;
            txtBairroCliente.Enabled = false;
            txtCidadeCliente.Enabled = false;
            txtIdRua.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtNome.Text;
                string cpf = mskCpf.Text;
                string email = txtEmail.Text;
                string celular = mskCelular.Text;
                string numero = txtNumero.Text;
                string cep = mskCep.Text;
                string idrua = txtIdRua.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("O Nome é obrigatório.");
                    return;
                }

                if (string.IsNullOrEmpty(cpf))
                {
                    MessageBox.Show("O CPF é obrigatório.");
                    return;
                }

                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("O E-mail é obrigatório.");
                    return;
                }

                if (string.IsNullOrEmpty(celular))
                {
                    MessageBox.Show("O Celular é obrigatório.");
                    return;
                }

                if (string.IsNullOrEmpty(idrua))
                {
                    MessageBox.Show("O Endereço é obrigatório.");
                    return;
                }

                if (string.IsNullOrEmpty(numero))
                {
                    MessageBox.Show("O Número da Residência é obrigatório.");
                    return;
                }

                if (string.IsNullOrEmpty(cep))
                {
                    MessageBox.Show("O CEP é obrigatório.");
                    return;
                }

                if (clienteIdSelecionado.HasValue)
                {
                    // Atualizar o cliente existente
                    Cliente clienteAtualizado = new Cliente()
                    {
                        IdCliente = clienteIdSelecionado.Value,
                        Nome = descricao,
                        Cpf = cpf,
                        Email = email,
                        Celular = celular,
                        Cep = cep,
                        NumResidencia = Convert.ToInt32(numero),
                        IdRua = Convert.ToInt32(idrua)
                    };

                    clienteDao.Update(clienteAtualizado);
                    MessageBox.Show("Cliente atualizado com sucesso!");
                }
                else
                {
                    // Adicionar novo cliente
                    Cliente novoCliente = new Cliente()
                    {
                        Nome = descricao,
                        Cpf = cpf,
                        Email = email,
                        Celular = celular,
                        NumResidencia = Convert.ToInt32(numero),
                        Cep = cep,
                        IdRua = Convert.ToInt32(idrua)
                    };

                    clienteDao.Add(novoCliente);
                    MessageBox.Show("Cliente salvo com sucesso!");
                }

                // Limpar o TextBox
                txtNome.Text = string.Empty;
                txtNome.Enabled = false;
                mskCpf.Text = string.Empty;
                mskCpf.Enabled = false;
                txtEmail.Text = string.Empty;
                txtEmail.Enabled = false;
                mskCelular.Text = string.Empty;
                mskCelular.Enabled = false;
                txtEndereco.Text = string.Empty;
                txtEndereco.Enabled = false;
                txtNumero.Text = string.Empty;
                txtNumero.Enabled = false;
                mskCep.Text = string.Empty;
                mskCep.Enabled = false;
                txtBairroCliente.Text = string.Empty;
                txtBairroCliente.Enabled = false;
                txtCidadeCliente.Text = string.Empty;
                txtCidadeCliente.Enabled = false;
                txtIdRua.Text = string.Empty;
                txtIdRua.Enabled = false;
                clienteIdSelecionado = null;

                // Recarregar os dados no DataGridView após salvar
                CarregarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar cliente: {ex.Message}");
            }
        }

        private int? clienteIdSelecionado = null;

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtNome.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                if (clienteIdSelecionado.HasValue)
                {
                    // Excluir o Cliente
                    Cliente clienteAtualizado = new Cliente()
                    {
                        IdCliente = clienteIdSelecionado.Value,
                        Nome = descricao,
                    };

                    clienteDao.Delete(clienteAtualizado);
                    MessageBox.Show("Cliente Excluído com sucesso!");

                    // Limpar o TextBox
                    txtNome.Text = string.Empty;
                    txtNome.Enabled = false;
                    mskCpf.Text = string.Empty;
                    mskCpf.Enabled = false;
                    txtEmail.Text = string.Empty;
                    txtEmail.Enabled = false;
                    mskCelular.Text = string.Empty;
                    mskCelular.Enabled = false;
                    txtEndereco.Text = string.Empty;
                    txtEndereco.Enabled = false;
                    txtNumero.Text = string.Empty;
                    txtNumero.Enabled = false;
                    mskCep.Text = string.Empty;
                    mskCep.Enabled = false;
                    txtBairroCliente.Text = string.Empty;
                    txtBairroCliente.Enabled = false;
                    txtCidadeCliente.Text = string.Empty;
                    txtCidadeCliente.Enabled = false;
                    txtIdRua.Text = string.Empty;
                    txtIdRua.Enabled = false;
                    clienteIdSelecionado = null;

                    // Recarregar os dados no DataGridView após salvar
                    CarregarDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Excluir cliente: {ex.Message}");
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtNome.Text;

                if (string.IsNullOrEmpty(descricao))
                {
                    MessageBox.Show("A descrição é obrigatória.");
                    return;
                }

                var cliente = clienteDao.GetByCliente(descricao);

                if (cliente != null)
                {
                    // Se o cliente for encontrado, mostrar os dados no DataGridView
                    DataTable dataTable = clienteDao.GetClienteAsDataTable(descricao);
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado.");
                }

                // Limpar o TextBox
                txtNome.Text = string.Empty;
                txtNome.Enabled = false;
                mskCpf.Text = string.Empty;
                mskCpf.Enabled = false;
                txtEmail.Text = string.Empty;
                txtEmail.Enabled = false;
                mskCelular.Text = string.Empty;
                mskCelular.Enabled = false;
                txtEndereco.Text = string.Empty;
                txtEndereco.Enabled = false;
                txtNumero.Text = string.Empty;
                txtNumero.Enabled = false;
                mskCep.Text = string.Empty;
                mskCep.Enabled = false;
                txtBairroCliente.Text = string.Empty;
                txtBairroCliente.Enabled = false;
                txtCidadeCliente.Text = string.Empty;
                txtCidadeCliente.Enabled = false;
                txtIdRua.Text = string.Empty;
                txtIdRua.Enabled = false;
                clienteIdSelecionado = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar cliente: {ex.Message}");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpar o TextBox
            txtNome.Text = string.Empty;
            txtNome.Enabled = false;
            mskCpf.Text = string.Empty;
            mskCpf.Enabled = false;
            txtEmail.Text = string.Empty;
            txtEmail.Enabled = false;
            mskCelular.Text = string.Empty;
            mskCelular.Enabled = false;
            txtEndereco.Text = string.Empty;
            txtEndereco.Enabled = false;
            txtNumero.Text = string.Empty;
            txtNumero.Enabled = false;
            mskCep.Text = string.Empty;
            mskCep.Enabled = false;
            txtBairroCliente.Text = string.Empty;
            txtBairroCliente.Enabled = false;
            txtCidadeCliente.Text = string.Empty;
            txtCidadeCliente.Enabled = false;
            txtIdRua.Text = string.Empty;
            txtIdRua.Enabled = false;
            clienteIdSelecionado = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Carrega dados no GRID
        private ClienteDAO clienteDao = new ClienteDAO();
        //private ClienteDAO clienteDAO = new ClienteDAO();
        private void CarregarDados()
        {
            try
            {
                DataTable dataTable = clienteDao.GetAll();
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
                // Obter o ID do cliente selecionado no DataGridView
                clienteIdSelecionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Obter a descrição do cliente e carregar no TextBox
                string nome = dataGridView1.SelectedRows[0].Cells["Nome"].Value.ToString();
                string cpf = dataGridView1.SelectedRows[0].Cells["CPF"].Value.ToString();
                string email = dataGridView1.SelectedRows[0].Cells["E_mail"].Value.ToString();
                string celular = dataGridView1.SelectedRows[0].Cells["Celular"].Value.ToString();
                string cep = dataGridView1.SelectedRows[0].Cells["CEP"].Value.ToString();
                string num_residencia = dataGridView1.SelectedRows[0].Cells["Nº"].Value.ToString();
                string endereco = dataGridView1.SelectedRows[0].Cells["Endereço"].Value.ToString();
                string bairro = dataGridView1.SelectedRows[0].Cells["Bairro"].Value.ToString();
                string cidade = dataGridView1.SelectedRows[0].Cells["Cidade"].Value.ToString();
                string id_rua = dataGridView1.SelectedRows[0].Cells["Id_Rua"].Value.ToString();

                txtNome.Text = nome;
                mskCpf.Text = cpf;
                txtEmail.Text = email;
                mskCelular.Text = celular;
                mskCep.Text = cep;
                txtNumero.Text = num_residencia;
                txtEndereco.Text = endereco;
                txtBairroCliente.Text = bairro;
                txtCidadeCliente.Text = cidade;
                txtIdRua.Text = id_rua;

                txtNome.Enabled = true;
                mskCpf.Enabled = true;
                txtEmail.Enabled = true;
                mskCelular.Enabled = true;
                mskCep.Enabled = true;
                txtNumero.Enabled = true;
                txtEndereco.Enabled = false;
                txtBairroCliente.Enabled = false;
                txtCidadeCliente.Enabled = false;
                txtIdRua.Enabled = false;
            }
            else
            {
                MessageBox.Show("Selecione um cliente para editar.");
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNome.Enabled = false;

            frmClienteView add = new frmClienteView();
            add.ShowDialog();
        }

        private RuaDAO ruaDAO = new RuaDAO();

        public ClienteDAO ClienteDAO { get => clienteDao; set => clienteDao = value; }

        private void btnBuscaCep_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = mskCep.Text.Trim();

                if (string.IsNullOrEmpty(cep))
                {
                    MessageBox.Show("O CEP é obrigatório.");
                    return;
                }

                // Busca o endereço pelo CEP
                var rua = ruaDAO.GetByCep(cep);

                if (rua != null)
                {
                    // Preenche os campos com os dados retornados
                    txtEndereco.Text = rua.Rua_nome;
                    txtBairroCliente.Text = rua.Bairro_nome;
                    txtCidadeCliente.Text = rua.Cidade_nome;
                    txtIdRua.Text = rua.IdRua.ToString();
                }
                else
                {
                    MessageBox.Show("Endereço não encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar Endereço: {ex.Message}");
            }
        }

        private void btnAddEndereco_Click(object sender, EventArgs e)
        {
            frmRuaView add = new frmRuaView();
            add.ShowDialog();
        }
    }
}