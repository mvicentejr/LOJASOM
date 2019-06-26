namespace LOJASOM.VIEW
{
    partial class frmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblIdVenda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvItemVenda = new System.Windows.Forms.DataGridView();
            this.btnGravarItem = new System.Windows.Forms.Button();
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.lblVenda = new System.Windows.Forms.Label();
            this.lblIdItemVenda = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.dgvVendas);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel1.Controls.Add(this.btnGravar);
            this.splitContainer1.Panel1.Controls.Add(this.btnNovo);
            this.splitContainer1.Panel1.Controls.Add(this.txtIdCliente);
            this.splitContainer1.Panel1.Controls.Add(this.cmbCliente);
            this.splitContainer1.Panel1.Controls.Add(this.dtpData);
            this.splitContainer1.Panel1.Controls.Add(this.lblIdVenda);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainer1.Panel2.Controls.Add(this.txtMarca);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.dgvItemVenda);
            this.splitContainer1.Panel2.Controls.Add(this.btnGravarItem);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelarItem);
            this.splitContainer1.Panel2.Controls.Add(this.btnNovoItem);
            this.splitContainer1.Panel2.Controls.Add(this.txtValor);
            this.splitContainer1.Panel2.Controls.Add(this.txtQuantidade);
            this.splitContainer1.Panel2.Controls.Add(this.cmbProduto);
            this.splitContainer1.Panel2.Controls.Add(this.txtIdProd);
            this.splitContainer1.Panel2.Controls.Add(this.lblVenda);
            this.splitContainer1.Panel2.Controls.Add(this.lblIdItemVenda);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotal);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(1030, 576);
            this.splitContainer1.SplitterDistance = 256;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Vendas";
            // 
            // dgvVendas
            // 
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Location = new System.Drawing.Point(455, 70);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.Size = new System.Drawing.Size(563, 165);
            this.dgvVendas.TabIndex = 12;
            this.dgvVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendas_CellContentClick);
            this.dgvVendas.DoubleClick += new System.EventHandler(this.dgvVendas_DoubleClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.Location = new System.Drawing.Point(316, 200);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 35);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGravar.Location = new System.Drawing.Point(172, 200);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(96, 35);
            this.btnGravar.TabIndex = 9;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.DarkBlue;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNovo.Location = new System.Drawing.Point(28, 200);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(96, 35);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(93, 138);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(65, 26);
            this.txtIdCliente.TabIndex = 7;
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            this.txtIdCliente.Leave += new System.EventHandler(this.txtIdCliente_Leave);
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(164, 136);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(228, 28);
            this.cmbCliente.TabIndex = 6;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(93, 100);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(105, 26);
            this.dtpData.TabIndex = 5;
            // 
            // lblIdVenda
            // 
            this.lblIdVenda.Location = new System.Drawing.Point(89, 70);
            this.lblIdVenda.Name = "lblIdVenda";
            this.lblIdVenda.Size = new System.Drawing.Size(51, 20);
            this.lblIdVenda.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "ID Item: ";
            // 
            // dgvItemVenda
            // 
            this.dgvItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemVenda.Location = new System.Drawing.Point(455, 50);
            this.dgvItemVenda.Name = "dgvItemVenda";
            this.dgvItemVenda.Size = new System.Drawing.Size(563, 208);
            this.dgvItemVenda.TabIndex = 20;
            this.dgvItemVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemVenda_CellContentClick);
            // 
            // btnGravarItem
            // 
            this.btnGravarItem.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGravarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGravarItem.Location = new System.Drawing.Point(674, 266);
            this.btnGravarItem.Name = "btnGravarItem";
            this.btnGravarItem.Size = new System.Drawing.Size(134, 35);
            this.btnGravarItem.TabIndex = 19;
            this.btnGravarItem.Text = "Gravar Item";
            this.btnGravarItem.UseVisualStyleBackColor = false;
            this.btnGravarItem.Click += new System.EventHandler(this.btnGravarItem_Click);
            // 
            // btnCancelarItem
            // 
            this.btnCancelarItem.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCancelarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelarItem.Location = new System.Drawing.Point(872, 266);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Size = new System.Drawing.Size(134, 35);
            this.btnCancelarItem.TabIndex = 18;
            this.btnCancelarItem.Text = "Cancelar Item";
            this.btnCancelarItem.UseVisualStyleBackColor = false;
            this.btnCancelarItem.Click += new System.EventHandler(this.btnCancelarItem_Click);
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.BackColor = System.Drawing.Color.DarkBlue;
            this.btnNovoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNovoItem.Location = new System.Drawing.Point(474, 266);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(134, 35);
            this.btnNovoItem.TabIndex = 17;
            this.btnNovoItem.Text = "Novo Item";
            this.btnNovoItem.UseVisualStyleBackColor = false;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(121, 232);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 26);
            this.txtValor.TabIndex = 16;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(121, 192);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 26);
            this.txtQuantidade.TabIndex = 15;
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(185, 118);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(228, 28);
            this.cmbProduto.TabIndex = 14;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            this.cmbProduto.Leave += new System.EventHandler(this.cmbProduto_Leave);
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(121, 118);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(47, 26);
            this.txtIdProd.TabIndex = 11;
            this.txtIdProd.Leave += new System.EventHandler(this.txtIdProd_Leave);
            // 
            // lblVenda
            // 
            this.lblVenda.Location = new System.Drawing.Point(120, 50);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(51, 20);
            this.lblVenda.TabIndex = 9;
            // 
            // lblIdItemVenda
            // 
            this.lblIdItemVenda.Location = new System.Drawing.Point(120, 84);
            this.lblIdItemVenda.Name = "lblIdItemVenda";
            this.lblIdItemVenda.Size = new System.Drawing.Size(51, 20);
            this.lblIdItemVenda.TabIndex = 8;
            this.lblIdItemVenda.Click += new System.EventHandler(this.lblIdItemVenda_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Valor R$ ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Produto:";
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(117, 272);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(101, 20);
            this.lblTotal.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total R$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Quantidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Venda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Itens Vendidos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(121, 158);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 26);
            this.txtMarca.TabIndex = 23;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1030, 576);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblIdVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvItemVenda;
        private System.Windows.Forms.Button btnGravarItem;
        private System.Windows.Forms.Button btnCancelarItem;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.Label lblIdItemVenda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMarca;
    }
}