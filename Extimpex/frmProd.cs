using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Extimpex
{
    public partial class frmProd : Form
    {
        public frmProd()
        {
            InitializeComponent();
        }

        private void frmProd_Load(object sender, EventArgs e)
        {

        }

        private void btnProSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdPesq_Click(object sender, EventArgs e)
        {
            if (rdCod.Checked)
            {
                this.produtoTableAdapter.queryPesquisaCodigo(this.bancoExtimpexDataSet.Produto, txtDescr.Text);
            }
            else
                if (rdNome.Checked)
                {
                    this.produtoTableAdapter.queryPesquisaNome(this.bancoExtimpexDataSet.Produto, txtDescr.Text);
                }
        }

    }
}
