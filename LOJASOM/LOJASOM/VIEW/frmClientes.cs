using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOJASOM
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Cliente dalClientes = new CAMADAS.DAL.Cliente();
            dgvClientes.DataSource = "";
            dgvClientes.DataSource = dalClientes.Select();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Cliente cliente = new CAMADAS.MODEL.Cliente();
            cliente.nome = txtNome.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.telefone = txtTelefone.Text;

            CAMADAS.DAL.Cliente dalCli = new CAMADAS.DAL.Cliente();
            dalCli.Insert(cliente);

            dgvClientes.DataSource = "";
            dgvClientes.DataSource = dalCli.Select();

            txtNome.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dgvClientes.SelectedRows[0].Cells["id"].Value.ToString();
            txtNome.Text = dgvClientes.SelectedRows[0].Cells["nome"].Value.ToString();
            txtEndereco.Text = dgvClientes.SelectedRows[0].Cells["endereco"].Value.ToString();
            txtTelefone.Text = dgvClientes.SelectedRows[0].Cells["telefone"].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Cliente cliente = new CAMADAS.MODEL.Cliente();
            cliente.id = Convert.ToInt32(lblId.Text);
            cliente.nome = txtNome.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.telefone = txtTelefone.Text;

            CAMADAS.DAL.Cliente dalCli = new CAMADAS.DAL.Cliente();
            dalCli.Update(cliente);

            dgvClientes.DataSource = "";
            dgvClientes.DataSource = dalCli.Select();

            lblId.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lblId.Text != "")
            {
                int id = Convert.ToInt32(lblId.Text);
                CAMADAS.DAL.Cliente dalCli = new CAMADAS.DAL.Cliente();
                dalCli.Delete(id);

                dgvClientes.DataSource = "";
                dgvClientes.DataSource = dalCli.Select();

                lblId.Text = "";
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtTelefone.Text = "";
            }
            else MessageBox.Show("Sem Registro para remover...");
        }
    }
}
