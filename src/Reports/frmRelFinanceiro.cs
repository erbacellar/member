using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashInBox
{
    public partial class frmRelFinanceiro : Form
    {
        public frmRelFinanceiro()
        {
            InitializeComponent();
        }

        private void frmRelFinanceiro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRelatorioFinanceiro.RelatorioFinanceiro' table. You can move, or remove it, as needed.
            this.RelatorioFinanceiroTableAdapter.Fill(this.dsRelatorioFinanceiro.RelatorioFinanceiro);

            this.rptRelatorioFinanceiro.RefreshReport();
        }

        private void frmRelFinanceiro_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.rptRelatorioFinanceiro.Dispose();
        }
    }
}
