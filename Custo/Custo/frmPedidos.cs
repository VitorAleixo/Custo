using Custo.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Custo
{
    public partial class frmPedidos : Form
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

        public void LimparItens()
        {
            cmbCliente.SelectedIndex = -1;
            txtDataAte.Text = "";
            txtDataDe.Text = "";
            cmbStatusFiltro.SelectedIndex = -1;
        }

        public void CarregarCombos()
        {
            cmbCliente.DataSource = null;
            cmbCliente.DataSource = Cliente.BuscarTodos().ToList();
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "Id";
            cmbCliente.SelectedIndex = -1;
            cmbStatusFiltro.SelectedIndex = -1;
        }

            public frmPedidos()
        {
            InitializeComponent();
            CarregarItens();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmPedidoNovo f = new frmPedidoNovo();
            f.CarregarCombos();
            this.Close();

            f.ShowDialog();
        }

     
        public void CarregarItens()
        {
            grdDadosPedido.AutoGenerateColumns = false;
            grdDadosPedido.DataSource = null;
            grdDadosPedido.DataSource = Pedido.BuscarTodos();
            grdDadosPedido.Show();

            decimal valorTotal = 0;
            foreach (DataGridViewRow col in grdDadosPedido.Rows)
            {
                valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
            }

            lblCustoTotal.Text = $"Valor Total dos Pedidos: R$ {valorTotal.ToString("N2")}";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Se este pedido for excluído \nNão aparecerá nos lucros mensais!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Deseja excluir esse Item?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var obj = (Pedido)grdDadosPedido.CurrentRow.DataBoundItem;

                    obj.Excluir();

                    CarregarItens();

                    MessageBox.Show("Pedido excluído com sucesso!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = (Pedido)grdDadosPedido.CurrentRow.DataBoundItem;

                frmPedidoNovo f = new frmPedidoNovo();
                f.txtId.Text = obj.Id.ToString();
                f.txtData.Text = obj.Data.ToString();
    
                f.CarregarCombos();
 
                f.cmbCliente.SelectedValue = obj.IdCliente;
                this.Close();
                f.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            CarregarCombos();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                //POR DATA
                if (cmbCliente.Text == "" && txtDataDe.Text != "  /  /" && txtDataAte.Text != "  /  /" && cmbStatusFiltro.Text == "")
                {
                    Filtro.dataDe = txtDataDe.Text;
                    Filtro.dataAte = txtDataAte.Text;

                    grdDadosPedido.AutoGenerateColumns = false;
                    grdDadosPedido.DataSource = null;
                    grdDadosPedido.DataSource = Filtro.pedidoFiltrarPorData();
                    grdDadosPedido.Show();
                    decimal valorTotal = 0;
                    foreach (DataGridViewRow col in grdDadosPedido.Rows)
                    {
                        valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
                    }
                    lblCustoTotal.Text = $"Valor Total dos Pedidos: R$ {valorTotal.ToString("N2")}";
                }
                //POR DATA E NOME
                else if (cmbCliente.Text != "" && txtDataDe.Text != "  /  /" && txtDataAte.Text != "  /  /" && cmbStatusFiltro.Text == "")
                {
                    Filtro.dataDe = txtDataDe.Text;
                    Filtro.dataAte = txtDataAte.Text;
                    Filtro.IdCliente = cmbCliente.SelectedValue.ToString();

                    grdDadosPedido.AutoGenerateColumns = false;
                    grdDadosPedido.DataSource = null;
                    grdDadosPedido.DataSource = Filtro.pedidoFiltrarPorNomeData();
                    grdDadosPedido.Show();

                    decimal valorTotal = 0;
                    foreach (DataGridViewRow col in grdDadosPedido.Rows)
                    {
                        valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
                    }
                    lblCustoTotal.Text = $"Valor Total dos Pedidos: R$ {valorTotal.ToString("N2")}";
                }
                //POR NOME
                else if (cmbCliente.Text != "" && txtDataDe.Text == "  /  /" && txtDataAte.Text == "  /  /" && cmbStatusFiltro.Text == "")
                {
                    Filtro.IdCliente = cmbCliente.SelectedValue.ToString();
                    grdDadosPedido.AutoGenerateColumns = false;
                    grdDadosPedido.DataSource = null;
                    grdDadosPedido.DataSource = Filtro.pedidoFiltrarPorNome();
                    grdDadosPedido.Show();


                    decimal valorTotal = 0;
                    foreach (DataGridViewRow col in grdDadosPedido.Rows)
                    {
                        valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
                    }
                    lblCustoTotal.Text = $"Valor Total dos Pedidos: R$ {valorTotal.ToString("N2")}";
                }
                //POR NOME E STATUS
                else if (cmbCliente.Text != "" && txtDataDe.Text == "  /  /" && txtDataAte.Text == "  /  /" && cmbStatusFiltro.Text != "")
                {
                    Filtro.IdCliente = cmbCliente.SelectedValue.ToString();
                    Filtro.statusPedido = cmbStatusFiltro.SelectedItem.ToString();
                    grdDadosPedido.AutoGenerateColumns = false;
                    grdDadosPedido.DataSource = null;
                    grdDadosPedido.DataSource = Filtro.pedidoFiltrarPorNomeStatus();
                    grdDadosPedido.Show();


                    decimal valorTotal = 0;
                    foreach (DataGridViewRow col in grdDadosPedido.Rows)
                    {
                        valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
                    }
                    lblCustoTotal.Text = $"Valor Total dos Pedidos: R$ {valorTotal.ToString("N2")}";
                }
                //POR DATA E STATUS
                else if (cmbCliente.Text == "" && txtDataDe.Text != "  /  /" && txtDataAte.Text != "  /  /" && cmbStatusFiltro.Text != "")
                {
                    Filtro.statusPedido = cmbStatusFiltro.SelectedItem.ToString();
                    Filtro.dataDe = txtDataDe.Text;
                    Filtro.dataAte = txtDataAte.Text;
                    grdDadosPedido.AutoGenerateColumns = false;
                    grdDadosPedido.DataSource = null;
                    grdDadosPedido.DataSource = Filtro.pedidoFiltrarPorDataStatus();
                    grdDadosPedido.Show();


                    decimal valorTotal = 0;
                    foreach (DataGridViewRow col in grdDadosPedido.Rows)
                    {
                        valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
                    }
                    lblCustoTotal.Text = $"Valor Total dos Pedidos: R$ {valorTotal.ToString("N2")}";
                }
                //POR DATA, NOME E STATUS
                else if (cmbCliente.Text != "" && txtDataDe.Text != "  /  /" && txtDataAte.Text != "  /  /" && cmbStatusFiltro.Text != "")
                {
                    Filtro.IdCliente = cmbCliente.SelectedValue.ToString();
                    Filtro.dataDe = txtDataDe.Text;
                    Filtro.dataAte = txtDataAte.Text;
                    Filtro.statusPedido = cmbStatusFiltro.SelectedItem.ToString();
                    grdDadosPedido.AutoGenerateColumns = false;
                    grdDadosPedido.DataSource = null;
                    grdDadosPedido.DataSource = Filtro.pedidoFiltrarPorNomeDataStatus();
                    grdDadosPedido.Show();


                    decimal valorTotal = 0;
                    foreach (DataGridViewRow col in grdDadosPedido.Rows)
                    {
                        valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
                    }
                    lblCustoTotal.Text = $"Valor Total dos Pedidos: R$ {valorTotal.ToString("N2")}";
                }
                //POR STATUS
                else if (cmbCliente.Text == "" && txtDataDe.Text == "  /  /" && txtDataAte.Text == "  /  /" && cmbStatusFiltro.Text != "")
                {
                    Filtro.statusPedido = cmbStatusFiltro.SelectedItem.ToString();
                    grdDadosPedido.AutoGenerateColumns = false;
                    grdDadosPedido.DataSource = null;
                    grdDadosPedido.DataSource = Filtro.pedidoFiltrarPorStatus();
                    grdDadosPedido.Show();


                    decimal valorTotal = 0;
                    foreach (DataGridViewRow col in grdDadosPedido.Rows)
                    {
                        valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
                    }
                    lblCustoTotal.Text = $"Valor Total dos Pedidos: R$ {valorTotal.ToString("N2")}";
                }

                else if (cmbCliente.Text == "" && txtDataDe.Text == "  /  /" && txtDataAte.Text == "  /  /")
                {
                    DialogResult dialogResult = MessageBox.Show("Não se pode fazer filtro de dados nulos!", "Confirmação", MessageBoxButtons.OK);
                }
                else if (txtDataDe.Text != "  /  /" && txtDataAte.Text == "  /  /")
                {
                    DialogResult dialogResult = MessageBox.Show("Não se pode fazer filtro apenas com a Data Inicial!", "Confirmação", MessageBoxButtons.OK);
                }
                else if (txtDataDe.Text == "  /  /" && txtDataAte.Text != "  /  /")
                {
                    DialogResult dialogResult = MessageBox.Show("Não se pode fazer filtro apenas com a Data Final!", "Confirmação", MessageBoxButtons.OK);
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
                grdDadosPedido.AutoGenerateColumns = false;
                grdDadosPedido.DataSource = null;
                grdDadosPedido.DataSource = Pedido.BuscarTodos();
                grdDadosPedido.Show();
                LimparItens();

                decimal valorTotal = 0;
                foreach (DataGridViewRow col in grdDadosPedido.Rows)
                {
                    valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
                }

                lblCustoTotal.Text = $"Valor Total dos Pedidos: R$ {valorTotal.ToString("N2")}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

