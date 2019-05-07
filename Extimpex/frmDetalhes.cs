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
    public partial class frmDetalhes : Form
    {
        frmEntEsto Instancia;
        int Nota;
        public frmDetalhes(frmEntEsto frmEntEsto)
        {
            InitializeComponent();
            Instancia = frmEntEsto;
            Nota = int.Parse(Instancia.dtaGridRelat.CurrentRow.Cells[2].Value.ToString());
        }

        private void frmDetalhes_Load(object sender, EventArgs e)
        {
           
            this.Relatorio_DetalhesTableAdapter.relatDetalhes(this.BancoExtimpexDataSet.Relatorio_Detalhes, Nota);
            this.extimpex_FornecedorTableAdapter.Fill(this.BancoExtimpexDataSet.Extimpex_Fornecedor);
            this.Nota_FiscalTableAdapter.Fill(this.BancoExtimpexDataSet.Nota_Fiscal);
            this.Notas_ProdutoTableAdapter.Fill(this.BancoExtimpexDataSet.Notas_Produto);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
