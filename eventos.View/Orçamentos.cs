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
    public partial class frmOrcamentoView : Form
    {
        //Em um cenário real, isso viria de uma seleção do usuário.
        private const int ORCAMENTO_ID_PARA_CARREGAR = 1;

        public frmOrcamentoView()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            this.Text = "Orçamento de Eventos - Pedido";
            this.Size = new Size(920, 600);
            this.BackColor = Color.WhiteSmoke;


            TableLayoutPanel mainLayout = new TableLayoutPanel();
        mainLayout.Dock = DockStyle.Fill;
        mainLayout.Pading = new Padding(15);
        mainLayout.ColumnCount = 1;
        mainLayout.RowCount = 5;
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute,130));
      
        mainLayout.Dock = DockStyle.Fill;
        mainLayout.Dock = DockStyle.Fill;
        }
    }
}
