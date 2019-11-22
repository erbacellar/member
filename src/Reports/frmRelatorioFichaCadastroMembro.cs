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
    public partial class frmRelatorioFichaCadastroMembro : Form
    {
        public Membro membroRel = null;

        public frmRelatorioFichaCadastroMembro()
        {
            InitializeComponent();
        }

        private void frmRelatorioFichaCadastroMembro_Load(object sender, EventArgs e)
        {
            if (!txtId.Text.Equals(""))
            {
                dsFichaCadMembro.Membro.Clear();

                if(membroRel != null)
                {
                    dsFichaCadMembro.Membro.AddMembroRow(membroRel.Numero, membroRel.DataEntrada, membroRel.DataSaida,
                        membroRel.DataNascimento, membroRel.Nome, membroRel.Cep, membroRel.Logradouro, membroRel.NumEnd,
                        membroRel.Bairro, membroRel.Complemento, membroRel.Cidade, membroRel.Estado, membroRel.Telefone1,
                        membroRel.Telefone2, membroRel.Telefone3, membroRel.Telefone4, membroRel.Email, membroRel.Cpf,
                        membroRel.Rg, membroRel.GrauInstrucao, membroRel.Profissao, membroRel.Espirita,
                        membroRel.ConheceEspiritismoKardecista, membroRel.FezCurso, membroRel.CursoPbde, membroRel.CursoEsde,
                        membroRel.CursoCoem, membroRel.CursoOutros, membroRel.AondeCursou, membroRel.JaLeuLivrosEspiritas,
                        membroRel.QuaisLivros, membroRel.GostariaTrabalhoVoluntario, membroRel.DistribuicaoAlimento,
                        membroRel.OracaoPasseDomicilio, membroRel.DistribuicaoAgasalho, membroRel.Passes, membroRel.Biblioteca,
                        membroRel.Palestras, membroRel.AtendimentoFraterno, membroRel.VisitaMensalAsilo, membroRel.PasseDomingo,
                        membroRel.GrupoDia, membroRel.GrupoHorario, DateTime.Now);
                }
            }

            this.rptFichaCadMembro.RefreshReport();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmConsultarMembro f = new frmConsultarMembro(this);
            f.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            frmRelatorioFichaCadastroMembro_Load(sender, e);
        }
    }
}
