using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOJASOM.VIEW
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmCli = new frmClientes();
            frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSob = new frmSobre();
            frmSob.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos frmProd = new frmProdutos();
            frmProd.MdiParent = this;
            frmProd.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendas frmVenda = new frmVendas();
            frmVenda.MdiParent = this;
            frmVenda.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RELATORIOS.relProdutos.relGeralProdutos();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RELATORIOS.relClientes.relGeralClientes();
        }
    }
}
