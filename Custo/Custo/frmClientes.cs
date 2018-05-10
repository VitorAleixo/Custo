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
            SortableBindingList<Cliente> _lst = new SortableBindingList<Cliente>();
            var lst = Cliente.BuscarTodos();
            foreach (var item in lst)
                _lst.Add(item);

            grdDados2.AutoGenerateColumns = false;
            grdDados2.DataSource = null;
            grdDados2.DataSource = _lst;
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
                txtNome.Enabled = true;
                if (obj.Nome.Length > 0 &&  obj.Endereco.Length > 0)
                {
                    if (obj.Id == 0)
                    {

                        obj.ChecarUsuarioInserir();
                        if (obj.CheckUser == true)
                        {
                            if (cmbCPF.SelectedItem.ToString() == "CPF" && txtCPF.Text.Length == 14)
                            {
                                obj.Inserir();
                                MessageBox.Show("Cliente incluído com sucesso!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LimparCampos();
                                tabControlCliente.SelectedIndex = 0;

                                CarregarGrid();
                            }
                            else if (cmbCPF.SelectedItem.ToString() == "CNPJ" && txtCPF.Text.Length == 18)
                            {
                                obj.Inserir();
                                MessageBox.Show("Cliente incluído com sucesso!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LimparCampos();
                                tabControlCliente.SelectedIndex = 0;

                                CarregarGrid();
                            }
                            else if (cmbCPF.SelectedItem.ToString() == "NÃO POSSUI" && txtCPF.Text.Length == 0)
                            {
                                obj.Inserir();
                                MessageBox.Show("Cliente incluído com sucesso!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LimparCampos();
                                tabControlCliente.SelectedIndex = 0;

                                CarregarGrid();
                            }
                            else
                            {
                                MessageBox.Show("Não foi possível incluir o cliente!\nCPF/CNPJ digitado está inválido!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
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
                            if (cmbCPF.SelectedItem.ToString() == "CPF" && txtCPF.Text.Length == 14)
                            {
                                obj.Atualizar();
                                MessageBox.Show("Cliente atualizado com sucesso", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LimparCampos();
                                tabControlCliente.SelectedIndex = 0;

                                CarregarGrid();
                            }
                            else if (cmbCPF.SelectedItem.ToString() == "CNPJ" && txtCPF.Text.Length == 18)
                            {
                                obj.Atualizar();
                                MessageBox.Show("Cliente atualizado com sucesso", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LimparCampos();
                                tabControlCliente.SelectedIndex = 0;

                                CarregarGrid();
                            }
                            else if (cmbCPF.SelectedItem.ToString() == "NÃO POSSUI" && txtCPF.Text.Length == 0)
                            {
                                obj.Atualizar();
                                MessageBox.Show("Cliente atualizado com sucesso", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LimparCampos();
                                tabControlCliente.SelectedIndex = 0;

                                CarregarGrid();
                            }
                            else
                            {
                                MessageBox.Show("Não foi possível incluir o cliente!\nCPF/CNPJ digitado está inválido!", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                               DialogResult dialogResult = MessageBox.Show("Este Usuario já Existe!", "Confirmação", MessageBoxButtons.OK);
                        }

                    }
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
            txtCPF.Mask = "";
            txtCPF.Enabled = false;
 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNome.Enabled = true;
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
                txtNome.Enabled = false;
                if (obj.CPF.ToString().Length == 14)
                {
                    cmbCPF.SelectedItem = "CPF";
                    txtCPF.Text = obj.CPF.ToString();
                    txtCPF.Enabled = true;
                }
                else if (obj.CPF.ToString().Length == 18)
                {
                    cmbCPF.SelectedItem = "CNPJ";
                    txtCPF.Text = obj.CPF.ToString();
                    txtCPF.Enabled = true;
                }
                else if (obj.CPF.ToString().Length == 0)
                {
                    cmbCPF.SelectedItem = "NÃO POSSUI";               
                    txtCPF.Text = obj.CPF.ToString();
                    txtCPF.Enabled = false;
                }
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
                        Pedido.IdCli = obj.Id.ToString();
                        Pedido.VerificarPedido();
                        if (Pedido.verificacao == true)
                        {
                            obj.Excluir();

                            CarregarGrid();

                            MessageBox.Show("Cliente excluído com sucesso", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel Excluir o Cliente, pois o mesmo\nEstá vinculado a um Pedido", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
            cmbCPF.SelectedItem = "NÃO POSSUI";
            txtNome.Enabled = true;
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

                    SortableBindingList<Cliente> _lst = new SortableBindingList<Cliente>();
                    var lst = Filtro.clienteBuscarPorNome();
                    foreach (var item in lst)
                        _lst.Add(item);

                    grdDados2.AutoGenerateColumns = false;
                    grdDados2.DataSource = null;
                    grdDados2.DataSource = _lst;
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
                SortableBindingList<Cliente> _lst = new SortableBindingList<Cliente>();
                var lst = Cliente.BuscarTodos(); ;
                foreach (var item in lst)
                    _lst.Add(item);

                grdDados2.AutoGenerateColumns = false;
                grdDados2.DataSource = null;
                grdDados2.DataSource = _lst;
                grdDados2.Show();
                LimparItens();
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

        private void grdDados2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in grdDados2.Rows)
                {
                    string RowType = row.Cells[1].Value.ToString();

                    if (RowType.Length == 14)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType.Length == 18)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType.Length == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Salmon;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

