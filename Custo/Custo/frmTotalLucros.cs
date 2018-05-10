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
    public partial class frmTotalLucros : Form
    {
        public frmTotalLucros()
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
                if (txtDiaD.Text != "  /  /" && txtMesM.Text == "" && txtAnoM.Text == "" && txtAnoA.Text == "" && txtDeT.Text == "  /  /" && txtAteT.Text == "  /  /" && txtDiaD.TextLength == 10 && txtDiaD.Text.Substring(0, 2) != "00" && txtDiaD.Text.Substring(3, 2) != "00" && txtDiaD.Text.Substring(6, 4) != "0000")
                {
                    //BUSCA POR DIA
                    Filtro.dataDia = txtDiaD.Text;
                    grdLucro.AutoGenerateColumns = false;
                    grdLucro.DataSource = null;
                    grdLucro.DataSource = Filtro.lucroFiltrarPorDia();
                    grdLucro.Show();

                    decimal valorTotal = 0;
                    foreach (DataGridViewRow col in grdLucro.Rows)
                    {
                        valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
                    }
                    lblCustoTotal.Text = $"Total: R$ {valorTotal.ToString("N2")}";
                }
                else if (txtDiaD.Text == "  /  /" && txtMesM.Text != "" && txtAnoM.Text != "" && txtAnoA.Text == "" && txtDeT.Text == "  /  /" && txtAteT.Text == "  /  /" && txtAnoM.TextLength == 4 && txtMesM.TextLength == 2 && txtAnoM.Text.Substring(0, 4) != "0000" && txtMesM.Text.Substring(0, 2) != "00")
                {
                    //BUSCA POR MES
                    Filtro.dataMes = txtMesM.Text;
                    Filtro.dataAno = txtAnoM.Text;
                    grdLucro.AutoGenerateColumns = false;
                    grdLucro.DataSource = null;
                    grdLucro.DataSource = Filtro.lucroFiltrarPorMes();
                    grdLucro.Show();

                    decimal valorTotal = 0;
                    foreach (DataGridViewRow col in grdLucro.Rows)
                    {
                        valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
                    }
                    lblCustoTotal.Text = $"Total: R$ {valorTotal.ToString("N2")}";
                }
                else if (txtDiaD.Text == "  /  /" && txtMesM.Text == "" && txtAnoM.Text == "" && txtAnoA.Text != "" && txtDeT.Text == "  /  /" && txtAteT.Text == "  /  /" && txtAnoA.TextLength == 4 && txtAnoA.Text.Substring(0, 4) != "0000")
                {
                    //BUSCA POR ANO
                    Filtro.dataAno = txtAnoA.Text;
                    grdLucro.AutoGenerateColumns = false;
                    grdLucro.DataSource = null;
                    grdLucro.DataSource = Filtro.lucroFiltrarPorAno();
                    grdLucro.Show();

                    decimal valorTotal = 0;
                    foreach (DataGridViewRow col in grdLucro.Rows)
                    {
                        valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
                    }
                    lblCustoTotal.Text = $"Total: R$ {valorTotal.ToString("N2")}";
                }
                else if (txtDiaD.Text == "  /  /" && txtMesM.Text == "" && txtAnoM.Text == "" && txtAnoA.Text == "" && txtDeT.Text != "  /  /" && txtAteT.Text != "  /  /" && txtDeT.TextLength == 10 && txtDiaD.Text.Substring(0, 2) != "00" && txtDeT.Text.Substring(3, 2) != "00" && txtDeT.Text.Substring(6, 4) != "0000" && txtDeT.TextLength == 10 && txtAteT.Text.Substring(0, 2) != "00" && txtAteT.Text.Substring(3, 2) != "00" && txtAteT.Text.Substring(6, 4) != "0000")
                {
                    //BUSCA POR TUDO
                    Filtro.dataDeLucro = txtDeT.Text;
                    Filtro.dataAteLucro = txtAteT.Text;
                    grdLucro.AutoGenerateColumns = false;
                    grdLucro.DataSource = null;
                    grdLucro.DataSource = Filtro.lucroFiltrarPorTudo();
                    grdLucro.Show();

                    decimal valorTotal = 0;
                    foreach (DataGridViewRow col in grdLucro.Rows)
                    {
                        valorTotal = valorTotal + Convert.ToDecimal(col.Cells[2].Value);
                    }
                    lblCustoTotal.Text = $"Total: R$ {valorTotal.ToString("N2")}";
                }
                else if (txtDiaD.Text == "  /  /" && txtMesM.Text == "" && txtAnoM.Text == "" && txtAnoA.Text == "" && txtDeT.Text == "  /  /" && txtAteT.Text == "  /  /")
                {
                    DialogResult dialogResult = MessageBox.Show("Não é possivel buscar dados Nulos!\nOu algum dado informado Incorretamente", "Confirmação", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
