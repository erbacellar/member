using Member.Common.Enums;
using Member.Common.Helpers;
using Member.Common.Models;
using Member.Dao.Repositories;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CashInBox
{
    public partial class frmRelatorioAniversariantes : Form
    {
        private List<Membro> membros;
        public frmRelatorioAniversariantes()
        {
            InitializeComponent();
        }

        private async void frmRelatorioMembrosPorGrupo_Load(object sender, EventArgs e)
        {
            foreach (string x in Utils.recuperarMeses())
                cboMes.Items.Add(x);

            cboMes.SelectedIndex = 0;
            membros = await MembroDAO.Listar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var mesSelecionado = cboMes.SelectedItem.ToString();
            var mes = Utils.NumeroMes(mesSelecionado);

            var aniversariantes = membros
                .Where(x => x.DataNascimento.Month == mes && x.Status == EnumHelper.GetDescription(StatusType.ATIVO))
                .OrderBy(x => x.DataNascimento.Day)
                .ToList();

            if (!aniversariantes.Any())
                dsAniversariantes.Aniversariantes.Clear();
            else
                foreach (var aniversariante in aniversariantes)
                    dsAniversariantes.Aniversariantes.AddAniversariantesRow(aniversariante.DataNascimento, aniversariante.Nome, aniversariante.Email, mesSelecionado);

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
