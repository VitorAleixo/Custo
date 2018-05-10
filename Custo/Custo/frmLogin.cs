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
    public partial class frmLogin : Form
    {
        public int variavel { get; set; } = 1;
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

        public void LimparCampos()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Validar = false;
            variavel = 0;
            this.Close();
        }

        public bool Validar { get; set; } = false;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var obj = new Login();
            obj.Usuario = txtUsuario.Text;
            obj.Senha = txtSenha.Text;
            Login l = new Login();
            l.SetStatusSair();
            obj.Validacao();
            variavel = 1;
            if (obj.Validar == true)
            {
                Validar = true;
                this.Close();
            }
            else
            {
                Validar = false;
                MessageBox.Show("Usuário ou Senha incorretos ou Inexistente!", "ContaCliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
