using System.Windows.Forms;
namespace Custo
{
    partial class frmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlProduto = new System.Windows.Forms.TabControl();
            this.tabPageFormulario = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnNoFiltro = new System.Windows.Forms.Button();
            this.cmbTipoFiltro = new System.Windows.Forms.ComboBox();
            this.txtDescricaoFiltro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigoProdutoFiltro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.grdDados = new System.Windows.Forms.DataGridView();
            this.tabPageLista = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecoCompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlProduto.SuspendLayout();
            this.tabPageFormulario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            this.tabPageLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlProduto
            // 
            this.tabControlProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlProduto.Controls.Add(this.tabPageFormulario);
            this.tabControlProduto.Controls.Add(this.tabPageLista);
            this.tabControlProduto.Location = new System.Drawing.Point(12, 12);
            this.tabControlProduto.Name = "tabControlProduto";
            this.tabControlProduto.SelectedIndex = 0;
            this.tabControlProduto.Size = new System.Drawing.Size(731, 410);
            this.tabControlProduto.TabIndex = 0;
            // 
            // tabPageFormulario
            // 
            this.tabPageFormulario.Controls.Add(this.groupBox1);
            this.tabPageFormulario.Controls.Add(this.btnSair);
            this.tabPageFormulario.Controls.Add(this.btnNovo);
            this.tabPageFormulario.Controls.Add(this.grdDados);
            this.tabPageFormulario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPageFormulario.Location = new System.Drawing.Point(4, 22);
            this.tabPageFormulario.Name = "tabPageFormulario";
            this.tabPageFormulario.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFormulario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPageFormulario.Size = new System.Drawing.Size(723, 384);
            this.tabPageFormulario.TabIndex = 0;
            this.tabPageFormulario.Text = "Lista";
            this.tabPageFormulario.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnFiltro);
            this.groupBox1.Controls.Add(this.btnNoFiltro);
            this.groupBox1.Controls.Add(this.cmbTipoFiltro);
            this.groupBox1.Controls.Add(this.txtDescricaoFiltro);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCodigoProdutoFiltro);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 45);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFiltro.Image = global::Custo.Properties.Resources.btnFiltro;
            this.btnFiltro.Location = new System.Drawing.Point(643, 13);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(30, 25);
            this.btnFiltro.TabIndex = 48;
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // btnNoFiltro
            // 
            this.btnNoFiltro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNoFiltro.Image = global::Custo.Properties.Resources.btnSair_Cancelar;
            this.btnNoFiltro.Location = new System.Drawing.Point(675, 13);
            this.btnNoFiltro.Name = "btnNoFiltro";
            this.btnNoFiltro.Size = new System.Drawing.Size(30, 25);
            this.btnNoFiltro.TabIndex = 47;
            this.btnNoFiltro.UseVisualStyleBackColor = true;
            this.btnNoFiltro.Click += new System.EventHandler(this.btnNoFiltro_Click);
            // 
            // cmbTipoFiltro
            // 
            this.cmbTipoFiltro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoFiltro.FormattingEnabled = true;
            this.cmbTipoFiltro.Items.AddRange(new object[] {
            "Matéria Prima",
            "Produto Final"});
            this.cmbTipoFiltro.Location = new System.Drawing.Point(477, 16);
            this.cmbTipoFiltro.Name = "cmbTipoFiltro";
            this.cmbTipoFiltro.Size = new System.Drawing.Size(127, 21);
            this.cmbTipoFiltro.TabIndex = 20;
            // 
            // txtDescricaoFiltro
            // 
            this.txtDescricaoFiltro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDescricaoFiltro.Location = new System.Drawing.Point(298, 16);
            this.txtDescricaoFiltro.Name = "txtDescricaoFiltro";
            this.txtDescricaoFiltro.Size = new System.Drawing.Size(136, 20);
            this.txtDescricaoFiltro.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tipo:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Descrição:";
            // 
            // txtCodigoProdutoFiltro
            // 
            this.txtCodigoProdutoFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoProdutoFiltro.Location = new System.Drawing.Point(110, 16);
            this.txtCodigoProdutoFiltro.Name = "txtCodigoProdutoFiltro";
            this.txtCodigoProdutoFiltro.Size = new System.Drawing.Size(118, 20);
            this.txtCodigoProdutoFiltro.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Código do Produto:";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Image = global::Custo.Properties.Resources.btnSair_Cancelar;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(587, 355);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(62, 27);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Image = global::Custo.Properties.Resources.btnIncluir;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(655, 355);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(62, 27);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // grdDados
            // 
            this.grdDados.AllowUserToAddRows = false;
            this.grdDados.AllowUserToDeleteRows = false;
            this.grdDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.UM,
            this.Tipo,
            this.PrecoCompra,
            this.PrecoVenda});
            this.grdDados.Location = new System.Drawing.Point(6, 57);
            this.grdDados.Name = "grdDados";
            this.grdDados.ReadOnly = true;
            this.grdDados.Size = new System.Drawing.Size(711, 292);
            this.grdDados.TabIndex = 0;
            this.grdDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDados_CellDoubleClick);
            this.grdDados.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grdDados_PreviewKeyDown);
            // 
            // tabPageLista
            // 
            this.tabPageLista.Controls.Add(this.label7);
            this.tabPageLista.Controls.Add(this.cmbTipo);
            this.tabPageLista.Controls.Add(this.cmbUnidadeMedida);
            this.tabPageLista.Controls.Add(this.txtId);
            this.tabPageLista.Controls.Add(this.label6);
            this.tabPageLista.Controls.Add(this.txtPrecoCompra);
            this.tabPageLista.Controls.Add(this.label5);
            this.tabPageLista.Controls.Add(this.label4);
            this.tabPageLista.Controls.Add(this.label3);
            this.tabPageLista.Controls.Add(this.txtDescricao);
            this.tabPageLista.Controls.Add(this.label2);
            this.tabPageLista.Controls.Add(this.txtCodigo);
            this.tabPageLista.Controls.Add(this.label1);
            this.tabPageLista.Controls.Add(this.btnCancelar);
            this.tabPageLista.Controls.Add(this.btnSalvar);
            this.tabPageLista.Location = new System.Drawing.Point(4, 22);
            this.tabPageLista.Name = "tabPageLista";
            this.tabPageLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLista.Size = new System.Drawing.Size(723, 384);
            this.tabPageLista.TabIndex = 1;
            this.tabPageLista.Text = "Formulário";
            this.tabPageLista.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "OBS: Adicione produtos com base no mercado!";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Matéria Prima",
            "Produto Final"});
            this.cmbTipo.Location = new System.Drawing.Point(111, 110);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(605, 21);
            this.cmbTipo.TabIndex = 4;
            // 
            // cmbUnidadeMedida
            // 
            this.cmbUnidadeMedida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadeMedida.FormattingEnabled = true;
            this.cmbUnidadeMedida.Items.AddRange(new object[] {
            "KG",
            "MG",
            "G",
            "L",
            "ML",
            "UNIDADE"});
            this.cmbUnidadeMedida.Location = new System.Drawing.Point(111, 85);
            this.cmbUnidadeMedida.Name = "cmbUnidadeMedida";
            this.cmbUnidadeMedida.Size = new System.Drawing.Size(605, 21);
            this.cmbUnidadeMedida.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(112, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(605, 20);
            this.txtId.TabIndex = 13;
            this.txtId.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Id:";
            // 
            // txtPrecoCompra
            // 
            this.txtPrecoCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecoCompra.Location = new System.Drawing.Point(111, 136);
            this.txtPrecoCompra.Name = "txtPrecoCompra";
            this.txtPrecoCompra.Size = new System.Drawing.Size(605, 20);
            this.txtPrecoCompra.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Preço de Mercado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo do Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unidade de Medida:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Location = new System.Drawing.Point(111, 58);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(605, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.Location = new System.Drawing.Point(111, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(605, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Produto:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = global::Custo.Properties.Resources.btnSair_Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(560, 355);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(641, 355);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código do Produto";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
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
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo do Produto";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // PrecoCompra
            // 
            this.PrecoCompra.DataPropertyName = "PrecoCompra";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.PrecoCompra.DefaultCellStyle = dataGridViewCellStyle1;
            this.PrecoCompra.HeaderText = "Preço de Compra";
            this.PrecoCompra.Name = "PrecoCompra";
            this.PrecoCompra.ReadOnly = true;
            // 
            // PrecoVenda
            // 
            this.PrecoVenda.DataPropertyName = "PrecoVenda";
            this.PrecoVenda.HeaderText = "Preço de Venda";
            this.PrecoVenda.Name = "PrecoVenda";
            this.PrecoVenda.ReadOnly = true;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 432);
            this.Controls.Add(this.tabControlProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.tabControlProduto.ResumeLayout(false);
            this.tabPageFormulario.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            this.tabPageLista.ResumeLayout(false);
            this.tabPageLista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProduto;
        private System.Windows.Forms.TabPage tabPageFormulario;
        private System.Windows.Forms.DataGridView grdDados;
        private System.Windows.Forms.TabPage tabPageLista;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtPrecoCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbUnidadeMedida;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTipoFiltro;
        private System.Windows.Forms.TextBox txtDescricaoFiltro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigoProdutoFiltro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button btnNoFiltro;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn UM;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn PrecoCompra;
        private DataGridViewTextBoxColumn PrecoVenda;
    }
}