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
    public partial class frmPedidoNovo : Form
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
            cmbCliente.DataSource = null;
            cmbCliente.DataSource = Cliente.BuscarTodos().ToList();
            cmbCliente.DisplayMember = "Nome";

            cmbProduto.DataSource = null;
            cmbProduto.DataSource = Produto.BuscarTodos().Where(p => p.Tipo == "Produto Final").ToList();
            cmbProduto.DisplayMember = "Descricao";
        }

        void CarregarItens()
        {

            grdNovoPedido.AutoGenerateColumns = false;
            grdNovoPedido.DataSource = null;

            lblCustoTotal.Text = $"Custo Total: R$ 0,00";


            var pedido = PedidoItem.TabelaBuscarTodos();//.Where(c => c.IdProduto == ((Produto)cmbProduto.SelectedItem).Id).FirstOrDefault();
            var produto = Produto.BuscarTodos().Where(f => f.Id == ((Produto)cmbProduto.SelectedItem).Id).FirstOrDefault();

            if (pedido != null)
            {

                //var lst = PedidoItem.BuscarTodos().Where(i => i.IdPedido == pedido.Id).ToList();
                var lst = PedidoItem.TabelaBuscarTodos().Where(i => i.IdPedido == 0).ToList();

                var custo = lst.Sum(i => i.CustoTotal);

                lblCustoTotal.Text = $"Custo Total: R$ {custo.ToString("N2")}";

                grdNovoPedido.DataSource = lst;
            }

            grdNovoPedido.Show();

        }

        void CarregarItensEditar()
        {

            grdNovoPedido.AutoGenerateColumns = false;
            grdNovoPedido.DataSource = null;

            lblCustoTotal.Text = $"Custo Total: R$ 0,00";


            var pedido = PedidoItem.TabelaBuscarTodos();//.Where(c => c.IdProduto == ((Produto)cmbProduto.SelectedItem).Id).FirstOrDefault();
            //SELECT PRODUTO
            if (pedido != null)
            {

                //AQUI!!!!
                Pedido p = new Pedido();
                var _Id = int.Parse(txtId.Text);
                var lst = PedidoItem.BuscarTodos().Where(i => i.IdPedido == _Id || i.IdPedido == 0).ToList();

                var custo = lst.Sum(i => i.CustoTotal);

                lblCustoTotal.Text = $"Custo Total: R$ {custo.ToString("N2")}";

                grdNovoPedido.DataSource = lst;
            }

            grdNovoPedido.Show();

        }

        private void frmPedidoNovo_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarCombos();

                cmbCliente.SelectedIndex = -1;
                cmbProduto.SelectedIndex = -1;

                CarregarItensEditar();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        public frmPedidoNovo()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtQuantidade.Text = "0";
            txtObservacao.Text = "0";
            txtData.Text = "";
            cmbCliente.SelectedIndex = 0;
            cmbProduto.SelectedIndex = 0;
        }

        private void LimparCampos2()
        {
            txtQuantidade.Text = "0";
            txtObservacao.Text = "0";
            cmbProduto.SelectedIndex = 0;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbProduto.Text != "" && cmbCliente.Text != "")
                {


                    var item = new PedidoItem();
                    frmPedidos f = new frmPedidos();

                    item.IdProduto = ((Produto)cmbProduto.SelectedItem).Id;
                    item.Quantidade = Convert.ToDouble(txtQuantidade.Text);
                    item.Observacoes = txtObservacao.Text;


                    var pedido = Pedido.BuscarTodos().Where(c => c.IdCliente == ((Cliente)cmbCliente.SelectedItem).Id).FirstOrDefault();

                    if (pedido != null && pedido.Id > 0)
                    {
                        item.IdPedido = pedido.Id;
                    }
                    else
                    {
                        var pedidoInserir = new Pedido();

                        pedidoInserir.IdCliente = ((Cliente)cmbCliente.SelectedItem).Id;
                        pedidoInserir.Data = txtData.Text;

                        pedido = Pedido.BuscarTodos().Where(c => c.IdCliente == ((Cliente)cmbCliente.SelectedItem).Id).FirstOrDefault();

                        //pedidoInserir.Inserir();
                        // item.IdPedido = pedido.Id;
                    }

                    item.Inserir();

                    MessageBox.Show("Item inserido com sucesso!", "Item", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos2();

                    CarregarItens();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Produto ou Cliente não Preenchidos!", "Confirmacão", MessageBoxButtons.OK);
                }
        }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdNovoPedido_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                if (cmbProduto.Text != "" && cmbCliente.Text != "")
                {

                    if (e.KeyCode == Keys.Delete)
                    {
                        if (MessageBox.Show("Deseja excluir esse Item?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            frmPedidos f = new frmPedidos();
                            var obj = (PedidoItem)grdNovoPedido.CurrentRow.DataBoundItem;

                            obj.Excluir();

                            MessageBox.Show("Item excluído com sucesso!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarItens();
                        }
                    }

                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Produto ou Cliente não Preenchidos!", "Confirmacão", MessageBoxButtons.OK);
                }
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
                if (cmbProduto.Text != "" && cmbCliente.Text != "")
                {
                    var pedidoInserir = new Pedido();

                pedidoInserir.Id = int.Parse(txtId.Text);
                pedidoInserir.IdCliente = ((Cliente)cmbCliente.SelectedItem).Id;
                pedidoInserir.Data = txtData.Text;

                var pedido = Pedido.BuscarTodos().Where(c => c.IdCliente == ((Cliente)cmbCliente.SelectedItem).Id).FirstOrDefault();
                
                    if (pedidoInserir.Id == 0)
                    {
                        if (grdNovoPedido.Rows.Count > 0)
                        {
                            pedidoInserir.Inserir();
                            MessageBox.Show("Pedido inserido com sucesso!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        pedidoInserir.Atualizar();
                        MessageBox.Show("Pedido Atualizado com sucesso!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmPedidos f = new frmPedidos();
                    }


                    this.Close();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Produto ou Cliente não Preenchidos!", "Confirmacão", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja Sair?\nSe houver dados digitados, os mesmos serão perdidos!", "Confirmacão", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Pedido pedido = new Pedido();
                pedido.LimparTabela();

                this.Close();
            }
          
        }
    }
}

