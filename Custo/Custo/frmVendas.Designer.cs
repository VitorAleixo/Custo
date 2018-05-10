namespace Custo
{
    partial class frmLucros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLucros));
            this.btnMensal = new System.Windows.Forms.Button();
            this.btnAnual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDiario = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMensal
            // 
            this.btnMensal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMensal.Image = global::Custo.Properties.Resources.btnCalendario;
            this.btnMensal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMensal.Location = new System.Drawing.Point(139, 12);
            this.btnMensal.Name = "btnMensal";
            this.btnMensal.Size = new System.Drawing.Size(97, 56);
            this.btnMensal.TabIndex = 1;
            this.btnMensal.Text = "MENSAL";
            this.btnMensal.UseVisualStyleBackColor = true;
            this.btnMensal.Click += new System.EventHandler(this.btnMensal_Click);
            // 
            // btnAnual
            // 
            this.btnAnual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnual.Image = global::Custo.Properties.Resources.btnCalendario;
            this.btnAnual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnual.Location = new System.Drawing.Point(12, 87);
            this.btnAnual.Name = "btnAnual";
            this.btnAnual.Size = new System.Drawing.Size(97, 56);
            this.btnAnual.TabIndex = 2;
            this.btnAnual.Text = "ANUAL";
            this.btnAnual.UseVisualStyleBackColor = true;
            this.btnAnual.Click += new System.EventHandler(this.btnAnual_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione o modo de visualização das Vendas";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSair.Image = global::Custo.Properties.Resources.btnSair_Cancelar;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(98, 164);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 27);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDiario
            // 
            this.btnDiario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiario.Image = global::Custo.Properties.Resources.btnCalendario;
            this.btnDiario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiario.Location = new System.Drawing.Point(12, 12);
            this.btnDiario.Name = "btnDiario";
            this.btnDiario.Size = new System.Drawing.Size(97, 56);
            this.btnDiario.TabIndex = 0;
            this.btnDiario.Text = "DIARIO";
            this.btnDiario.UseVisualStyleBackColor = true;
            this.btnDiario.Click += new System.EventHandler(this.btnDiario_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodos.Image = global::Custo.Properties.Resources.btnCalendario;
            this.btnTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodos.Location = new System.Drawing.Point(139, 87);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(97, 56);
            this.btnTodos.TabIndex = 5;
            this.btnTodos.Text = "DATA";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // frmLucros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 203);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAnual);
            this.Controls.Add(this.btnMensal);
            this.Controls.Add(this.btnDiario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLucros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiario;
        private System.Windows.Forms.Button btnMensal;
        private System.Windows.Forms.Button btnAnual;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTodos;
    }
}