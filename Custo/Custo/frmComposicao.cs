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
    public partial class frmComposicao : Form
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

        void CarregarCombos()
        {
            cmbComposicao.DataSource = null;
            cmbComposicao.DataSource = Produto.BuscarTodos().Where(p => p.Tipo == "Produto Final").ToList();
            cmbComposicao.DisplayMember = "Descricao";            

            cmbProduto.DataSource = null;
            cmbProduto.DataSource = Produto.BuscarTodos().Where(p => p.Tipo == "Matéria Prima").ToList();
            cmbProduto.DisplayMember = "Descricao";            
        }

        void CarregarItens()
        {
            grdDados.AutoGenerateColumns = false;
            grdDados.DataSource = null;

            var composicao = Composicao.BuscarTodos().Where(c => c.IdProduto == ((Produto)cmbComposicao.SelectedItem).Id).FirstOrDefault();
            var produto = Produto.BuscarTodos().Where(f => f.Id == ((Produto)cmbComposicao.SelectedItem).Id).FirstOrDefault();

            lblCustoTotal.Text = $"Custo Total: R$ 0,00";

            if (composicao != null)
            {
                var lst = ComposicaoItem.BuscarTodos().Where(i => i.IdComposicao == composicao.Id).ToList();

                var custo = lst.Sum(i => i.Custo);

                lblCustoTotal.Text = $"Custo Total: R$ {custo.ToString("N2")}";

                var lst2 = Produto.BuscarTodos().Where(i => i.Id == produto.Id).ToList();
                var custo2 = produto.PrecoCompra;
                lblCustoProduto.Text = $"Custo do Produto: R$ {custo2.ToString("N2")}";

                var lucro = custo2 - custo;
                lblLucro.Text = $"Lucro: R$ {lucro.ToString("N2")}";
                grdDados.DataSource = lst;
            }

            grdDados.Show();
            
        }

        public frmComposicao()
        {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarCombos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cmbComposicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CarregarItens();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProduto.Text != "" && cmbComposicao.Text != "")
                {
                    var item = new ComposicaoItem();

                    item.IdProduto = ((Produto)cmbProduto.SelectedItem).Id;
                    item.Quantidade = Convert.ToDouble(txtQuantidade.Text);

                    var composicao = Composicao.BuscarTodos().Where(c => c.IdProduto == ((Produto)cmbComposicao.SelectedItem).Id).FirstOrDefault();

                    if (composicao != null && composicao.Id > 0)
                    {
                        item.IdComposicao = composicao.Id;
                    }
                    else
                    {
                        var compInserir = new Composicao();

                        compInserir.IdProduto = ((Produto)cmbComposicao.SelectedItem).Id;
                        compInserir.CustoTotal = 0;

                        compInserir.Inserir();

                        composicao = Composicao.BuscarTodos().Where(c => c.IdProduto == ((Produto)cmbComposicao.SelectedItem).Id).FirstOrDefault();

                        item.IdComposicao = composicao.Id;
                    }

                    item.Inserir();

                    MessageBox.Show("Item inserido com sucesso!", "Item", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();

                    CarregarItens();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Produto ou Matéria-Prima não Preenchidos!", "Confirmacão", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void LimparCampos()
        {
            txtQuantidade.Text = "0";
            cmbProduto.SelectedIndex = 0;
        }

        private void grdDados_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("Deseja excluir esse Item?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var obj = (ComposicaoItem)grdDados.CurrentRow.DataBoundItem;

                        obj.Excluir();

                        CarregarItens();

                        MessageBox.Show("Item excluído com sucesso!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
