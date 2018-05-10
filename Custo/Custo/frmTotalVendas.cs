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
    public partial class frmTotalVendas : Form
    {
        public frmTotalVendas()
        {
            InitializeComponent();
        }

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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDiaD.Enabled == true && cmbMesM.Enabled == false && cmbAnoM.Enabled == false && cmbAnoA.Enabled == false && txtDeT.Enabled == false && txtAteT.Enabled == false)
                {
                    //BUSCA POR DIA
                    Filtro.dataDia = txtDiaD.Text;

                    SortableBindingList<Pedido> _lst = new SortableBindingList<Pedido>();
                    var lst = Filtro.lucroFiltrarPorDia();
                    foreach (var item in lst)
                        _lst.Add(item);

                    grdLucro.AutoGenerateColumns = false;
                    grdLucro.DataSource = null;
                    grdLucro.DataSource = _lst;
                    grdLucro.Show();

                    decimal valorTotal = 0;
                    foreach (DataGridViewRow col in grdLucro.Rows)
                    {
                        valorTotal = valorTotal + Convert.ToDecimal(col.Cells[3].Value);
                    }
                    lblCustoTotal.Text = $"Total de Vendas: R$ {valorTotal.ToString("N2")}";
                }
                else if (txtDiaD.Enabled == false && cmbMesM.Enabled == true && cmbAnoM.Enabled == true && cmbAnoA.Enabled == false && txtDeT.Enabled == false && txtAteT.Enabled == false)
                {
                    //BUSCA POR MES
                    Filtro.dataMes = cmbMesM.Text;
                    Filtro.dataAno = cmbAnoM.Text;

                    SortableBindingList<Pedido> _lst = new SortableBindingList<Pedido>();
                    var lst = Filtro.lucroFiltrarPorMes();
                    foreach (var item in lst)
                        _lst.Add(item);

                    grdLucro.AutoGenerateColumns = false;
                    grdLucro.DataSource = null;
                    grdLucro.DataSource = _lst;
                    grdLucro.Show();

                    decimal valorTotal = 0;
                    foreach (DataGridViewRow col in grdLucro.Rows)
                    {
                        valorTotal = valorTotal + Convert.ToDecimal(col.Cells[3].Value);
                    }
                    lblCustoTotal.Text = $"Total de Vendas: R$ {valorTotal.ToString("N2")}";
                }
                else if (txtDiaD.Enabled == false && cmbMesM.Enabled == false && cmbAnoM.Enabled == false && cmbAnoA.Enabled == true && txtDeT.Enabled == false && txtAteT.Enabled == false)
                {
                    //BUSCA POR ANO
                    Filtro.dataAno = cmbAnoA.Text;

                    SortableBindingList<Pedido> _lst = new SortableBindingList<Pedido>();
                    var lst = Filtro.lucroFiltrarPorAno();
                    foreach (var item in lst)
                        _lst.Add(item);

                    grdLucro.AutoGenerateColumns = false;
                    grdLucro.DataSource = null;
                    grdLucro.DataSource = _lst;
                    grdLucro.Show();

                    decimal valorTotal = 0;
                    foreach (DataGridViewRow col in grdLucro.Rows)
                    {
                        valorTotal = valorTotal + Convert.ToDecimal(col.Cells[3].Value);
                    }
                    lblCustoTotal.Text = $"Total de Vendas: R$ {valorTotal.ToString("N2")}";
                }
                else if (txtDiaD.Enabled == false && cmbMesM.Enabled == false && cmbAnoM.Enabled == false && cmbAnoA.Enabled == false && txtDeT.Enabled == true && txtAteT.Enabled == true)
                {
                    //BUSCA POR TUDO

                    Filtro.dataDeLucro = txtDeT.Text;
                    Filtro.dataAteLucro = txtAteT.Text;

                    SortableBindingList<Pedido> _lst = new SortableBindingList<Pedido>();
                    var lst = Filtro.lucroFiltrarPorTudo();
                    foreach (var item in lst)
                        _lst.Add(item);

                    grdLucro.AutoGenerateColumns = false;
                    grdLucro.DataSource = null;
                    grdLucro.DataSource = _lst;
                    grdLucro.Show();

                    decimal valorTotal = 0;
                    foreach (DataGridViewRow col in grdLucro.Rows)
                    {
                        valorTotal = valorTotal + Convert.ToDecimal(col.Cells[3].Value);
                    }
                    lblCustoTotal.Text = $"Total de Vendas: R$ {valorTotal.ToString("N2")}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTotalLucros_Load(object sender, EventArgs e)
        {
            txtDeT.Text = "01/01/2001"; 
            txtAteT.Text = "01/01/2001"; 
            txtDiaD.Text = "01/01/2001";
        }

        private void txtDiaD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        private void txtDeT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        private void txtAteT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        private void grdLucro_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in grdLucro.Rows)
                {
                    string RowType = row.Cells[0].Value.ToString();

                    if (RowType == "COMPLETO")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "PRODUÇÃO")
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "INCOMPLETO")
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
