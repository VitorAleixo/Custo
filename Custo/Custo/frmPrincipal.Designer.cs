using Custo.AppCode;

namespace Custo
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.composiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraStatus = new System.Windows.Forms.StatusStrip();
            this.tsUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsData = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsHorario = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSair = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.barraStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.cadastroDeUsuariosToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            resources.ApplyResources(this.cadastrosToolStripMenuItem, "cadastrosToolStripMenuItem");
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            resources.ApplyResources(this.clientesToolStripMenuItem, "clientesToolStripMenuItem");
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            resources.ApplyResources(this.pedidosToolStripMenuItem, "pedidosToolStripMenuItem");
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.composiçãoToolStripMenuItem});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            resources.ApplyResources(this.produtoToolStripMenuItem, "produtoToolStripMenuItem");
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            resources.ApplyResources(this.produtosToolStripMenuItem, "produtosToolStripMenuItem");
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // composiçãoToolStripMenuItem
            // 
            this.composiçãoToolStripMenuItem.Name = "composiçãoToolStripMenuItem";
            resources.ApplyResources(this.composiçãoToolStripMenuItem, "composiçãoToolStripMenuItem");
            this.composiçãoToolStripMenuItem.Click += new System.EventHandler(this.composiçãoToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            resources.ApplyResources(this.ajudaToolStripMenuItem, "ajudaToolStripMenuItem");
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // cadastroDeUsuariosToolStripMenuItem
            // 
            this.cadastroDeUsuariosToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cadastroDeUsuariosToolStripMenuItem.Name = "cadastroDeUsuariosToolStripMenuItem";
            resources.ApplyResources(this.cadastroDeUsuariosToolStripMenuItem, "cadastroDeUsuariosToolStripMenuItem");
            this.cadastroDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeUsuariosToolStripMenuItem_Click);
            // 
            // barraStatus
            // 
            resources.ApplyResources(this.barraStatus, "barraStatus");
            this.barraStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUsuario,
            this.txtUsuario,
            this.tsData,
            this.txtData,
            this.tsHorario,
            this.txtHora});
            this.barraStatus.Name = "barraStatus";
            // 
            // tsUsuario
            // 
            this.tsUsuario.Name = "tsUsuario";
            resources.ApplyResources(this.tsUsuario, "tsUsuario");
            // 
            // txtUsuario
            // 
            this.txtUsuario.Name = "txtUsuario";
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            // 
            // tsData
            // 
            this.tsData.Name = "tsData";
            resources.ApplyResources(this.tsData, "tsData");
            this.tsData.Spring = true;
            // 
            // txtData
            // 
            this.txtData.Name = "txtData";
            resources.ApplyResources(this.txtData, "txtData");
            this.txtData.Spring = true;
            // 
            // tsHorario
            // 
            this.tsHorario.Name = "tsHorario";
            resources.ApplyResources(this.tsHorario, "tsHorario");
            this.tsHorario.Spring = true;
            // 
            // txtHora
            // 
            this.txtHora.Name = "txtHora";
            resources.ApplyResources(this.txtHora, "txtHora");
            this.txtHora.Spring = true;
            // 
            // btnSair
            // 
            this.btnSair.Image = global::Custo.Properties.Resources.if_cross_16189;
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.barraStatus);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.barraStatus.ResumeLayout(false);
            this.barraStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem composiçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cadastroDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip barraStatus;
        private System.Windows.Forms.ToolStripStatusLabel txtUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tsUsuario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolStripStatusLabel tsData;
        private System.Windows.Forms.ToolStripStatusLabel txtData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel tsHorario;
        private System.Windows.Forms.ToolStripStatusLabel txtHora;
    }
}