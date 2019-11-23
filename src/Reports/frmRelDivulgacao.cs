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

        private async void frmRelDivulgacao_Load(object sender, EventArgs e)
        {
            var membrosPeso = await MembroDAO.GetMembrosPesoGrupo();
            if (membrosPeso.Any())
            {
                membrosPeso = membrosPeso.Where(x => x.Membro.Isento.HasValue && !x.Membro.Isento.Value).OrderBy(x => x.Peso);

                foreach (var item in membrosPeso)
                {
                    var membro = item.Membro;
                    var peso = item.Peso;
                    dsRelatorioDivulgacao.RelatorioDivulgacao.AddRelatorioDivulgacaoRow(
                        membro.Nome,
                        membro.DataNascimento,
                        membro.GrupoDia,
                        membro.GrupoHorario,
                        membro.Email,
                        membro.Telefone1,
                        membro.Telefone2,
                        membro.Telefone3,
                        membro.Telefone4,
                        peso);

                }
            }

            this.rptRelatorioDivulgacao.RefreshReport();
        }

        private void frmRelDivulgacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.rptRelatorioDivulgacao.Dispose();
        }
    }
}
