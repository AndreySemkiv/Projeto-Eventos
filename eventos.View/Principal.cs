using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos.View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteView add = new frmClienteView();
            add.ShowDialog();
        }

        private void temasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTemaView add = new frmTemaView();
            add.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoriaView add = new frmCategoriaView();
            add.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void produtosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProdutoView add = new frmProdutoView();
            add.ShowDialog();
        }
    }
}
