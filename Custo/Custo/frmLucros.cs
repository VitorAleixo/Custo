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
            frmTotalLucros f = new frmTotalLucros();
            f.txtDiaD.Text = "";

            f.txtAnoM.Text = "";
            f.txtMesM.Text = "";

            f.txtAnoA.Text = "";
            
            f.txtDeT.Text = "";
            f.txtAteT.Text = "";

        }

        public frmLucros()
        {
            InitializeComponent();
        }
 
        private void btnDiario_Click(object sender, EventArgs e)
        {
            frmTotalLucros f = new frmTotalLucros();
            f.grdLucro.ResumeLayout();
            f.gbDiario.Enabled = true;
            f.txtDiaD.Enabled = true;

            f.gbMensal.Enabled = false;
            f.txtAnoM.Enabled = false;
            f.txtMesM.Enabled = false;

            f.gbAnual.Enabled = false;
            f.txtAnoA.Enabled = false;

            f.gbTodos.Enabled = false;
            f.txtDeT.Enabled = false;
            f.txtAteT.Enabled = false;

            LimparItens();
            f.ShowDialog();
            f.grdLucro.SuspendLayout();
        }

        private void btnMensal_Click(object sender, EventArgs e)
        {
            frmTotalLucros f = new frmTotalLucros();
            f.grdLucro.ResumeLayout();
            f.gbDiario.Enabled = false;
            f.txtDiaD.Enabled = false;

            f.gbMensal.Enabled = true;
            f.txtAnoM.Enabled = true;
            f.txtMesM.Enabled = true;

            f.gbAnual.Enabled = false;
            f.txtAnoA.Enabled = false;

            f.gbTodos.Enabled = false;
            f.txtDeT.Enabled = false;
            f.txtAteT.Enabled = false;

            LimparItens();
            f.ShowDialog();
            f.grdLucro.SuspendLayout();
        }

        private void btnAnual_Click(object sender, EventArgs e)
        {
            frmTotalLucros f = new frmTotalLucros();
            f.grdLucro.ResumeLayout();
            f.gbDiario.Enabled = false;
            f.txtDiaD.Enabled = false;

            f.gbMensal.Enabled = false;
            f.txtAnoM.Enabled = false;
            f.txtMesM.Enabled = false;

            f.gbAnual.Enabled = true;
            f.txtAnoA.Enabled = true;

            f.gbTodos.Enabled = false;
            f.txtDeT.Enabled = false;
            f.txtAteT.Enabled = false;

            LimparItens();
            f.ShowDialog();
            f.grdLucro.SuspendLayout();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            frmTotalLucros f = new frmTotalLucros();
            f.grdLucro.ResumeLayout();
            f.gbDiario.Enabled = false;
            f.txtDiaD.Enabled = false;

            f.gbMensal.Enabled = false;
            f.txtAnoM.Enabled = false;
            f.txtMesM.Enabled = false;

            f.gbAnual.Enabled = false;
            f.txtAnoA.Enabled = false;

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
