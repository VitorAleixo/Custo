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

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Validar = false;
            this.Close();
        }

        public bool Validar { get; set; } = false;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var obj = new Login();
            obj.Usuario = txtUsuario.Text;
            obj.Senha = txtSenha.Text;

            obj.Validacao();

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
    }
}
