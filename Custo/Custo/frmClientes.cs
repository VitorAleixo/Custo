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
    public partial class frmClientes : Form
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

        private void CarregarGrid()
        {
            grdDados2.AutoGenerateColumns = false;
            grdDados2.DataSource = null;
            grdDados2.DataSource = Cliente.BuscarTodos();
            grdDados2.Show();
        }

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
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

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var obj = new Cliente();

                obj.Id = int.Parse(txtId.Text);
                obj.Nome = txtNome.Text;
                obj.CPF = txtCPF.Text;
                obj.Telefone = txtTelefone.Text;
                obj.Endereco = txtEndereco.Text;
                obj.Email = txtEmail.Text;

                if (obj.Nome.Length > 0 &&  obj.Endereco.Length > 0)
                {
                    if (obj.Id == 0)
                    {
                        obj.Inserir();
                        MessageBox.Show("Cliente incluído com sucesso!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimparCampos();

                    }
                    else
                    {
                        obj.Atualizar();
                        MessageBox.Show("Cliente atualizado com sucesso", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimparCampos();
                    }

                    tabControlCliente.SelectedIndex = 0;

                    CarregarGrid();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Nome e Endereço são obrigatórios!", "Confirmação", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LimparItens()
        {
            txtClienteFiltro.Text = "";
        }
        void LimparCampos()
        {
            txtId.Text = "0";
            txtNome.Text = "";
            txtCPF.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LimparCampos();
                tabControlCliente.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void grdDados2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var obj = (Cliente)grdDados2.CurrentRow.DataBoundItem;

                txtId.Text = obj.Id.ToString();
                txtNome.Text = obj.Nome;
                txtCPF.Text = obj.CPF.ToString();
                txtTelefone.Text = obj.Telefone;
                txtEmail.Text = obj.Email;
                txtEndereco.Text = obj.Endereco;
                
                tabControlCliente.SelectedIndex = 1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdDados2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("Deseja excluir esse Cliente?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var obj = (Cliente)grdDados2.CurrentRow.DataBoundItem;

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


        private void btnNovoCliente_Click_1(object sender, EventArgs e)
        {
            tabControlCliente.SelectedIndex = 1;
            LimparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClienteFiltro.Text != "")
                {
                    Filtro.Nome = txtClienteFiltro.Text;

                    grdDados2.AutoGenerateColumns = false;
                    grdDados2.DataSource = null;
                    grdDados2.DataSource = Filtro.clienteBuscarPorNome();
                    grdDados2.Show();
                }
                else
                {
                    DialogResult dialogresult = MessageBox.Show("Cliente não preenchido!", "Filtro", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNoFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                grdDados2.AutoGenerateColumns = false;
                grdDados2.DataSource = null;
                grdDados2.DataSource = Cliente.BuscarTodos();
                grdDados2.Show();
                LimparItens();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

