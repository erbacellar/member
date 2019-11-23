using CashInBox.Enums;
using CashInBox.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CashInBox
{
    public partial class frmRelatorioMembrosPorGrupo : Form
    {
        private List<Membro> membros;
        public frmRelatorioMembrosPorGrupo()
        {
            InitializeComponent();
        }

        private async void frmRelatorioMembrosPorGrupo_Load(object sender, EventArgs e)
        {
            foreach (string x in Utils.recuperarDiasSemana())
            {
                cboGrupoDia.Items.Add(x);
            }

            foreach (string x in Utils.recuperarHorarios())
            {
                cboGrupoHorario.Items.Add(x);
            }

            cboGrupoDia.SelectedIndex = 0;
            cboGrupoHorario.SelectedIndex = 0;

            membros = await MembroDAO.Listar();
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            var dia = cboGrupoDia.SelectedItem.ToString();
            var horario = cboGrupoHorario.SelectedItem.ToString();

            var membrosFiltrados = membros
                .Where(x => x.GrupoDia == dia && x.GrupoHorario == horario && x.Status == EnumHelper.GetDescription(StatusType.ATIVO))
                .OrderBy(x => x.Nome).ToList();

            if (!membrosFiltrados.Any())
                dsMembrosPorGrupo.Membros.Clear();
            else
                foreach (var membro in membrosFiltrados)
                    dsMembrosPorGrupo.Membros.AddMembrosRow(membro.Nome, membro.GrupoDia, membro.GrupoHorario);

            this.rptRelGruposPorMembros.RefreshReport();
        }

        private void frmRelatorioMembrosPorGrupo_FormClosing(object sender, FormClosingEventArgs e)
        {
            rptRelGruposPorMembros.Dispose();
        }
    }
}
