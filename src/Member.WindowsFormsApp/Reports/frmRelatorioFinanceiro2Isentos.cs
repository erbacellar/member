using Member.Dao.Repositories;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CashInBox
{
    public partial class frmRelatorioFinanceiro2Isentos : Form
    {
        public frmRelatorioFinanceiro2Isentos()
        {
            InitializeComponent();
        }

        private async void frmRelatorioFinanceiro2Isentos_Load(object sender, EventArgs e)
        {
            var membrosPeso = await MembroDAO.GetMembrosPesoGrupo();
            if (membrosPeso.Any())
            {
                membrosPeso = membrosPeso.Where(x => x.Membro.Isento.HasValue && x.Membro.Isento.Value).OrderBy(x => x.Peso);

                foreach (var item in membrosPeso)
                {
                    var membro = item.Membro;
                    var peso = item.Peso;
                    dsRelatorioFinanceiro.RelatorioFinanceiro.AddRelatorioFinanceiroRow(
                        membro.Nome,
                        membro.Cpf,
                        membro.Rg,
                        membro.GrupoDia,
                        membro.GrupoHorario,
                        membro.Cep,
                        membro.Logradouro,
                        membro.Bairro,
                        membro.Cidade,
                        membro.Estado,
                        membro.NumEnd,
                        peso);

                }
            }

            this.rptRelatorioFinanceiro.RefreshReport();
        }

        private void frmRelatorioFinanceiro2Isentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.rptRelatorioFinanceiro.Dispose();
        }
    }
}
