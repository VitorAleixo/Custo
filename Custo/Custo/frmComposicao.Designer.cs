using System.Windows.Forms;
namespace Custo
{
    partial class frmComposicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComposicao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbComposicao = new System.Windows.Forms.ComboBox();
            this.gbFormulario = new System.Windows.Forms.GroupBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCustoTotal = new System.Windows.Forms.Label();
            this.lblCustoProduto = new System.Windows.Forms.Label();
            this.lblEconomia = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblLucroTotal = new System.Windows.Forms.Label();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.lblLucro = new System.Windows.Forms.Label();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.lblCustoTotalProduto = new System.Windows.Forms.Label();
            this.gbVenda = new System.Windows.Forms.GroupBox();
            this.btnInserirVenda = new System.Windows.Forms.Button();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbComposicao);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Composição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Produto Final";
            // 
            // cmbComposicao
            // 
            this.cmbComposicao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbComposicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComposicao.FormattingEnabled = true;
            this.cmbComposicao.Location = new System.Drawing.Point(6, 35);
            this.cmbComposicao.Name = "cmbComposicao";
            this.cmbComposicao.Size = new System.Drawing.Size(744, 21);
            this.cmbComposicao.TabIndex = 1;
            this.cmbComposicao.SelectedValueChanged += new System.EventHandler(this.cmbComposicao_SelectedValueChanged);
            // 
            // gbFormulario
            // 
            this.gbFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFormulario.Controls.Add(this.btnInserir);
            this.gbFormulario.Controls.Add(this.txtQuantidade);
            this.gbFormulario.Controls.Add(this.label2);
            this.gbFormulario.Controls.Add(this.cmbProduto);
            this.gbFormulario.Controls.Add(this.label1);
            this.gbFormulario.Location = new System.Drawing.Point(13, 88);
            this.gbFormulario.Name = "gbFormulario";
            this.gbFormulario.Size = new System.Drawing.Size(445, 73);
            this.gbFormulario.TabIndex = 1;
            this.gbFormulario.TabStop = false;
            this.gbFormulario.Text = "Formulário";
            // 
            // btnInserir
            // 
            this.btnInserir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(377, 37);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(61, 27);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(210, 42);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(147, 20);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            // 
            // cmbProduto
            // 
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(9, 41);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(187, 21);
            this.cmbProduto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matéria Prima";
            // 
            // grdDados
            // 
            this.grdDados.AllowUserToAddRows = false;
            this.grdDados.AllowUserToDeleteRows = false;
            this.grdDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao,
            this.UM,
            this.Quantidade,
            this.PrecoUnitario,
            this.Custo});
            this.grdDados.Location = new System.Drawing.Point(12, 167);
            this.grdDados.Name = "grdDados";
            this.grdDados.ReadOnly = true;
            this.grdDados.Size = new System.Drawing.Size(758, 233);
            this.grdDados.TabIndex = 2;
            this.grdDados.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grdDados_PreviewKeyDown);
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Matéria Prima";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // UM
            // 
            this.UM.DataPropertyName = "UM";
            this.UM.HeaderText = "Unidade de Medida";
            this.UM.Name = "UM";
            this.UM.ReadOnly = true;
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
            // PrecoUnitario
            // 
            this.PrecoUnitario.DataPropertyName = "PrecoUnitario";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.PrecoUnitario.DefaultCellStyle = dataGridViewCellStyle2;
            this.PrecoUnitario.HeaderText = "Preço Unitário";
            this.PrecoUnitario.Name = "PrecoUnitario";
            this.PrecoUnitario.ReadOnly = true;
            // 
            // Custo
            // 
            this.Custo.DataPropertyName = "Custo";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Custo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Custo.HeaderText = "Custo";
            this.Custo.Name = "Custo";
            this.Custo.ReadOnly = true;
            // 
            // lblCustoTotal
            // 
            this.lblCustoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCustoTotal.AutoSize = true;
            this.lblCustoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoTotal.Location = new System.Drawing.Point(6, 12);
            this.lblCustoTotal.Name = "lblCustoTotal";
            this.lblCustoTotal.Size = new System.Drawing.Size(163, 25);
            this.lblCustoTotal.TabIndex = 3;
            this.lblCustoTotal.Text = "Custo Total: R$";
            // 
            // lblCustoProduto
            // 
            this.lblCustoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCustoProduto.AutoSize = true;
            this.lblCustoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoProduto.Location = new System.Drawing.Point(6, 37);
            this.lblCustoProduto.Name = "lblCustoProduto";
            this.lblCustoProduto.Size = new System.Drawing.Size(282, 25);
            this.lblCustoProduto.TabIndex = 4;
            this.lblCustoProduto.Text = "Custo de Mercado:  R$ 0,00";
            // 
            // lblEconomia
            // 
            this.lblEconomia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEconomia.AutoSize = true;
            this.lblEconomia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEconomia.Location = new System.Drawing.Point(6, 62);
            this.lblEconomia.Name = "lblEconomia";
            this.lblEconomia.Size = new System.Drawing.Size(194, 25);
            this.lblEconomia.TabIndex = 5;
            this.lblEconomia.Text = "Economia: R$ 0,00";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::Custo.Properties.Resources.btnSair_Cancelar;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(678, 86);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(72, 27);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblLucroTotal);
            this.groupBox3.Controls.Add(this.btnConcluir);
            this.groupBox3.Controls.Add(this.lblLucro);
            this.groupBox3.Controls.Add(this.lblPrecoVenda);
            this.groupBox3.Controls.Add(this.lblCustoTotalProduto);
            this.groupBox3.Controls.Add(this.lblCustoTotal);
            this.groupBox3.Controls.Add(this.btnSair);
            this.groupBox3.Controls.Add(this.lblCustoProduto);
            this.groupBox3.Controls.Add(this.lblEconomia);
            this.groupBox3.Location = new System.Drawing.Point(13, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(757, 119);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total de Custos";
            // 
            // lblLucroTotal
            // 
            this.lblLucroTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLucroTotal.AutoSize = true;
            this.lblLucroTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLucroTotal.Location = new System.Drawing.Point(446, 37);
            this.lblLucroTotal.Name = "lblLucroTotal";
            this.lblLucroTotal.Size = new System.Drawing.Size(105, 25);
            this.lblLucroTotal.TabIndex = 19;
            this.lblLucroTotal.Text = "Lucro: R$";
            // 
            // btnConcluir
            // 
            this.btnConcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConcluir.Image = global::Custo.Properties.Resources.btnAplicar;
            this.btnConcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConcluir.Location = new System.Drawing.Point(600, 86);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(72, 27);
            this.btnConcluir.TabIndex = 7;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // lblLucro
            // 
            this.lblLucro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLucro.AutoSize = true;
            this.lblLucro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLucro.Location = new System.Drawing.Point(554, 37);
            this.lblLucro.Name = "lblLucro";
            this.lblLucro.Size = new System.Drawing.Size(54, 25);
            this.lblLucro.TabIndex = 16;
            this.lblLucro.Text = "0,00";
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoVenda.Location = new System.Drawing.Point(446, 12);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(254, 25);
            this.lblPrecoVenda.TabIndex = 15;
            this.lblPrecoVenda.Text = "Preço de Venda: R$ 0,00";
            // 
            // lblCustoTotalProduto
            // 
            this.lblCustoTotalProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCustoTotalProduto.AutoSize = true;
            this.lblCustoTotalProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoTotalProduto.Location = new System.Drawing.Point(164, 12);
            this.lblCustoTotalProduto.Name = "lblCustoTotalProduto";
            this.lblCustoTotalProduto.Size = new System.Drawing.Size(54, 25);
            this.lblCustoTotalProduto.TabIndex = 14;
            this.lblCustoTotalProduto.Text = "0,00";
            // 
            // gbVenda
            // 
            this.gbVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbVenda.Controls.Add(this.btnInserirVenda);
            this.gbVenda.Controls.Add(this.txtValorVenda);
            this.gbVenda.Controls.Add(this.label4);
            this.gbVenda.Location = new System.Drawing.Point(464, 88);
            this.gbVenda.Name = "gbVenda";
            this.gbVenda.Size = new System.Drawing.Size(306, 73);
            this.gbVenda.TabIndex = 15;
            this.gbVenda.TabStop = false;
            this.gbVenda.Text = "Venda";
            // 
            // btnInserirVenda
            // 
            this.btnInserirVenda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInserirVenda.Image = global::Custo.Properties.Resources.btnEditar;
            this.btnInserirVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserirVenda.Location = new System.Drawing.Point(201, 37);
            this.btnInserirVenda.Name = "btnInserirVenda";
            this.btnInserirVenda.Size = new System.Drawing.Size(98, 27);
            this.btnInserirVenda.TabIndex = 6;
            this.btnInserirVenda.Text = "Inserir/Alterar";
            this.btnInserirVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserirVenda.UseVisualStyleBackColor = true;
            this.btnInserirVenda.Click += new System.EventHandler(this.btnInserirVenda_Click);
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(9, 42);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(147, 20);
            this.txtValorVenda.TabIndex = 5;
            this.txtValorVenda.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Preço de Venda:";
            // 
            // frmComposicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 533);
            this.Controls.Add(this.gbVenda);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grdDados);
            this.Controls.Add(this.gbFormulario);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmComposicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Composição";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFormulario.ResumeLayout(false);
            this.gbFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbVenda.ResumeLayout(false);
            this.gbVenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbComposicao;
        private System.Windows.Forms.GroupBox gbFormulario;
        private System.Windows.Forms.DataGridView grdDados;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustoTotal;
        private System.Windows.Forms.Label lblCustoProduto;
        private System.Windows.Forms.Label lblEconomia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox3;
        private GroupBox gbVenda;
        private Button btnInserirVenda;
        private TextBox txtValorVenda;
        private Label label4;
        private Label lblCustoTotalProduto;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn UM;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn PrecoUnitario;
        private DataGridViewTextBoxColumn Custo;
        private Label lblLucro;
        private Label lblPrecoVenda;
        private Button btnConcluir;
        private Label lblLucroTotal;
    }
}