using Member.Common.Models;
using Member.Dao.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CashInBox
{
    public partial class frmRelatorioVoluntarios : Form
    {
        public frmRelatorioVoluntarios()
        {
            InitializeComponent();
        }

        private async void frmRelatorioVoluntarios_Load(object sender, EventArgs e)
        {
            var membrosVoluntarios = await MembroDAO.ObterMembrosPorVoluntarios();
            foreach (Membro member in membrosVoluntarios)
            {
                dsVoluntarios.Voluntarios.AddVoluntariosRow(member.Nome, AcoesSociais(member));
            }

            this.rptRelVoluntarios.RefreshReport();
        }

        private string AcoesSociais(Membro member)
        {
            List<string> acoesSociais = new List<string>();
           

            if (member.OracaoPasseDomicilio) 
            {
                acoesSociais.Add("Oração/Passe a Domicílio");
            }
            if (member.DistribuicaoAlimento)
            {
                acoesSociais.Add("Distribuição de Alimento");
            }
            if (member.DistribuicaoAgasalho) 
            {
                acoesSociais.Add("Distribuição de Agasalho");
            }
            if(member.Passes)
            {
                acoesSociais.Add("Secretaria");
            }
            if (member.Biblioteca)
            {
                acoesSociais.Add("Biblioteca");
            }
            if(member.Palestras)
            {
                acoesSociais.Add("Palestras");
            }
            if (member.AtendimentoFraterno)
            {
                acoesSociais.Add("Atendimento Fraterno");
            }
            if (member.VisitaMensalAsilo)
            {
                acoesSociais.Add("Visita Mensal a Asilo");
            }
            if (member.PasseDomingo)
            {
                acoesSociais.Add("Passe ao Domingo");
            }

            return string.Join("\r\n", acoesSociais.ToArray());
        }
    }
}
