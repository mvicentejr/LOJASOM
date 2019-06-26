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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void habilitar(bool status)
        {
            txtDescricao.Enabled = status;
            txtQuantidade.Enabled = status;
            txtMarca.Enabled = status;
            txtPreco.Enabled = status;
            dgvProdutos.Enabled = !status;

            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = status;
            btnSair.Enabled = true;
        }

        private void limpar()
        {
            lblId.Text = "";
            txtDescricao.Text = "";
            txtMarca.Text = "";
            txtQuantidade.Text = "";
            txtPreco.Text = "";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            limpar();
            lblId.Text = "-1";
            habilitar(true);
            txtDescricao.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblId.Text.Length > 0)
            {
                habilitar(true);
                txtDescricao.Focus();
            }
            else MessageBox.Show("Sem registros para Editar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = bllProd.Select();

            habilitar(false);
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            lblId.Text = dgvProdutos.SelectedRows[0].Cells["id"].Value.ToString();
            txtDescricao.Text = dgvProdutos.SelectedRows[0].Cells["descricao"].Value.ToString();
            txtMarca.Text = dgvProdutos.SelectedRows[0].Cells["marca"].Value.ToString();
            txtQuantidade.Text = dgvProdutos.SelectedRows[0].Cells["quantidade"].Value.ToString();
            txtPreco.Text = dgvProdutos.SelectedRows[0].Cells["preco"].Value.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lblId.Text.Length > 0)
            {
                DialogResult result;
                result = MessageBox.Show("Confirma Remoção", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblId.Text);
                    bllProd.Delete(id);
                }

                limpar();
                dgvProdutos.DataSource = "";
                dgvProdutos.DataSource = bllProd.Select();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
            int id = Convert.ToInt32(lblId.Text);
            string texto, tipo;
            if (id < 0)
            {
                texto = "Confirma Inclusão?";
                tipo = "Incluir";
            }
            else
            {
                texto = "Confirma Atualização?";
                tipo = "Atualizar";
            }
            DialogResult result;
            result = MessageBox.Show(texto, tipo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                CAMADAS.MODEL.Produto produto = new CAMADAS.MODEL.Produto();
                produto.id = Convert.ToInt32(lblId.Text);
                produto.descricao = txtDescricao.Text;
                produto.marca = txtMarca.Text;
                produto.quantidade = Convert.ToSingle(txtQuantidade.Text);
                produto.preco = Convert.ToSingle(txtPreco.Text);

                if (id < 0)
                    bllProd.Insert(produto);
                else bllProd.Update(produto);
            }
            else MessageBox.Show("Dados não gravados", tipo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar();
            habilitar(false);

            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = bllProd.Select();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
            habilitar(false);
            MessageBox.Show("Dados cancelados", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblTexto.Visible = false;
            txtPesquisa.Visible = false;
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = bllProd.Select();
        }

        private void rdbId_CheckedChanged(object sender, EventArgs e)
        {
            lblTexto.Text = "Informe o ID: ";
            lblTexto.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            txtPesquisa.Focus();
        }

        private void rdbDescricao_CheckedChanged(object sender, EventArgs e)
        {
            lblTexto.Text = "Informe a Descrição: ";
            lblTexto.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            txtPesquisa.Focus();
        }

        private void rdbMarca_CheckedChanged(object sender, EventArgs e)
        {
            lblTexto.Text = "Informe a Marca: ";
            lblTexto.Visible = true;
            txtPesquisa.Text = "";
            txtPesquisa.Visible = true;
            txtPesquisa.Focus();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<CAMADAS.MODEL.Produto> lstProdutos = new List<CAMADAS.MODEL.Produto>();
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();

            if (rdbTodos.Checked)
                lstProdutos = bllProd.Select();
            else if (rdbId.Checked)
            {
                int id = (txtPesquisa.Text != "") ? Convert.ToInt32(txtPesquisa.Text) : 0;
                lstProdutos = bllProd.SelectById(id);
            }
            else if (rdbDescricao.Checked)
                lstProdutos = bllProd.SelectByDescricao(txtPesquisa.Text);
            else if (rdbMarca.Checked)
                lstProdutos = bllProd.SelectByMarca(txtPesquisa.Text);

            dgvProdutos.DataSource = "";
            dgvProdutos.DataSource = lstProdutos;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
