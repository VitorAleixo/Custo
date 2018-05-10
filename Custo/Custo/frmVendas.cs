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
    public partial class frmLucros : Form
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

        void LimparItens()
        {
            frmTotalVendas f = new frmTotalVendas();
 
            f.cmbAnoM.SelectedIndex = 0;
            f.cmbMesM.SelectedIndex = 0;

            f.cmbAnoA.SelectedIndex = 0;         
        }

        public frmLucros()
        {
            InitializeComponent();
        }
 
        private void btnDiario_Click(object sender, EventArgs e)
        {
            frmTotalVendas f = new frmTotalVendas();

            f.cmbAnoM.SelectedIndex = 0;
            f.cmbMesM.SelectedIndex = 0;

            f.cmbAnoA.SelectedIndex = 0;

            f.grdLucro.ResumeLayout();
            f.gbDiario.Enabled = true;
            f.txtDiaD.Enabled = true;

            f.gbMensal.Enabled = false;
            f.cmbAnoM.Enabled = false;
            f.cmbMesM.Enabled = false;

            f.gbAnual.Enabled = false;
            f.cmbAnoA.Enabled = false;

            f.gbTodos.Enabled = false;
            f.txtDeT.Enabled = false;
            f.txtAteT.Enabled = false;

            LimparItens();
            f.ShowDialog();
            f.grdLucro.SuspendLayout();
        }

        private void btnMensal_Click(object sender, EventArgs e)
        {
            frmTotalVendas f = new frmTotalVendas();

            f.cmbAnoM.SelectedIndex = 0;
            f.cmbMesM.SelectedIndex = 0;

            f.cmbAnoA.SelectedIndex = 0;
            
            f.grdLucro.ResumeLayout();
            f.gbDiario.Enabled = false;
            f.txtDiaD.Enabled = false;

            f.gbMensal.Enabled = true;
            f.cmbAnoM.Enabled = true;
            f.cmbMesM.Enabled = true;

            f.gbAnual.Enabled = false;
            f.cmbAnoA.Enabled = false;

            f.gbTodos.Enabled = false;
            f.txtDeT.Enabled = false;
            f.txtAteT.Enabled = false;

            LimparItens();
            f.ShowDialog();
            f.grdLucro.SuspendLayout();
        }

        private void btnAnual_Click(object sender, EventArgs e)
        {
            frmTotalVendas f = new frmTotalVendas();

            f.cmbAnoM.SelectedIndex = 0;
            f.cmbMesM.SelectedIndex = 0;

            f.cmbAnoA.SelectedIndex = 0;

            f.grdLucro.ResumeLayout();
            f.gbDiario.Enabled = false;
            f.txtDiaD.Enabled = false;

            f.gbMensal.Enabled = false;
            f.cmbAnoM.Enabled = false;
            f.cmbMesM.Enabled = false;

            f.gbAnual.Enabled = true;
            f.cmbAnoA.Enabled = true;

            f.gbTodos.Enabled = false;
            f.txtDeT.Enabled = false;
            f.txtAteT.Enabled = false;

            LimparItens();
            f.ShowDialog();
            f.grdLucro.SuspendLayout();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            frmTotalVendas f = new frmTotalVendas();

            f.cmbAnoM.SelectedIndex = 0;
            f.cmbMesM.SelectedIndex = 0;

            f.cmbAnoA.SelectedIndex = 0;

            f.grdLucro.ResumeLayout();
            f.gbDiario.Enabled = false;
            f.txtDiaD.Enabled = false;

            f.gbMensal.Enabled = false;
            f.cmbAnoM.Enabled = false;
            f.cmbMesM.Enabled = false;

            f.gbAnual.Enabled = false;
            f.cmbAnoA.Enabled = false;

            f.gbTodos.Enabled = true;
            f.txtDeT.Enabled = true;
            f.txtAteT.Enabled = true;

            LimparItens();
            f.ShowDialog();
            f.grdLucro.SuspendLayout();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
