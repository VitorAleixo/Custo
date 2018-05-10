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
    public partial class frmProduto : Form
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
            grdDados.AutoGenerateColumns = false;
            grdDados.DataSource = null;
            grdDados.DataSource = Produto.BuscarTodos();
            grdDados.Show();
        }

        public frmProduto()
        {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipo.Text != "" && cmbUnidadeMedida.Text != "" && txtCodigo.Text != "" && txtDescricao.Text != "" && txtPrecoCompra.Text != "")
                {
                    var obj = new Produto();

                    obj.Id = int.Parse(txtId.Text);
                    obj.Codigo = txtCodigo.Text;
                    obj.Descricao = txtDescricao.Text;
                    obj.UM = cmbUnidadeMedida.SelectedItem.ToString();
                    obj.Tipo = cmbTipo.SelectedItem.ToString();
                    obj.PrecoCompra = Convert.ToDouble(txtPrecoCompra.Text);

                    if (obj.Codigo.Length > 0 && obj.Tipo.Length > 0 && obj.Descricao.Length > 0 && obj.UM.Length > 0)
                    {
                        if (obj.Id == 0)
                        {
                            obj.Inserir();
                            MessageBox.Show("Produto incluído com sucesso!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimparCampos();

                        }
                        else
                        {
                            obj.Atualizar();
                            MessageBox.Show("Produto atualizado com sucesso", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimparCampos();
                        }

                        tabControlProduto.SelectedIndex = 0;

                        CarregarGrid();
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Algum dado está faltando!", "Confirmacão", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Algum dado está Faltando!", "Confirmacão", MessageBoxButtons.OK);
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void LimparCampos()
        {
            txtId.Text = "0";
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            cmbUnidadeMedida.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            txtPrecoCompra.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LimparCampos();
                tabControlProduto.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var obj = (Produto)grdDados.CurrentRow.DataBoundItem;

                txtId.Text = obj.Id.ToString();
                txtCodigo.Text = obj.Codigo;
                txtDescricao.Text = obj.Descricao;
                cmbUnidadeMedida.SelectedItem = obj.UM;
                cmbTipo.SelectedItem = obj.Tipo;
                txtPrecoCompra.Text = obj.PrecoCompra.ToString();

                tabControlProduto.SelectedIndex = 1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdDados_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("Deseja excluir esse Produto?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var obj = (Produto)grdDados.CurrentRow.DataBoundItem;

                        obj.Excluir();

                        CarregarGrid();

                        MessageBox.Show("Produto excluído com sucesso", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControlProduto.SelectedIndex = 1;
            LimparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
