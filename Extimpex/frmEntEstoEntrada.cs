using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Extimpex
{
    public partial class frmEntEsto : Form
    {
        public frmEntEsto()
        {
            InitializeComponent();
        }

        private void btnCons_Click(object sender, EventArgs e)
        {
            if (rdForn.Checked)
            {
                this.relacao_EstoqueTableAdapter.queryNomRaz(this.bancoExtimpexDataSet.Relacao_Estoque, txtPequ.Text);
            }
            else
                if (rdNotFisc.Checked)
                {
                    this.relacao_EstoqueTableAdapter.queryDescrNot(this.bancoExtimpexDataSet.Relacao_Estoque, txtPequ.Text);
                }
                else
                    MessageBox.Show("Selecione uma opção!");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEntEsto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoExtimpexDataSet.Relacao_Estoque' table. You can move, or remove it, as needed.
            this.relacao_EstoqueTableAdapter.queryConsult(this.bancoExtimpexDataSet.Relacao_Estoque);

        }

        private void btnCadNotFisc_Click_1(object sender, EventArgs e)
        {
            frmCadEntEsto AbriCadEst = new frmCadEntEsto();
            AbriCadEst.ShowDialog();
            AbriCadEst.Dispose();
        }

        private void btnDtllhNot_Click(object sender, EventArgs e)
        {
            frmDetalhes AbrirDetalhes = new frmDetalhes(this);
            AbrirDetalhes.ShowDialog();
            AbrirDetalhes.Dispose();
        }
    }
}
