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
    public partial class frmRanking : Form
    {
        public frmRanking()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            frmRankingProdutos rk = new frmRankingProdutos();
            rk.ShowDialog();
        }

        private void btnAnual_Click(object sender, EventArgs e)
        {
            frmRankingClientes rk = new frmRankingClientes();
            rk.ShowDialog();
        }
    }
}
