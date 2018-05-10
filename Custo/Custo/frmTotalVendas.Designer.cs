namespace Custo
{
    partial class frmTotalVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTotalVendas));
            this.gbMensal = new System.Windows.Forms.GroupBox();
            this.cmbAnoM = new System.Windows.Forms.ComboBox();
            this.cmbMesM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDiario = new System.Windows.Forms.GroupBox();
            this.txtDiaD = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.gbAnual = new System.Windows.Forms.GroupBox();
            this.cmbAnoA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTodos = new System.Windows.Forms.GroupBox();
            this.txtDeT = new System.Windows.Forms.DateTimePicker();
            this.txtAteT = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grdLucro = new System.Windows.Forms.DataGridView();
            this.lblCustoTotal = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbMensal.SuspendLayout();
            this.gbDiario.SuspendLayout();
            this.gbAnual.SuspendLayout();
            this.gbTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLucro)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMensal
            // 
            this.gbMensal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMensal.Controls.Add(this.cmbAnoM);
            this.gbMensal.Controls.Add(this.cmbMesM);
            this.gbMensal.Controls.Add(this.label3);
            this.gbMensal.Controls.Add(this.label2);
            this.gbMensal.Location = new System.Drawing.Point(211, 12);
            this.gbMensal.Name = "gbMensal";
            this.gbMensal.Size = new System.Drawing.Size(193, 47);
            this.gbMensal.TabIndex = 41;
            this.gbMensal.TabStop = false;
            this.gbMensal.Text = "Mensal";
            // 
            // cmbAnoM
            // 
            this.cmbAnoM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAnoM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnoM.FormattingEnabled = true;
            this.cmbAnoM.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbAnoM.Location = new System.Drawing.Point(134, 19);
            this.cmbAnoM.Name = "cmbAnoM";
            this.cmbAnoM.Size = new System.Drawing.Size(53, 21);
            this.cmbAnoM.TabIndex = 50;
            // 
            // cmbMesM
            // 
            this.cmbMesM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMesM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMesM.FormattingEnabled = true;
            this.cmbMesM.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMesM.Location = new System.Drawing.Point(42, 19);
            this.cmbMesM.Name = "cmbMesM";
            this.cmbMesM.Size = new System.Drawing.Size(47, 21);
            this.cmbMesM.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Mês:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ano:";
            // 
            // gbDiario
            // 
            this.gbDiario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDiario.Controls.Add(this.txtDiaD);
            this.gbDiario.Controls.Add(this.label4);
            this.gbDiario.Location = new System.Drawing.Point(12, 12);
            this.gbDiario.Name = "gbDiario";
            this.gbDiario.Size = new System.Drawing.Size(193, 47);
            this.gbDiario.TabIndex = 42;
            this.gbDiario.TabStop = false;
            this.gbDiario.Text = "Diario";
            // 
            // txtDiaD
            // 
            this.txtDiaD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDiaD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDiaD.Location = new System.Drawing.Point(40, 19);
            this.txtDiaD.Name = "txtDiaD";
            this.txtDiaD.Size = new System.Drawing.Size(82, 20);
            this.txtDiaD.TabIndex = 50;
            this.txtDiaD.Value = new System.DateTime(2018, 2, 14, 0, 0, 0, 0);
            this.txtDiaD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiaD_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Dia:";
            // 
            // gbAnual
            // 
            this.gbAnual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAnual.Controls.Add(this.cmbAnoA);
            this.gbAnual.Controls.Add(this.label1);
            this.gbAnual.Location = new System.Drawing.Point(410, 12);
            this.gbAnual.Name = "gbAnual";
            this.gbAnual.Size = new System.Drawing.Size(147, 47);
            this.gbAnual.TabIndex = 43;
            this.gbAnual.TabStop = false;
            this.gbAnual.Text = "Anual";
            // 
            // cmbAnoA
            // 
            this.cmbAnoA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAnoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnoA.FormattingEnabled = true;
            this.cmbAnoA.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbAnoA.Location = new System.Drawing.Point(43, 19);
            this.cmbAnoA.Name = "cmbAnoA";
            this.cmbAnoA.Size = new System.Drawing.Size(57, 21);
            this.cmbAnoA.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ano:";
            // 
            // gbTodos
            // 
            this.gbTodos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTodos.Controls.Add(this.txtDeT);
            this.gbTodos.Controls.Add(this.txtAteT);
            this.gbTodos.Controls.Add(this.label6);
            this.gbTodos.Controls.Add(this.label5);
            this.gbTodos.Location = new System.Drawing.Point(562, 12);
            this.gbTodos.Name = "gbTodos";
            this.gbTodos.Size = new System.Drawing.Size(240, 47);
            this.gbTodos.TabIndex = 44;
            this.gbTodos.TabStop = false;
            this.gbTodos.Text = "Entre Datas";
            // 
            // txtDeT
            // 
            this.txtDeT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDeT.CustomFormat = "";
            this.txtDeT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDeT.Location = new System.Drawing.Point(31, 19);
            this.txtDeT.Name = "txtDeT";
            this.txtDeT.Size = new System.Drawing.Size(82, 20);
            this.txtDeT.TabIndex = 49;
            this.txtDeT.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.txtDeT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeT_KeyDown);
            // 
            // txtAteT
            // 
            this.txtAteT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAteT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtAteT.Location = new System.Drawing.Point(151, 19);
            this.txtAteT.Name = "txtAteT";
            this.txtAteT.Size = new System.Drawing.Size(83, 20);
            this.txtAteT.TabIndex = 50;
            this.txtAteT.Value = new System.DateTime(2018, 2, 14, 8, 50, 16, 0);
            this.txtAteT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAteT_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Ate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "De:";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Image = global::Custo.Properties.Resources.btnSair_Cancelar;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(672, 461);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(62, 23);
            this.btnSair.TabIndex = 46;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Image = global::Custo.Properties.Resources.btnBuscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(740, 461);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 23);
            this.btnBuscar.TabIndex = 45;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grdLucro
            // 
            this.grdLucro.AllowUserToAddRows = false;
            this.grdLucro.AllowUserToDeleteRows = false;
            this.grdLucro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdLucro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdLucro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLucro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.Cliente2,
            this.Data,
            this.ValorTotal});
            this.grdLucro.Location = new System.Drawing.Point(12, 65);
            this.grdLucro.Name = "grdLucro";
            this.grdLucro.ReadOnly = true;
            this.grdLucro.Size = new System.Drawing.Size(790, 390);
            this.grdLucro.TabIndex = 47;
            // 
            // lblCustoTotal
            // 
            this.lblCustoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustoTotal.AutoSize = true;
            this.lblCustoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoTotal.Location = new System.Drawing.Point(7, 461);
            this.lblCustoTotal.Name = "lblCustoTotal";
            this.lblCustoTotal.Size = new System.Drawing.Size(210, 25);
            this.lblCustoTotal.TabIndex = 48;
            this.lblCustoTotal.Text = "Total de Vendas: R$";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Cliente2
            // 
            this.Cliente2.DataPropertyName = "Cliente2";
            this.Cliente2.HeaderText = "Cliente";
            this.Cliente2.Name = "Cliente2";
            this.Cliente2.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataPropertyName = "ValorTotal";
            dataGridViewCellStyle1.Format = "c";
            this.ValorTotal.DefaultCellStyle = dataGridViewCellStyle1;
            this.ValorTotal.HeaderText = "Custo do Pedido";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            // 
            // frmTotalLucros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 495);
            this.Controls.Add(this.lblCustoTotal);
            this.Controls.Add(this.grdLucro);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gbTodos);
            this.Controls.Add(this.gbAnual);
            this.Controls.Add(this.gbDiario);
            this.Controls.Add(this.gbMensal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTotalLucros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas Totais";
            this.Load += new System.EventHandler(this.frmTotalLucros_Load);
            this.gbMensal.ResumeLayout(false);
            this.gbMensal.PerformLayout();
            this.gbDiario.ResumeLayout(false);
            this.gbDiario.PerformLayout();
            this.gbAnual.ResumeLayout(false);
            this.gbAnual.PerformLayout();
            this.gbTodos.ResumeLayout(false);
            this.gbTodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLucro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.GroupBox gbMensal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox gbDiario;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.GroupBox gbAnual;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gbTodos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.DataGridView grdLucro;
        private System.Windows.Forms.Label lblCustoTotal;
        public System.Windows.Forms.DateTimePicker txtDiaD;
        public System.Windows.Forms.DateTimePicker txtDeT;
        public System.Windows.Forms.DateTimePicker txtAteT;
        public System.Windows.Forms.ComboBox cmbAnoM;
        public System.Windows.Forms.ComboBox cmbMesM;
        public System.Windows.Forms.ComboBox cmbAnoA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
    }
}