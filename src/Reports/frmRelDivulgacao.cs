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
    public partial class frmRelDivulgacao : Form
    {
        public frmRelDivulgacao()
        {
            InitializeComponent();
        }

        private void frmRelDivulgacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsMembros.Membros' table. You can move, or remove it, as needed.
            this.RelatorioDivulgacaoTableAdapter.Fill(this.dsRelatorioDivulgacao.RelatorioDivulgacao);

            this.rptRelatorioDivulgacao.RefreshReport();
        }

        private void frmRelDivulgacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.rptRelatorioDivulgacao.Dispose();
        }
    }
}
