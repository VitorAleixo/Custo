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
    public partial class frmRankingProdutos : Form
    {
        public frmRankingProdutos()
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
            Ranking rk = new Ranking();
            rk.SairRanking();
            this.Close();
        }

        private void frmRanking_Load(object sender, EventArgs e)
        {

            Ranking rk = new Ranking();
            rk.SairRanking();
            rk.InserirRanking();
            SortableBindingList<Ranking> _lst = new SortableBindingList<Ranking>();
            var lst = Ranking.TabelaPedido();
            foreach (var item in lst)
                _lst.Add(item);

            grdRanking.AutoGenerateColumns = false;
            grdRanking.DataSource = null;
            grdRanking.DataSource = _lst;
            grdRanking.Show();
        }

        private void grdRanking_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in grdRanking.Rows)
                {
                    string RowType = row.Cells[0].Value.ToString();

                    row.DefaultCellStyle.BackColor = Color.Silver;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    if (RowType == "1")
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "2")
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "3")
                    {
                        row.DefaultCellStyle.BackColor = Color.Orange;
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
