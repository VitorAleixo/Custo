using Custo.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Custo
{
   

    public partial class frmPrincipal : Form
    {
        public string NomeUser { get; set; }
        public string User { get; set; }
        public bool Checar { get; set; } = false;

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmProduto { MdiParent = this, StartPosition = FormStartPosition.CenterParent }.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmClientes { MdiParent = this, StartPosition = FormStartPosition.CenterParent }.Show();
          
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPedidos { MdiParent = this, StartPosition = FormStartPosition.CenterParent }.Show();
        }

        private void composiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmComposicao { MdiParent = this, StartPosition = FormStartPosition.CenterParent }.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAjuda { MdiParent = this, StartPosition = FormStartPosition.CenterParent }.Show();
        }

        private void cadastroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCadastroUsuarios { MdiParent = this, StartPosition = FormStartPosition.CenterParent }.Show();          
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            DateTime dataHora = new DateTime();
            var obj = new Login();
            obj.User = txtUsuario.Text;
            obj.VerStatus();

            obj.VerStatusNome();

            string NomeUsuario = obj.NomeUser;
            txtUsuario.Text = obj.User;
            txtData.Text = dataHora.ToString();

            //VALIDACAO DE ADMIN
            var obj2 = new CadastroUsuario();
           
            obj2.Usuario = txtUsuario.Text;
            obj2.CheckAdmin();

            if (obj2.Checar == true)
            {
                cadastroDeUsuariosToolStripMenuItem.Visible = true;
                DialogResult dialogResult = MessageBox.Show("Bem Vindo: "+NomeUsuario+"! \nSeus direitos de ADMIN foram desbloqueados!", "Confirmacão", MessageBoxButtons.OK);

            }
            else
            {
                cadastroDeUsuariosToolStripMenuItem.Visible = false;
                DialogResult dialogResult = MessageBox.Show("Bem Vindo: "+NomeUsuario, "Confirmacão", MessageBoxButtons.OK);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.SetStatusSair();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
