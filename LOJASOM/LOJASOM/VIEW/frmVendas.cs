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
    public partial class frmVendas : Form
    {
        public CAMADAS.MODEL.Produto produto { get; set; }

        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            //Combo Cliente
            CAMADAS.DAL.Cliente dalCli = new CAMADAS.DAL.Cliente();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = dalCli.Select();

            //Combo Produtos
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
            cmbProduto.DisplayMember = "descricao";
            cmbProduto.ValueMember = "id";
            cmbProduto.DataSource = bllProd.Select();

            //DataGridView de Vendas
            CAMADAS.BLL.Venda bllVenda = new CAMADAS.BLL.Venda();
            dgvVendas.DataSource = "";
            List<CAMADAS.MODEL.Venda> lstVenda = new List<CAMADAS.MODEL.Venda>();
            lstVenda = bllVenda.Select();
            dgvVendas.DataSource = lstVenda;

            //carregar datagridview ItemVenda
            CAMADAS.BLL.ItemVenda bllItemVenda = new CAMADAS.BLL.ItemVenda();
            dgvItemVenda.DataSource = "";
            dgvItemVenda.DataSource = bllItemVenda.Select();
        }

        private void limpaCamposVenda()
        {
            lblIdVenda.Text = "";
            dtpData.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            txtIdCliente.Text = "0";
            cmbCliente.SelectedValue = 0;
        }

        private void limpaCamposItemVenda()
        {
            lblVenda.Text = "";
            lblIdItemVenda.Text = "";
            txtIdProd.Text = "0";
            txtQuantidade.Text = "";
            txtValor.Text = "";
            cmbProduto.SelectedValue = 0;
        }

        void recuperaProduto(int idProd)
        {
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
            List<CAMADAS.MODEL.Produto> lstProdutos = bllProd.SelectById(idProd);
            if (lstProdutos != null)
                produto = lstProdutos[0];
            else produto = null;
        }

        void calculaTotal()
        {
            float qtde = (txtQuantidade.Text == string.Empty) ? 0 : Convert.ToSingle(txtQuantidade.Text);
            float valor = (txtValor.Text == string.Empty) ? 0 : Convert.ToSingle(txtValor.Text);
            float total = qtde * valor;
            lblTotal.Text = string.Format("{0:0.00}", total);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblIdItemVenda_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpaCamposVenda();
            lblIdVenda.Text = "-1";
            dtpData.Focus();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtIdCliente.Text = cmbCliente.SelectedValue.ToString();
            }
            catch { }

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cmbCliente.SelectedValue = Convert.ToInt32(txtIdCliente.Text);
            }
            catch { }
        }

        private void txtIdCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbCliente.SelectedValue = Convert.ToInt32(txtIdCliente.Text);
            }
            catch { }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Venda bllVenda = new CAMADAS.BLL.Venda();
            int id = Convert.ToInt32(lblIdVenda.Text);
            if (id == -1)
            {
                CAMADAS.MODEL.Venda venda = new CAMADAS.MODEL.Venda();
                venda.id = id;
                venda.data = dtpData.Value;
                venda.cliente = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
                bllVenda.Insert(venda);
            }
            dgvVendas.DataSource = "";
            dgvVendas.DataSource = bllVenda.Select();
            limpaCamposVenda();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCamposVenda();
        }

        private void dgvVendas_DoubleClick(object sender, EventArgs e)
        {
            lblIdVenda.Text = dgvVendas.SelectedRows[0].Cells["id"].Value.ToString();
            dtpData.Value = Convert.ToDateTime(dgvVendas.SelectedRows[0].Cells["data"].Value.ToString());
            cmbCliente.SelectedValue = Convert.ToInt32(dgvVendas.SelectedRows[0].Cells["cliente"].Value.ToString());

            // recuperando itens da venda
            CAMADAS.BLL.ItemVenda bllItemVenda = new CAMADAS.BLL.ItemVenda();
            int idVenda = Convert.ToInt32(lblIdVenda.Text);
            dgvItemVenda.DataSource = "";
            dgvItemVenda.DataSource = bllItemVenda.SelectByIdVenda(idVenda);
        }

        private void dgvVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            int idVenda = (lblIdVenda.Text == string.Empty) ? 0 : Convert.ToInt32(lblIdVenda.Text);
            if (idVenda > 0)
            {
                limpaCamposItemVenda();
                lblIdItemVenda.Text = "-1";
                lblVenda.Text = lblIdVenda.Text;
                txtIdProd.Focus();
            }
            else MessageBox.Show("Não há Venda Selecionada!");
        }

        private void btnGravarItem_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.ItemVenda bllItemVenda = new CAMADAS.BLL.ItemVenda();
            CAMADAS.MODEL.ItemVenda itemvenda = new CAMADAS.MODEL.ItemVenda();
            if (lblIdItemVenda.Text == "-1")
            {
                itemvenda.id = Convert.ToInt32(lblIdItemVenda.Text);
                itemvenda.venda = Convert.ToInt32(lblIdVenda.Text);
                itemvenda.produto = Convert.ToInt32(txtIdProd.Text);
                itemvenda.marca = txtMarca.Text;
                itemvenda.quantidade = Convert.ToSingle(txtQuantidade.Text);
                itemvenda.valor = Convert.ToSingle(txtValor.Text);
                bllItemVenda.Insert(itemvenda);
            }

            limpaCamposItemVenda();
            dgvItemVenda.DataSource = "";
            dgvItemVenda.DataSource = bllItemVenda.SelectByIdVenda(itemvenda.venda);
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            limpaCamposItemVenda();
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtIdProd.Text = cmbProduto.SelectedValue.ToString();
            }
            catch { }
        }

        private void txtIdProd_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbCliente.SelectedValue = Convert.ToInt32(txtIdProd.Text);
            }
            catch { }
        }

        private void cmbProduto_Leave(object sender, EventArgs e)
        {
            int idProd = Convert.ToInt32(cmbProduto.SelectedValue);
            recuperaProduto(idProd);
            if (produto != null)
            {
                txtValor.Text = produto.preco.ToString();
                txtMarca.Text = produto.marca.ToString();
            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            if (produto != null)
            {
                float qtde = Convert.ToSingle(txtQuantidade.Text);
                if (qtde > produto.quantidade)
                    MessageBox.Show("Quantidade Insuficiente: " + produto.quantidade.ToString());
                calculaTotal();
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            calculaTotal();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                calculaTotal();
            }
            catch { }
        }

        private void dgvItemVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
