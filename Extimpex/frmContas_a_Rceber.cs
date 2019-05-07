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
    public partial class frmContas_a_Receber : Form
    {
        public frmContas_a_Receber()
        {
            InitializeComponent();
        }

        private void conta_a_ReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void frmContas_a_Receber_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoExtimpexDataSet.Conta_a_Receber' table. You can move, or remove it, as needed.
            this.conta_a_ReceberTableAdapter.Fill(this.bancoExtimpexDataSet.Conta_a_Receber);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
