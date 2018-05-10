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
            txtCPF.Text = "";
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
                Criptografia c = new Criptografia();
                obj.Id = int.Parse(txtId.Text);
                obj.Usuario = txtUsuario.Text;
                string senhaCriptografada = c.SHA256(txtSenha.Text);
                obj.Senha = senhaCriptografada;
                obj.Nome = txtNome.Text;
                obj.Cpf = txtCPF.Text;
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
            txtCPF.Text = "NÃO POSSUI";
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
                txtSenha.Text = "";
                txtNome.Text = obj.Nome;
                txtCPF.Text = obj.Cpf.ToString();
                txtTelefone.Text = obj.Telefone;
                txtEmail.Text = obj.Email;
                txtEndereco.Text = obj.Endereco;
                cmbTipoConta.SelectedItem = obj.TipoConta;
                txtUsuario.Enabled = false;
                tabCadastroCliente.SelectedIndex = 1;

                if (obj.Cpf.ToString().Length == 14)
                {
                    cmbCPF.SelectedItem = "CPF";
                    txtCPF.Text = obj.Cpf.ToString();
                    txtCPF.Enabled = true;
                }
                else if (obj.Cpf.ToString().Length == 18)
                {
                    cmbCPF.SelectedItem = "CNPJ";
                    txtCPF.Text = obj.Cpf.ToString();
                    txtCPF.Enabled = true;
                }
                else if (obj.Cpf.ToString().Length == 0)
                {
                    cmbCPF.SelectedItem = "NÃO POSSUI";
                    txtCPF.Text = obj.Cpf.ToString();
                    txtCPF.Enabled = false;
                }

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
            SortableBindingList<CadastroUsuario> _lst = new SortableBindingList<CadastroUsuario>();
            var lst = CadastroUsuario.BuscarTodos();
            foreach (var item in lst)
                _lst.Add(item);

            grdClientes.AutoGenerateColumns = false;
            grdClientes.DataSource = null;
            grdClientes.DataSource = _lst;
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

                    SortableBindingList<CadastroUsuario> _lst = new SortableBindingList<CadastroUsuario>();
                    var lst = Filtro.clienteadminBuscarPorUsuarioTipoConta();
                    foreach (var item in lst)
                        _lst.Add(item);

                    grdClientes.AutoGenerateColumns = false;
                    grdClientes.DataSource = null;
                    grdClientes.DataSource = _lst;
                    grdClientes.Show();
                }
                else if (txtUsuarioFiltro.Text != "" && cmbTipoContaFiltro.Text == "")
                {
                    Filtro.Usuario = txtUsuarioFiltro.Text;

                    SortableBindingList<CadastroUsuario> _lst = new SortableBindingList<CadastroUsuario>();
                    var lst = Filtro.clienteadminBuscarPorUsuario();
                    foreach (var item in lst)
                        _lst.Add(item);

                    grdClientes.AutoGenerateColumns = false;
                    grdClientes.DataSource = null;
                    grdClientes.DataSource = _lst;
                    grdClientes.Show();
                }
                else if (txtUsuarioFiltro.Text == "" && cmbTipoContaFiltro.Text != "")
                {

                    Filtro.TipoConta = cmbTipoContaFiltro.SelectedItem.ToString();

                    SortableBindingList<CadastroUsuario> _lst = new SortableBindingList<CadastroUsuario>();
                    var lst = Filtro.clienteadminBuscarPorTipoConta();
                    foreach (var item in lst)
                        _lst.Add(item);

                    grdClientes.AutoGenerateColumns = false;
                    grdClientes.DataSource = null;
                    grdClientes.DataSource = _lst;
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

        private void grdClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
                try
                {
                    foreach (DataGridViewRow row in grdClientes.Rows)
                    { 
                        string RowType = row.Cells[2].Value.ToString();

                        if (RowType == "ADMIN")
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        else if (RowType == "USUARIO")
                        {
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void cmbCPF_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCPF.SelectedItem.ToString() == "CPF")
            {
                txtCPF.Text = "";
                txtCPF.Enabled = true;
                txtCPF.Mask = "000.000.000-00";
            }
            else if (cmbCPF.SelectedItem.ToString() == "CNPJ")
            {
                txtCPF.Text = "";
                txtCPF.Enabled = true;
                txtCPF.Mask = "00.000.000/0000-00";
            }
            else if (cmbCPF.SelectedItem.ToString() == "NÃO POSSUI")
            {
                txtCPF.Text = "";
                txtCPF.Enabled = false;
                txtCPF.Mask = "";
            }
        }
    }
}
