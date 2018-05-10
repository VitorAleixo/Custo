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

        public frmPedidos()
        {
            InitializeComponent();
            CarregarItens();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.Close();
                new frmPedidoNovo {StartPosition = FormStartPosition.CenterParent }.ShowDialog();
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
                if (MessageBox.Show("Deseja excluir esse Item?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var obj = (Pedido)grdDadosPedido.CurrentRow.DataBoundItem;

                    obj.Excluir();

                    CarregarItens();

                    MessageBox.Show("Item excluído com sucesso!", "PedidoItem", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                int IdCli = obj.IdCliente;
                
                frmPedidoNovo f = new frmPedidoNovo();
                f.txtId.Text = obj.Id.ToString();
                f.txtData.Text = obj.Data.ToString();
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
    }
    
}
