using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extimpex
{
    public partial class frmFluxo_de_Caixa : Form
    {
        public frmFluxo_de_Caixa()
        {
            InitializeComponent();
        }

        private void fluxo_de_CaixaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void frmFluxo_de_Caixa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoExtimpexDataSet.Fluxo_de_Caixa' table. You can move, or remove it, as needed.
            this.fluxo_de_CaixaTableAdapter.Fill(this.bancoExtimpexDataSet.Fluxo_de_Caixa);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
