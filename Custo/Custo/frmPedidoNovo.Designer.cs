using System.Windows.Forms;
namespace Custo
{
    partial class frmPedidoNovo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidoNovo));
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.grdNovoPedido = new System.Windows.Forms.DataGridView();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCustoTotal = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grdNovoPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(86, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(717, 20);
            this.txtId.TabIndex = 0;
            this.txtId.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(86, 58);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(365, 21);
            this.cmbCliente.TabIndex = 1;
            // 
            // cmbProduto
            // 
            this.cmbProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(86, 96);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(365, 21);
            this.cmbProduto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidade.Location = new System.Drawing.Point(538, 96);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(263, 20);
            this.txtQuantidade.TabIndex = 4;
            // 
            // grdNovoPedido
            // 
            this.grdNovoPedido.AllowUserToAddRows = false;
            this.grdNovoPedido.AllowUserToDeleteRows = false;
            this.grdNovoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdNovoPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdNovoPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNovoPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao,
            this.Quantidade,
            this.CustoUnitario,
            this.CustoTotal,
            this.Observacoes});
            this.grdNovoPedido.Location = new System.Drawing.Point(15, 191);
            this.grdNovoPedido.Name = "grdNovoPedido";
            this.grdNovoPedido.ReadOnly = true;
            this.grdNovoPedido.Size = new System.Drawing.Size(798, 225);
            this.grdNovoPedido.TabIndex = 27;
            this.grdNovoPedido.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grdNovoPedido_PreviewKeyDown);
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Produto";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle1;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // CustoUnitario
            // 
            this.CustoUnitario.DataPropertyName = "CustoUnitario";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.CustoUnitario.DefaultCellStyle = dataGridViewCellStyle2;
            this.CustoUnitario.HeaderText = "Custo Unitario";
            this.CustoUnitario.Name = "CustoUnitario";
            this.CustoUnitario.ReadOnly = true;
            // 
            // CustoTotal
            // 
            this.CustoTotal.DataPropertyName = "CustoTotal";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.CustoTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustoTotal.HeaderText = "Custo Total";
            this.CustoTotal.Name = "CustoTotal";
            this.CustoTotal.ReadOnly = true;
            // 
            // Observacoes
            // 
            this.Observacoes.DataPropertyName = "Observacoes";
            this.Observacoes.HeaderText = "Observações";
            this.Observacoes.Name = "Observacoes";
            this.Observacoes.ReadOnly = true;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacao.Location = new System.Drawing.Point(86, 133);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(365, 52);
            this.txtObservacao.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Observação:";
            // 
            // lblCustoTotal
            // 
            this.lblCustoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCustoTotal.AutoSize = true;
            this.lblCustoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoTotal.Location = new System.Drawing.Point(12, 423);
            this.lblCustoTotal.Name = "lblCustoTotal";
            this.lblCustoTotal.Size = new System.Drawing.Size(131, 25);
            this.lblCustoTotal.TabIndex = 30;
            this.lblCustoTotal.Text = "Custo Total:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "INCOMPLETO",
            "PRODUÇÃO",
            "COMPLETO"});
            this.cmbStatus.Location = new System.Drawing.Point(538, 128);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(263, 21);
            this.cmbStatus.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Status:";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSair.Location = new System.Drawing.Point(746, 427);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(67, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(674, 427);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(66, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(734, 158);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(67, 27);
            this.btnIncluir.TabIndex = 7;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtData
            // 
            this.txtData.CustomFormat = "dd/MM/yyyy";
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtData.Location = new System.Drawing.Point(538, 59);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(263, 20);
            this.txtData.TabIndex = 2;
            // 
            // frmPedidoNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 457);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.lblCustoTotal);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grdNovoPedido);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedidoNovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar/Alterar Pedidos";
            this.Load += new System.EventHandler(this.frmPedidoNovo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNovoPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbCliente;
        public System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantidade;
        public System.Windows.Forms.DataGridView grdNovoPedido;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCustoTotal;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        public ComboBox cmbStatus;
        private Label label7;
        public DateTimePicker txtData;
    }
}