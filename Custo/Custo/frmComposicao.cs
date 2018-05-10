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
        string Verificacao;
        void CarregarCombos()
        {
            cmbComposicao.DataSource = null;
            cmbComposicao.DataSource = Produto.BuscarTodos().Where(p => p.Tipo == "Produto Final").ToList();
            cmbComposicao.DisplayMember = "Descricao";
            cmbComposicao.Enabled = true;
            Verificacao = "Ok";
            cmbComposicao.SelectedIndex = -1;

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

            lblCustoTotal.Text = $"Custo Total: R$";
            lblCustoTotalProduto.Text = $"0,00";
            lblCustoProduto.Text = $"Custo de Mercado: R$ 0,00";
            lblEconomia.Text = $"Economia: R$ 0,00";

            lblPrecoVenda.Text = $"Preço de Venda: R$ 0,00";
            lblLucroTotal.Text = $"Lucro: R$";
            lblLucro.Text = $"0,00";

            if (composicao != null)
            {
                var lst = ComposicaoItem.BuscarTodos().Where(i => i.IdComposicao == composicao.Id).ToList();

                var custo = lst.Sum(i => i.Custo);

                lblCustoTotal.Text = $"Custo Total: R$";
                lblCustoTotalProduto.Text = custo.ToString("N2");

                double custovalor = custo;
                var lst2 = Produto.BuscarTodos().Where(i => i.Id == produto.Id).ToList();
                var custoProduto = produto.PrecoCompra;
                lblCustoProduto.Text = $"Custo de Mercado: R$ {custoProduto.ToString("N2")}";

                var economia = custoProduto - custo;
                lblEconomia.Text = $"Economia: R$ {economia.ToString("N2")}";

                Composicao c = new Composicao();
                c.IdProduto = ((Produto)cmbComposicao.SelectedItem).Id;
                c.VerificarVenda();

                var precoVenda = c.CustoVenda;
                lblPrecoVenda.Text = $"Preço de Venda: R$ {precoVenda.ToString("N2") }";


                var lucro = economia + (precoVenda - custoProduto);
                lblLucroTotal.Text = $"Lucro: R$";
                lblLucro.Text = lucro.ToString("N2");

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
                txtValorVenda.Enabled = false;
                btnInserirVenda.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbComposicao_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                        compInserir.Inserir();

                        composicao = Composicao.BuscarTodos().Where(c => c.IdProduto == ((Produto)cmbComposicao.SelectedItem).Id).FirstOrDefault();

                        item.IdComposicao = composicao.Id;
                    }

                    item.Inserir();

                    MessageBox.Show("Item inserido com sucesso!", "Item", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();

                    CarregarItens();

                    Composicao com = new Composicao();
                    com.CustoTotal = Double.Parse(lblCustoTotalProduto.Text.Replace(".", ","));
                    com.IdProduto = ((Produto)cmbComposicao.SelectedItem).Id;
                    com.GravarCusto();


                    com.Lucro = Double.Parse(lblLucro.Text.Replace(".", ","));
                    com.GravarLucro();

                    btnInserirVenda.Enabled = true;
                    txtValorVenda.Enabled = true;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Produto ou Matéria-Prima não Preenchidos!", "Confirmação", MessageBoxButtons.OK);
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
            txtValorVenda.Text = "";
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

                        Composicao com = new Composicao();
                        com.CustoTotal = Double.Parse(lblCustoTotalProduto.Text.Replace(".", ","));
                        com.IdProduto = ((Produto)cmbComposicao.SelectedItem).Id;
                        com.GravarCusto();

                        com.Lucro = Double.Parse(lblLucro.Text.Replace(".", ","));
                        com.GravarLucro();

                        MessageBox.Show("Item excluído com sucesso!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            try
            {
                Composicao c = new Composicao();
                if (cmbComposicao.SelectedIndex != -1)
                {
                    c.IdProduto = ((Produto)cmbComposicao.SelectedItem).Id;
                    c.VerificarVenda();
                    if (c.CustoVenda != 0)
                    {
                        btnInserirVenda.Enabled = false;
                        txtValorVenda.Enabled = false;
                        c.Lucro = Double.Parse(lblLucro.Text.Replace(".", ","));
                        c.GravarLucro();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Valor de VENDA Não inserido! Favor adicionar!", "Confirmação", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInserirVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbComposicao.Text == "")
                {
                    DialogResult dialogResult = MessageBox.Show("Produto não Preenchido!", "Confirmação", MessageBoxButtons.OK);
                }
                else
                {
                    Composicao c = new Composicao();
                    c.CustoVenda = Double.Parse(txtValorVenda.Text.Replace(".", ","));
                    c.IdProduto = ((Produto)cmbComposicao.SelectedItem).Id;

                    c.GravarVenda();

                    MessageBox.Show("Valor de VENDA Incluido!", "Confirmação", MessageBoxButtons.OK);
                    CarregarItens();

                    c.Lucro = Double.Parse(lblLucro.Text.Replace(".", ","));
                    c.GravarLucro();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbComposicao_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbComposicao.SelectedIndex != -1)
            {
                cmbComposicao.Enabled = false;
                var composicao = Composicao.BuscarTodos().Where(c => c.IdProduto == ((Produto)cmbComposicao.SelectedItem).Id).FirstOrDefault();
                if (Verificacao == "Ok")
                {
                    CarregarItens();
                }
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbComposicao.Text == "")
                {
                    DialogResult dialogResult = MessageBox.Show("Produto não Preenchido!", "Confirmação", MessageBoxButtons.OK);
                }
                else
                {
                    Composicao c = new Composicao();
                    c.IdProduto = ((Produto)cmbComposicao.SelectedItem).Id;
                    c.VerificarVenda();
                    if (c.CustoVenda != 0)
                    {
                        cmbComposicao.Enabled = true;
                        c.Lucro = Double.Parse(lblLucro.Text.Replace(".", ","));
                        c.GravarLucro();
                        txtValorVenda.Text = "";
                        txtValorVenda.Enabled = false;
                        btnInserirVenda.Enabled = false;
                        MessageBox.Show("Produto para selecionar Desbloqueado!", "Confirmação", MessageBoxButtons.OK);

                    }
                    else
                    {
                        MessageBox.Show("Valor de VENDA Não inserido! Favor adicionar!", "Confirmação", MessageBoxButtons.OK);
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
