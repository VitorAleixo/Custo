namespace Custo
{
    partial class frmCadastroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabCadastroCliente = new System.Windows.Forms.TabControl();
            this.tabPageFormulario = new System.Windows.Forms.TabPage();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.tabPageLista = new System.Windows.Forms.TabPage();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTipoConta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnderecoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCadastroCliente.SuspendLayout();
            this.tabPageFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.tabPageLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCadastroCliente
            // 
            this.tabCadastroCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCadastroCliente.Controls.Add(this.tabPageFormulario);
            this.tabCadastroCliente.Controls.Add(this.tabPageLista);
            this.tabCadastroCliente.Location = new System.Drawing.Point(-1, 12);
            this.tabCadastroCliente.Name = "tabCadastroCliente";
            this.tabCadastroCliente.SelectedIndex = 0;
            this.tabCadastroCliente.Size = new System.Drawing.Size(731, 399);
            this.tabCadastroCliente.TabIndex = 2;
            // 
            // tabPageFormulario
            // 
            this.tabPageFormulario.Controls.Add(this.btnSair);
            this.tabPageFormulario.Controls.Add(this.btnNovoCliente);
            this.tabPageFormulario.Controls.Add(this.grdClientes);
            this.tabPageFormulario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPageFormulario.Location = new System.Drawing.Point(4, 22);
            this.tabPageFormulario.Name = "tabPageFormulario";
            this.tabPageFormulario.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFormulario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPageFormulario.Size = new System.Drawing.Size(723, 403);
            this.tabPageFormulario.TabIndex = 0;
            this.tabPageFormulario.Text = "Lista";
            this.tabPageFormulario.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Image = global::Custo.Properties.Resources.if_cross_16189;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(587, 374);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(62, 27);
            this.btnSair.TabIndex = 12;
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
            this.btnNovoCliente.Location = new System.Drawing.Point(655, 374);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(62, 27);
            this.btnNovoCliente.TabIndex = 11;
            this.btnNovoCliente.Text = "Novo";
            this.btnNovoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // grdClientes
            // 
            this.grdClientes.AllowUserToAddRows = false;
            this.grdClientes.AllowUserToDeleteRows = false;
            this.grdClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.Senha,
            this.TipoConta,
            this.Nome,
            this.Cpf,
            this.Email,
            this.TelefoneCliente,
            this.EnderecoCliente});
            this.grdClientes.Location = new System.Drawing.Point(6, 6);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.ReadOnly = true;
            this.grdClientes.Size = new System.Drawing.Size(711, 362);
            this.grdClientes.TabIndex = 0;
            this.grdClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClientes_CellDoubleClick);
            this.grdClientes.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.grdClientes_PreviewKeyDown);
            // 
            // tabPageLista
            // 
            this.tabPageLista.Controls.Add(this.txtEmail);
            this.tabPageLista.Controls.Add(this.txtTelefone);
            this.tabPageLista.Controls.Add(this.txtCpf);
            this.tabPageLista.Controls.Add(this.txtNome);
            this.tabPageLista.Controls.Add(this.txtSenha);
            this.tabPageLista.Controls.Add(this.txtUsuario);
            this.tabPageLista.Controls.Add(this.label8);
            this.tabPageLista.Controls.Add(this.label9);
            this.tabPageLista.Controls.Add(this.cmbTipoConta);
            this.tabPageLista.Controls.Add(this.label7);
            this.tabPageLista.Controls.Add(this.label1);
            this.tabPageLista.Controls.Add(this.txtEndereco);
            this.tabPageLista.Controls.Add(this.txtId);
            this.tabPageLista.Controls.Add(this.label6);
            this.tabPageLista.Controls.Add(this.btnCancelar);
            this.tabPageLista.Controls.Add(this.btnSalvar);
            this.tabPageLista.Controls.Add(this.label5);
            this.tabPageLista.Controls.Add(this.label4);
            this.tabPageLista.Controls.Add(this.label3);
            this.tabPageLista.Controls.Add(this.label2);
            this.tabPageLista.Location = new System.Drawing.Point(4, 22);
            this.tabPageLista.Name = "tabPageLista";
            this.tabPageLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLista.Size = new System.Drawing.Size(723, 373);
            this.tabPageLista.TabIndex = 1;
            this.tabPageLista.Text = "Formulário";
            this.tabPageLista.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 159);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(606, 20);
            this.txtEmail.TabIndex = 28;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(112, 136);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(606, 20);
            this.txtTelefone.TabIndex = 27;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(112, 112);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(606, 20);
            this.txtCpf.TabIndex = 26;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(112, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(606, 20);
            this.txtNome.TabIndex = 25;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(112, 60);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(606, 20);
            this.txtSenha.TabIndex = 24;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(112, 32);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(606, 20);
            this.txtUsuario.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Senha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Usuario:";
            // 
            // cmbTipoConta
            // 
            this.cmbTipoConta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoConta.FormattingEnabled = true;
            this.cmbTipoConta.Items.AddRange(new object[] {
            "ADMIN",
            "USUARIO"});
            this.cmbTipoConta.Location = new System.Drawing.Point(112, 183);
            this.cmbTipoConta.Name = "cmbTipoConta";
            this.cmbTipoConta.Size = new System.Drawing.Size(606, 21);
            this.cmbTipoConta.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tipo Conta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Email:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(111, 210);
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(607, 100);
            this.txtEndereco.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(112, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(606, 20);
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
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(561, 344);
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
            this.btnSalvar.Location = new System.Drawing.Point(642, 344);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF / CNPJ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "Senha";
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            // 
            // TipoConta
            // 
            this.TipoConta.DataPropertyName = "TipoConta";
            this.TipoConta.HeaderText = "Tipo Conta";
            this.TipoConta.Name = "TipoConta";
            this.TipoConta.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Cpf";
            this.Cpf.HeaderText = "CPF / CNPJ";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // TelefoneCliente
            // 
            this.TelefoneCliente.DataPropertyName = "Telefone";
            this.TelefoneCliente.HeaderText = "Telefone";
            this.TelefoneCliente.Name = "TelefoneCliente";
            this.TelefoneCliente.ReadOnly = true;
            // 
            // EnderecoCliente
            // 
            this.EnderecoCliente.DataPropertyName = "Endereco";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.EnderecoCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.EnderecoCliente.HeaderText = "Endereço";
            this.EnderecoCliente.Name = "EnderecoCliente";
            this.EnderecoCliente.ReadOnly = true;
            // 
            // frmCadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 443);
            this.Controls.Add(this.tabCadastroCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroUsuarios";
            this.Text = "Cadastro de Usuarios";
            this.Load += new System.EventHandler(this.frmCadastroUsuarios_Load);
            this.tabCadastroCliente.ResumeLayout(false);
            this.tabPageFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.tabPageLista.ResumeLayout(false);
            this.tabPageLista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCadastroCliente;
        private System.Windows.Forms.TabPage tabPageFormulario;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.TabPage tabPageLista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoConta;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoCliente;
    }
}