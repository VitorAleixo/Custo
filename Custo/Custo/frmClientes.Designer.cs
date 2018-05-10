using System.Windows.Forms;
namespace Custo
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlCliente = new System.Windows.Forms.TabControl();
            this.tabPageFormulario = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClienteFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNoFiltro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.grdDados2 = new System.Windows.Forms.DataGridView();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpfCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnderecoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageLista = new System.Windows.Forms.TabPage();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCPF = new System.Windows.Forms.ComboBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControlCliente.SuspendLayout();
            this.tabPageFormulario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados2)).BeginInit();
            this.tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCliente
            // 
            this.tabControlCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlCliente.Controls.Add(this.tabPageFormulario);
            this.tabControlCliente.Controls.Add(this.tabPageLista);
            this.tabControlCliente.Location = new System.Drawing.Point(16, 12);
            this.tabControlCliente.Name = "tabControlCliente";
            this.tabControlCliente.SelectedIndex = 0;
            this.tabControlCliente.Size = new System.Drawing.Size(731, 410);
            this.tabControlCliente.TabIndex = 9;
            // 
            // tabPageFormulario
            // 
            this.tabPageFormulario.Controls.Add(this.label9);
            this.tabPageFormulario.Controls.Add(this.pictureBox3);
            this.tabPageFormulario.Controls.Add(this.label8);
            this.tabPageFormulario.Controls.Add(this.pictureBox2);
            this.tabPageFormulario.Controls.Add(this.lblAdmin);
            this.tabPageFormulario.Controls.Add(this.pictureBox1);
            this.tabPageFormulario.Controls.Add(this.groupBox1);
            this.tabPageFormulario.Controls.Add(this.btnSair);
            this.tabPageFormulario.Controls.Add(this.btnNovoCliente);
            this.tabPageFormulario.Controls.Add(this.grdDados2);
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
            this.groupBox1.Controls.Add(this.txtClienteFiltro);
            this.groupBox1.Controls.Add(this.btnFiltro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnNoFiltro);
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 48);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // txtClienteFiltro
            // 
            this.txtClienteFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteFiltro.Location = new System.Drawing.Point(51, 19);
            this.txtClienteFiltro.Name = "txtClienteFiltro";
            this.txtClienteFiltro.Size = new System.Drawing.Size(592, 20);
            this.txtClienteFiltro.TabIndex = 1;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFiltro.Image = global::Custo.Properties.Resources.btnFiltro;
            this.btnFiltro.Location = new System.Drawing.Point(649, 16);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(30, 25);
            this.btnFiltro.TabIndex = 2;
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Cliente:";
            // 
            // btnNoFiltro
            // 
            this.btnNoFiltro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNoFiltro.Image = global::Custo.Properties.Resources.btnSair_Cancelar;
            this.btnNoFiltro.Location = new System.Drawing.Point(681, 16);
            this.btnNoFiltro.Name = "btnNoFiltro";
            this.btnNoFiltro.Size = new System.Drawing.Size(30, 25);
            this.btnNoFiltro.TabIndex = 3;
            this.btnNoFiltro.UseVisualStyleBackColor = true;
            this.btnNoFiltro.Click += new System.EventHandler(this.btnNoFiltro_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Image = global::Custo.Properties.Resources.btnSair_Cancelar;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(652, 355);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(62, 27);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoCliente.Image")));
            this.btnNovoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoCliente.Location = new System.Drawing.Point(584, 354);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(62, 27);
            this.btnNovoCliente.TabIndex = 4;
            this.btnNovoCliente.Text = "Novo";
            this.btnNovoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click_1);
            // 
            // grdDados2
            // 
            this.grdDados2.AllowUserToAddRows = false;
            this.grdDados2.AllowUserToDeleteRows = false;
            this.grdDados2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDados2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDados2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCliente,
            this.CpfCliente,
            this.TelefoneCliente,
            this.Email,
            this.EnderecoCliente});
            this.grdDados2.Location = new System.Drawing.Point(6, 61);
            this.grdDados2.Name = "grdDados2";
            this.grdDados2.ReadOnly = true;
            this.grdDados2.Size = new System.Drawing.Size(711, 288);
            this.grdDados2.TabIndex = 0;
            this.grdDados2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDados2_CellDoubleClick);
            this.grdDados2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdDados2_CellFormatting);
            this.grdDados2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grdDados2_PreviewKeyDown);
            // 
            // NomeCliente
            // 
            this.NomeCliente.DataPropertyName = "Nome";
            this.NomeCliente.HeaderText = "Nome";
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.ReadOnly = true;
            // 
            // CpfCliente
            // 
            this.CpfCliente.DataPropertyName = "CPF";
            this.CpfCliente.HeaderText = "CPF / CNPJ";
            this.CpfCliente.Name = "CpfCliente";
            this.CpfCliente.ReadOnly = true;
            // 
            // TelefoneCliente
            // 
            this.TelefoneCliente.DataPropertyName = "Telefone";
            this.TelefoneCliente.HeaderText = "Telefone";
            this.TelefoneCliente.Name = "TelefoneCliente";
            this.TelefoneCliente.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // EnderecoCliente
            // 
            this.EnderecoCliente.DataPropertyName = "Endereco";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.EnderecoCliente.DefaultCellStyle = dataGridViewCellStyle7;
            this.EnderecoCliente.HeaderText = "Endereço";
            this.EnderecoCliente.Name = "EnderecoCliente";
            this.EnderecoCliente.ReadOnly = true;
            // 
            // tabPageLista
            // 
            this.tabPageLista.Controls.Add(this.txtCPF);
            this.tabPageLista.Controls.Add(this.cmbCPF);
            this.tabPageLista.Controls.Add(this.txtEmail);
            this.tabPageLista.Controls.Add(this.label1);
            this.tabPageLista.Controls.Add(this.txtEndereco);
            this.tabPageLista.Controls.Add(this.txtTelefone);
            this.tabPageLista.Controls.Add(this.txtId);
            this.tabPageLista.Controls.Add(this.label6);
            this.tabPageLista.Controls.Add(this.btnCancelar);
            this.tabPageLista.Controls.Add(this.btnSalvar);
            this.tabPageLista.Controls.Add(this.label5);
            this.tabPageLista.Controls.Add(this.label4);
            this.tabPageLista.Controls.Add(this.label3);
            this.tabPageLista.Controls.Add(this.txtNome);
            this.tabPageLista.Controls.Add(this.label2);
            this.tabPageLista.Location = new System.Drawing.Point(4, 22);
            this.tabPageLista.Name = "tabPageLista";
            this.tabPageLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLista.Size = new System.Drawing.Size(723, 384);
            this.tabPageLista.TabIndex = 1;
            this.tabPageLista.Text = "Formulário";
            this.tabPageLista.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(111, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(605, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Email:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(111, 146);
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(605, 100);
            this.txtEndereco.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(111, 93);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(605, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(111, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(606, 20);
            this.txtId.TabIndex = 9;
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
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(642, 355);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
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
            this.btnSalvar.Location = new System.Drawing.Point(561, 355);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF / CNPJ:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(111, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(605, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // cmbCPF
            // 
            this.cmbCPF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCPF.FormattingEnabled = true;
            this.cmbCPF.Items.AddRange(new object[] {
            "NÃO POSSUI",
            "CPF",
            "CNPJ"});
            this.cmbCPF.Location = new System.Drawing.Point(111, 61);
            this.cmbCPF.Name = "cmbCPF";
            this.cmbCPF.Size = new System.Drawing.Size(134, 21);
            this.cmbCPF.TabIndex = 2;
            this.cmbCPF.SelectedValueChanged += new System.EventHandler(this.cmbCPF_SelectedValueChanged);
            // 
            // txtCPF
            // 
            this.txtCPF.Enabled = false;
            this.txtCPF.Location = new System.Drawing.Point(251, 61);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(465, 20);
            this.txtCPF.TabIndex = 3;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(37, 364);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(27, 13);
            this.lblAdmin.TabIndex = 53;
            this.lblAdmin.Text = "CPF";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox1.Location = new System.Drawing.Point(6, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 23);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "CNPJ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox2.Location = new System.Drawing.Point(85, 358);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 23);
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Não Possui";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Salmon;
            this.pictureBox3.Location = new System.Drawing.Point(164, 358);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 23);
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 443);
            this.Controls.Add(this.tabControlCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.tabControlCliente.ResumeLayout(false);
            this.tabPageFormulario.ResumeLayout(false);
            this.tabPageFormulario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados2)).EndInit();
            this.tabPageLista.ResumeLayout(false);
            this.tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCliente;
        private System.Windows.Forms.TabPage tabPageFormulario;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.DataGridView grdDados2;
        private System.Windows.Forms.TabPage tabPageLista;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpfCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoCliente;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtClienteFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button btnNoFiltro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaskedTextBox txtCPF;
        private ComboBox cmbCPF;
        private Label label9;
        private PictureBox pictureBox3;
        private Label label8;
        private PictureBox pictureBox2;
        private Label lblAdmin;
        private PictureBox pictureBox1;
    }
}