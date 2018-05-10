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
    public partial class frmCadastroUsuarios : Form
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

        public frmCadastroUsuarios()
        {
            InitializeComponent();
        }

        private void frmCadastroUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CarregarGrid()
        {
            grdClientes.AutoGenerateColumns = false;
            grdClientes.DataSource = null;
            grdClientes.DataSource = CadastroUsuario.BuscarTodos();
            grdClientes.Show();
        }

        void LimparCampos()
        {
            txtId.Text = "0";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            cmbTipoConta.SelectedIndex = -1;
            txtEndereco.Text = "";
                
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = new CadastroUsuario();

                obj.Id = int.Parse(txtId.Text);
                obj.Usuario = txtUsuario.Text;
                obj.Senha = txtSenha.Text;
                obj.Nome = txtNome.Text;
                obj.Cpf = txtCpf.Text;
                obj.Telefone = txtTelefone.Text;
                obj.Email = txtEmail.Text;
                obj.Endereco = txtEndereco.Text;
                obj.TipoConta = cmbTipoConta.Text;

                if (obj.Usuario.Length > 0 && obj.Senha.Length > 0 && obj.Nome.Length > 0 && obj.Endereco.Length > 0 && obj.TipoConta.Length > 0)
                {
                    if (obj.Id == 0 )
                    {
                        obj.ChecarUsuarioInserir();
                        if (obj.CheckUser == true)
                        {
                            obj.Inserir();
                            MessageBox.Show("Cliente incluído com sucesso!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimparCampos();
                            tabCadastroCliente.SelectedIndex = 0;
                            CarregarGrid();
                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("Este Usuario já Existe!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        obj.ChecarUsuarioAtualizar();
                        if (obj.CheckUser == true)
                        {
                            obj.Atualizar();
                            MessageBox.Show("Cliente atualizado com sucesso", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimparCampos();

                            tabCadastroCliente.SelectedIndex = 0;
                            CarregarGrid();
                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("Este Usuario já Existe!", "Confirmação", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Algum dado está faltando!!!", "Confirmação", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LimparCampos();
                tabCadastroCliente.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            tabCadastroCliente.SelectedIndex = 1;
            LimparCampos();
            txtUsuario.Enabled = true;
        }

        private void grdClientes_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("Deseja excluir esse Cliente?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var obj = (CadastroUsuario)grdClientes.CurrentRow.DataBoundItem;

                        obj.Excluir();

                        CarregarGrid();

                        MessageBox.Show("Cliente excluído com sucesso", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var obj = (CadastroUsuario)grdClientes.CurrentRow.DataBoundItem;

                txtId.Text = obj.Id.ToString();
                txtUsuario.Text = obj.Usuario;
                txtSenha.Text = obj.Senha;
                txtNome.Text = obj.Nome;
                txtCpf.Text = obj.Cpf.ToString();
                txtTelefone.Text = obj.Telefone;
                txtEmail.Text = obj.Email;
                txtEndereco.Text = obj.Endereco;
                cmbTipoConta.SelectedItem = obj.TipoConta;
                txtUsuario.Enabled = false;
                tabCadastroCliente.SelectedIndex = 1;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LimparItens()
        {
            txtUsuarioFiltro.Text = "";
            cmbTipoContaFiltro.SelectedIndex = -1;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNoFiltro_Click(object sender, EventArgs e)
        {
            grdClientes.AutoGenerateColumns = false;
            grdClientes.DataSource = null;
            grdClientes.DataSource = CadastroUsuario.BuscarTodos();
            grdClientes.Show();
            LimparItens();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuarioFiltro.Text != "" && cmbTipoContaFiltro.Text != "")
                {
                    Filtro.Usuario = txtUsuarioFiltro.Text;
                    Filtro.TipoConta = cmbTipoContaFiltro.SelectedItem.ToString();
                    grdClientes.AutoGenerateColumns = false;
                    grdClientes.DataSource = null;
                    grdClientes.DataSource = Filtro.clienteadminBuscarPorUsuarioTipoConta();
                    grdClientes.Show();
                }
                else if (txtUsuarioFiltro.Text != "" && cmbTipoContaFiltro.Text == "")
                {
                    Filtro.Usuario = txtUsuarioFiltro.Text;
                    grdClientes.AutoGenerateColumns = false;
                    grdClientes.DataSource = null;
                    grdClientes.DataSource = Filtro.clienteadminBuscarPorUsuario();
                    grdClientes.Show();
                }
                else if (txtUsuarioFiltro.Text == "" && cmbTipoContaFiltro.Text != "")
                {
                    Filtro.TipoConta = cmbTipoContaFiltro.SelectedItem.ToString();
                    grdClientes.AutoGenerateColumns = false;
                    grdClientes.DataSource = null;
                    grdClientes.DataSource = Filtro.clienteadminBuscarPorTipoConta();
                    grdClientes.Show();
                }
                else if (txtUsuarioFiltro.Text == "" && cmbTipoConta.Text == "")
                {
                    DialogResult dialogresult = MessageBox.Show("Não se pode fazer filtro com dados Nulos!", "Filtro", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
