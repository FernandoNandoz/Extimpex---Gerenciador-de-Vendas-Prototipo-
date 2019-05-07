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
    public partial class frmDetalhesVendas : Form
    {
        frmVenda Instancia;
        int Nota;

        public frmDetalhesVendas(frmVenda frmVenda)
        {
            InitializeComponent();
            Instancia = frmVenda;
            Nota = int.Parse(Instancia.dtaGridRelate.CurrentRow.Cells[3].Value.ToString());

        }


        private void frmDetalhesVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BancoExtimpexDataSet.Detalhes_Venda' table. You can move, or remove it, as needed.
            this.Detalhes_VendaTableAdapter.Fill(this.BancoExtimpexDataSet.Detalhes_Venda, Nota);

            this.reportViewer1.RefreshReport();
        }
    }
}
