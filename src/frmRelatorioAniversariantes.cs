using Microsoft.Reporting.WinForms;
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
    public partial class frmRelatorioAniversariantes : Form
    {
        public frmRelatorioAniversariantes()
        {
            InitializeComponent();
        }

        private void frmRelatorioMembrosPorGrupo_Load(object sender, EventArgs e)
        {
            foreach(string x in Utils.recuperarMeses())
            {
                cboMes.Items.Add(x);
            }
            

            cboMes.SelectedIndex = 0;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.AniversariantesTableAdapter.Fill(this.dsAniversariantes.Aniversariantes, Utils.NumeroMes(cboMes.SelectedItem.ToString()));

            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("mes", cboMes.SelectedItem.ToString());
            this.rptRelAniversariantes.LocalReport.SetParameters(parameters);


            this.rptRelAniversariantes.RefreshReport();
        }

        private void frmRelatorioMembrosPorGrupo_FormClosing(object sender, FormClosingEventArgs e)
        {
            rptRelAniversariantes.Dispose();
        }
    }
}
