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
    public partial class frmRelatorioMembrosPorGrupo : Form
    {
        public frmRelatorioMembrosPorGrupo()
        {
            InitializeComponent();
        }

        private void frmRelatorioMembrosPorGrupo_Load(object sender, EventArgs e)
        {
            foreach(string x in Utils.recuperarDiasSemana())
            {
                cboGrupoDia.Items.Add(x);
            }

            foreach (string x in Utils.recuperarHorarios())
            {
                cboGrupoHorario.Items.Add(x);
            }

            cboGrupoDia.SelectedIndex = 0;
            cboGrupoHorario.SelectedIndex = 0;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.MembrosTableAdapter.Fill(this.dsMembrosPorGrupo.Membros, cboGrupoDia.SelectedItem.ToString(), cboGrupoHorario.SelectedItem.ToString());

            this.rptRelGruposPorMembros.RefreshReport();
        }

        private void frmRelatorioMembrosPorGrupo_FormClosing(object sender, FormClosingEventArgs e)
        {
            rptRelGruposPorMembros.Dispose();
        }
    }
}
